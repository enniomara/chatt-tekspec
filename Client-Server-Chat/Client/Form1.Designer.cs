namespace Client
{
    partial class Form1
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
            this.tbxChatLogs = new System.Windows.Forms.TextBox();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxConnectInformation = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.gbxChatMain = new System.Windows.Forms.GroupBox();
            this.gbxConnect = new System.Windows.Forms.GroupBox();
            this.gbxChatMain.SuspendLayout();
            this.gbxConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxChatLogs
            // 
            this.tbxChatLogs.Location = new System.Drawing.Point(6, 19);
            this.tbxChatLogs.Multiline = true;
            this.tbxChatLogs.Name = "tbxChatLogs";
            this.tbxChatLogs.Size = new System.Drawing.Size(473, 307);
            this.tbxChatLogs.TabIndex = 0;
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(6, 332);
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(358, 20);
            this.tbxMessage.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(370, 332);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(109, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send Message";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxConnectInformation
            // 
            this.tbxConnectInformation.Location = new System.Drawing.Point(6, 19);
            this.tbxConnectInformation.Name = "tbxConnectInformation";
            this.tbxConnectInformation.Size = new System.Drawing.Size(132, 20);
            this.tbxConnectInformation.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(144, 16);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gbxChatMain
            // 
            this.gbxChatMain.Controls.Add(this.tbxChatLogs);
            this.gbxChatMain.Controls.Add(this.tbxMessage);
            this.gbxChatMain.Controls.Add(this.btnSend);
            this.gbxChatMain.Enabled = false;
            this.gbxChatMain.Location = new System.Drawing.Point(12, 12);
            this.gbxChatMain.Name = "gbxChatMain";
            this.gbxChatMain.Size = new System.Drawing.Size(554, 400);
            this.gbxChatMain.TabIndex = 6;
            this.gbxChatMain.TabStop = false;
            this.gbxChatMain.Text = "Chat";
            // 
            // gbxConnect
            // 
            this.gbxConnect.Controls.Add(this.tbxConnectInformation);
            this.gbxConnect.Controls.Add(this.btnConnect);
            this.gbxConnect.Location = new System.Drawing.Point(12, 418);
            this.gbxConnect.Name = "gbxConnect";
            this.gbxConnect.Size = new System.Drawing.Size(554, 52);
            this.gbxConnect.TabIndex = 7;
            this.gbxConnect.TabStop = false;
            this.gbxConnect.Text = "Connect";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 482);
            this.Controls.Add(this.gbxConnect);
            this.Controls.Add(this.gbxChatMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxChatMain.ResumeLayout(false);
            this.gbxChatMain.PerformLayout();
            this.gbxConnect.ResumeLayout(false);
            this.gbxConnect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxChatLogs;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxConnectInformation;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gbxChatMain;
        private System.Windows.Forms.GroupBox gbxConnect;
    }
}

