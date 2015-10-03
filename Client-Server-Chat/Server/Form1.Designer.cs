namespace Server
{
    partial class serverGUI
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
            this.lbxConnectedClients = new System.Windows.Forms.ListBox();
            this.lblLoginInfolbl = new System.Windows.Forms.Label();
            this.tbxLoginInfo = new System.Windows.Forms.TextBox();
            this.lblConnectedClients = new System.Windows.Forms.Label();
            this.btnStartListening = new System.Windows.Forms.Button();
            this.btnStopListening = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxConnectedClients
            // 
            this.lbxConnectedClients.FormattingEnabled = true;
            this.lbxConnectedClients.Location = new System.Drawing.Point(15, 84);
            this.lbxConnectedClients.Name = "lbxConnectedClients";
            this.lbxConnectedClients.Size = new System.Drawing.Size(386, 199);
            this.lbxConnectedClients.TabIndex = 0;
            // 
            // lblLoginInfolbl
            // 
            this.lblLoginInfolbl.AutoSize = true;
            this.lblLoginInfolbl.Location = new System.Drawing.Point(12, 13);
            this.lblLoginInfolbl.Name = "lblLoginInfolbl";
            this.lblLoginInfolbl.Size = new System.Drawing.Size(162, 13);
            this.lblLoginInfolbl.TabIndex = 1;
            this.lblLoginInfolbl.Text = "Copy this to the client to connect";
            // 
            // tbxLoginInfo
            // 
            this.tbxLoginInfo.Location = new System.Drawing.Point(181, 13);
            this.tbxLoginInfo.Name = "tbxLoginInfo";
            this.tbxLoginInfo.Size = new System.Drawing.Size(217, 20);
            this.tbxLoginInfo.TabIndex = 2;
            // 
            // lblConnectedClients
            // 
            this.lblConnectedClients.AutoSize = true;
            this.lblConnectedClients.Location = new System.Drawing.Point(15, 65);
            this.lblConnectedClients.Name = "lblConnectedClients";
            this.lblConnectedClients.Size = new System.Drawing.Size(96, 13);
            this.lblConnectedClients.TabIndex = 3;
            this.lblConnectedClients.Text = "Connected Clients:";
            // 
            // btnStartListening
            // 
            this.btnStartListening.Location = new System.Drawing.Point(91, 318);
            this.btnStartListening.Name = "btnStartListening";
            this.btnStartListening.Size = new System.Drawing.Size(97, 23);
            this.btnStartListening.TabIndex = 4;
            this.btnStartListening.Text = "Start Listening";
            this.btnStartListening.UseVisualStyleBackColor = true;
            // 
            // btnStopListening
            // 
            this.btnStopListening.Location = new System.Drawing.Point(210, 318);
            this.btnStopListening.Name = "btnStopListening";
            this.btnStopListening.Size = new System.Drawing.Size(102, 23);
            this.btnStopListening.TabIndex = 5;
            this.btnStopListening.Text = "Stop Listening";
            this.btnStopListening.UseVisualStyleBackColor = true;
            // 
            // serverGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 353);
            this.Controls.Add(this.btnStopListening);
            this.Controls.Add(this.btnStartListening);
            this.Controls.Add(this.lblConnectedClients);
            this.Controls.Add(this.tbxLoginInfo);
            this.Controls.Add(this.lblLoginInfolbl);
            this.Controls.Add(this.lbxConnectedClients);
            this.Name = "serverGUI";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxConnectedClients;
        private System.Windows.Forms.Label lblLoginInfolbl;
        private System.Windows.Forms.TextBox tbxLoginInfo;
        private System.Windows.Forms.Label lblConnectedClients;
        private System.Windows.Forms.Button btnStartListening;
        private System.Windows.Forms.Button btnStopListening;
    }
}

