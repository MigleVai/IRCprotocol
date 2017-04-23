namespace IRC
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chatListBox = new System.Windows.Forms.ListBox();
            this.channelListerButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.channelListBox = new System.Windows.Forms.ListBox();
            this.joinButton = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chatListBox
            // 
            this.chatListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chatListBox.FormattingEnabled = true;
            this.chatListBox.HorizontalScrollbar = true;
            this.chatListBox.Location = new System.Drawing.Point(43, 43);
            this.chatListBox.Name = "chatListBox";
            this.chatListBox.Size = new System.Drawing.Size(539, 407);
            this.chatListBox.TabIndex = 0;
            // 
            // channelListerButton
            // 
            this.channelListerButton.Location = new System.Drawing.Point(611, 12);
            this.channelListerButton.Name = "channelListerButton";
            this.channelListerButton.Size = new System.Drawing.Size(83, 23);
            this.channelListerButton.TabIndex = 2;
            this.channelListerButton.Text = "List channels";
            this.channelListerButton.UseVisualStyleBackColor = true;
            this.channelListerButton.Click += new System.EventHandler(this.channelListerButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(124, 469);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(297, 20);
            this.messageTextBox.TabIndex = 3;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(459, 467);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // channelListBox
            // 
            this.channelListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.channelListBox.FormattingEnabled = true;
            this.channelListBox.Location = new System.Drawing.Point(611, 43);
            this.channelListBox.Name = "channelListBox";
            this.channelListBox.Size = new System.Drawing.Size(180, 407);
            this.channelListBox.TabIndex = 6;
            // 
            // joinButton
            // 
            this.joinButton.Location = new System.Drawing.Point(716, 467);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(75, 23);
            this.joinButton.TabIndex = 7;
            this.joinButton.Text = "Join";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // leaveButton
            // 
            this.leaveButton.Location = new System.Drawing.Point(611, 467);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(75, 23);
            this.leaveButton.TabIndex = 8;
            this.leaveButton.Text = "Leave";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Message";
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.channelListBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.channelListerButton);
            this.Controls.Add(this.chatListBox);
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox chatListBox;
        private System.Windows.Forms.Button channelListerButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ListBox channelListBox;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Label label1;
    }
}