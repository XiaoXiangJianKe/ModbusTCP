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
            this.label3 = new System.Windows.Forms.Label();
            this.functionCodeList = new System.Windows.Forms.ComboBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Location = new System.Drawing.Point(733, 115);
            this.textBoxInterval.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(87, 25);
            this.textBoxInterval.TabIndex = 35;
            this.textBoxInterval.Text = "100";
            // 
            // autoSend
            // 
            this.autoSend.AutoSize = true;
            this.autoSend.Location = new System.Drawing.Point(661, 118);
            this.autoSend.Margin = new System.Windows.Forms.Padding(4);
            this.autoSend.Name = "autoSend";
            this.autoSend.Size = new System.Drawing.Size(59, 19);
            this.autoSend.TabIndex = 34;
            this.autoSend.Text = "自动";
            this.autoSend.UseVisualStyleBackColor = true;
            this.autoSend.CheckedChanged += new System.EventHandler(this.autoSend_CheckedChanged);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(524, 113);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(100, 29);
            this.btn_Send.TabIndex = 33;
            this.btn_Send.Text = "发送";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // sendText
            // 
            this.sendText.Location = new System.Drawing.Point(52, 115);
            this.sendText.Margin = new System.Windows.Forms.Padding(4);
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(407, 25);
            this.sendText.TabIndex = 32;
            // 
            // receiveText
            // 
            this.receiveText.Location = new System.Drawing.Point(52, 165);
            this.receiveText.Margin = new System.Windows.Forms.Padding(4);
            this.receiveText.Multiline = true;
            this.receiveText.Name = "receiveText";
            this.receiveText.ReadOnly = true;
            this.receiveText.Size = new System.Drawing.Size(407, 299);
            this.receiveText.TabIndex = 31;
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(661, 29);
            this.btn_Disconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(100, 29);
            this.btn_Disconnect.TabIndex = 30;
            this.btn_Disconnect.Text = "断开";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(524, 29);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(100, 29);
            this.btn_Connect.TabIndex = 29;
            this.btn_Connect.Text = "连接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(372, 31);
            this.portText.Margin = new System.Windows.Forms.Padding(4);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(87, 25);
            this.portText.TabIndex = 28;
            this.portText.Text = "502";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Port：";
            // 
            // ipText
            // 
            this.ipText.Location = new System.Drawing.Point(96, 31);
            this.ipText.Margin = new System.Windows.Forms.Padding(4);
            this.ipText.Name = "ipText";
            this.ipText.Size = new System.Drawing.Size(189, 25);
            this.ipText.TabIndex = 26;
            this.ipText.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "IP：";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(524, 437);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 29);
            this.btn_Clear.TabIndex = 36;
            this.btn_Clear.Text = "清空";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "FunctionCode：";
            // 
            // functionCodeList
            // 
            this.functionCodeList.FormattingEnabled = true;
            this.functionCodeList.Items.AddRange(new object[] {
            "01",
            "03"});
            this.functionCodeList.Location = new System.Drawing.Point(174, 73);
            this.functionCodeList.Name = "functionCodeList";
            this.functionCodeList.Size = new System.Drawing.Size(121, 23);
            this.functionCodeList.TabIndex = 38;
            this.functionCodeList.Text = "01";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(419, 73);
            this.quantity.Margin = new System.Windows.Forms.Padding(4);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(87, 25);
            this.quantity.TabIndex = 40;
            this.quantity.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Quantity：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 488);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.functionCodeList);
            this.Controls.Add(this.label3);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox functionCodeList;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label4;
    }
}

