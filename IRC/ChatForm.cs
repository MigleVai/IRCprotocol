using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRC
{
    public partial class ChatForm : Form
    {
        private string _host = "chat.freenode.net"; //chat.freenode.net   irc.romaniachat.eu
        private int _port = 6667;

        private TcpClient _clientSocket = new TcpClient();
        private NetworkStream _stream = default(NetworkStream);

        public string NickName { get; set; }
        public string RealName { get; set; }
        public string Channel { get; set; }

        List<string> listChannels = new List<string>();
        public ChatForm(string nick, string realName)
        {
            _clientSocket.Connect(_host, _port);
            _stream = _clientSocket.GetStream();
            InitializeComponent();
            NickName = nick;
            RealName = realName;
            joinButton.Enabled = false;
        }

        public void Conect()
        {
            if (_clientSocket.Connected)
            {
                WriteAsync($"NICK {NickName}");
                WriteAsync($"USER {NickName} 0 * : {RealName}");
            }
            else
            {
                chatListBox.Items.Add("Not connected..");
            }
        }

        private void channelListerButton_Click(object sender, EventArgs e)
        {
            ListChannels();
        }

        public Task ReadFromStream()
        {
            return Task.Run(async () =>
            {
                var buffer = new byte[1024];
                while (true)
                {
                    var bytesRead = await _stream.ReadAsync(buffer, 0, buffer.Length);
                    var mess = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    if (mess.Contains("PING"))
                    {
                        var list = mess.Split(new string[] { "PING" }, StringSplitOptions.None);
                        await WriteAsync("PONG " + list[1]);
                    }
                    else
                    {
                        Invoke((MethodInvoker)(() => chatListBox.Items.Add(mess)));
                    }
                }
            });
        }

        public void ListChannels()
        {
            WriteAsync($"LIST");

            ReadAsync();
            channelListBox.Items.AddRange(listChannels.ToArray());

            joinButton.Enabled = true;
        }

        public void ReadAsync()
        {
            var buffer = new byte[1024];
            var con = true;
            while (con)
            {
                var bytesRead = _stream.ReadAsync(buffer, 0, buffer.Length);
                var mess = Encoding.UTF8.GetString(buffer, 0, bytesRead.Result);
                var matchList = Regex.Matches(mess, @"#(.+?)\x20");
                var temp = matchList.OfType<Match>().Distinct().ToArray();
                listChannels.AddRange(temp.Cast<Match>().Select(o => o.Value).ToList());
                if (mess.Contains("End of /LIST"))
                    con = false;
            }
        }

        public Task WriteAsync(string data)
        {
            var bytes = Encoding.UTF8.GetBytes($"{data}{Environment.NewLine}");
            return _stream.WriteAsync(bytes, 0, bytes.Length);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var mess = "PRIVMSG " + Channel + ":" + messageTextBox.Text;
            WriteAsync(mess);
            chatListBox.Items.Add(mess);
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            if (channelListBox.SelectedIndex != -1)
            {
                WriteAsync("JOIN " + channelListBox.SelectedItem);
                Channel = channelListBox.SelectedItem.ToString();
                joinButton.Enabled = false;
            }
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            if (Channel != null)
            {
                WriteAsync("PART " + Channel);
                Channel = null;
                joinButton.Enabled = true;
            }
        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteAsync("QUIT :Bye bye");
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            Conect();
            ReadFromStream();
        }
    }
}
