namespace RS232
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TxtCom = new System.Windows.Forms.TextBox();
            this.TxtBaud = new System.Windows.Forms.TextBox();
            this.ComboBoxParity = new System.Windows.Forms.ComboBox();
            this.TxtDataBit = new System.Windows.Forms.TextBox();
            this.BtnDefault = new System.Windows.Forms.Button();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TxtWrite = new System.Windows.Forms.TextBox();
            this.BtnWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtCom
            // 
            this.TxtCom.Location = new System.Drawing.Point(11, 13);
            this.TxtCom.Name = "TxtCom";
            this.TxtCom.Size = new System.Drawing.Size(50, 20);
            this.TxtCom.TabIndex = 0;
            // 
            // TxtBaud
            // 
            this.TxtBaud.Location = new System.Drawing.Point(79, 13);
            this.TxtBaud.Name = "TxtBaud";
            this.TxtBaud.Size = new System.Drawing.Size(50, 20);
            this.TxtBaud.TabIndex = 1;
            // 
            // ComboBoxParity
            // 
            this.ComboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxParity.FormattingEnabled = true;
            this.ComboBoxParity.Location = new System.Drawing.Point(147, 14);
            this.ComboBoxParity.Name = "ComboBoxParity";
            this.ComboBoxParity.Size = new System.Drawing.Size(60, 21);
            this.ComboBoxParity.TabIndex = 2;
            // 
            // TxtDataBit
            // 
            this.TxtDataBit.Location = new System.Drawing.Point(225, 13);
            this.TxtDataBit.Name = "TxtDataBit";
            this.TxtDataBit.Size = new System.Drawing.Size(20, 20);
            this.TxtDataBit.TabIndex = 3;
            // 
            // BtnDefault
            // 
            this.BtnDefault.Location = new System.Drawing.Point(263, 13);
            this.BtnDefault.Name = "BtnDefault";
            this.BtnDefault.Size = new System.Drawing.Size(50, 25);
            this.BtnDefault.TabIndex = 4;
            this.BtnDefault.Text = "Default";
            this.BtnDefault.UseVisualStyleBackColor = true;
            this.BtnDefault.Click += new System.EventHandler(this.BtnDefault_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(336, 13);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 25);
            this.BtnConnect.TabIndex = 5;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Location = new System.Drawing.Point(537, 13);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(75, 25);
            this.BtnDisconnect.TabIndex = 6;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // TxtLog
            // 
            this.TxtLog.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtLog.Location = new System.Drawing.Point(11, 61);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtLog.Size = new System.Drawing.Size(601, 378);
            this.TxtLog.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TxtWrite
            // 
            this.TxtWrite.Location = new System.Drawing.Point(11, 445);
            this.TxtWrite.Multiline = true;
            this.TxtWrite.Name = "TxtWrite";
            this.TxtWrite.Size = new System.Drawing.Size(520, 24);
            this.TxtWrite.TabIndex = 8;
            // 
            // BtnWrite
            // 
            this.BtnWrite.Location = new System.Drawing.Point(537, 445);
            this.BtnWrite.Name = "BtnWrite";
            this.BtnWrite.Size = new System.Drawing.Size(75, 25);
            this.BtnWrite.TabIndex = 9;
            this.BtnWrite.Text = "Enter";
            this.BtnWrite.UseVisualStyleBackColor = true;
            this.BtnWrite.Click += new System.EventHandler(this.BtnWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(0, 0);
            this.ControlBox = false;
            this.Controls.Add(this.BtnWrite);
            this.Controls.Add(this.TxtWrite);
            this.Controls.Add(this.TxtLog);
            this.Controls.Add(this.BtnDisconnect);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.BtnDefault);
            this.Controls.Add(this.TxtDataBit);
            this.Controls.Add(this.ComboBoxParity);
            this.Controls.Add(this.TxtBaud);
            this.Controls.Add(this.TxtCom);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GS";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCom;
        private System.Windows.Forms.TextBox TxtBaud;
        private System.Windows.Forms.ComboBox ComboBoxParity;
        private System.Windows.Forms.TextBox TxtDataBit;
        private System.Windows.Forms.Button BtnDefault;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TxtWrite;
        private System.Windows.Forms.Button BtnWrite;
    }
}

