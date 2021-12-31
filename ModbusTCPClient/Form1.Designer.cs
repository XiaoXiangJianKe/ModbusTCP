namespace ModbusTCPClient
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.autoSend = new System.Windows.Forms.CheckBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.sendText = new System.Windows.Forms.TextBox();
            this.receiveText = new System.Windows.Forms.TextBox();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.portText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ipText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Location = new System.Drawing.Point(550, 66);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(66, 21);
            this.textBoxInterval.TabIndex = 35;
            this.textBoxInterval.Text = "100";
            // 
            // autoSend
            // 
            this.autoSend.AutoSize = true;
            this.autoSend.Location = new System.Drawing.Point(496, 68);
            this.autoSend.Name = "autoSend";
            this.autoSend.Size = new System.Drawing.Size(48, 16);
            this.autoSend.TabIndex = 34;
            this.autoSend.Text = "自动";
            this.autoSend.UseVisualStyleBackColor = true;
            this.autoSend.CheckedChanged += new System.EventHandler(this.autoSend_CheckedChanged);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(393, 64);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 33;
            this.btn_Send.Text = "发送";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // sendText
            // 
            this.sendText.Location = new System.Drawing.Point(39, 66);
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(306, 21);
            this.sendText.TabIndex = 32;
            // 
            // receiveText
            // 
            this.receiveText.Location = new System.Drawing.Point(39, 106);
            this.receiveText.Multiline = true;
            this.receiveText.Name = "receiveText";
            this.receiveText.ReadOnly = true;
            this.receiveText.Size = new System.Drawing.Size(306, 240);
            this.receiveText.TabIndex = 31;
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(496, 23);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_Disconnect.TabIndex = 30;
            this.btn_Disconnect.Text = "断开";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(393, 23);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 29;
            this.btn_Connect.Text = "连接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(279, 25);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(66, 21);
            this.portText.TabIndex = 28;
            this.portText.Text = "502";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "Port：";
            // 
            // ipText
            // 
            this.ipText.Location = new System.Drawing.Point(72, 25);
            this.ipText.Name = "ipText";
            this.ipText.Size = new System.Drawing.Size(143, 21);
            this.ipText.TabIndex = 26;
            this.ipText.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "IP：";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(393, 323);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 36;
            this.btn_Clear.Text = "清空";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 390);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.textBoxInterval);
            this.Controls.Add(this.autoSend);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.sendText);
            this.Controls.Add(this.receiveText);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ModbusTCPClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.CheckBox autoSend;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox sendText;
        private System.Windows.Forms.TextBox receiveText;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox portText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Clear;
    }
}

