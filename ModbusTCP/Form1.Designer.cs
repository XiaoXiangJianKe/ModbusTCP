namespace ModbusTCP
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
            this.label1 = new System.Windows.Forms.Label();
            this.ipText = new System.Windows.Forms.TextBox();
            this.portText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.receiveText = new System.Windows.Forms.TextBox();
            this.sendText = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labeY = new System.Windows.Forms.Label();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.labelZ = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.autoSend = new System.Windows.Forms.CheckBox();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.textBoxJ7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP：";
            // 
            // ipText
            // 
            this.ipText.Location = new System.Drawing.Point(76, 24);
            this.ipText.Name = "ipText";
            this.ipText.Size = new System.Drawing.Size(143, 21);
            this.ipText.TabIndex = 1;
            this.ipText.Text = "127.0.0.1";
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(283, 24);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(66, 21);
            this.portText.TabIndex = 3;
            this.portText.Text = "502";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port：";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(397, 22);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "连接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(500, 22);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_Disconnect.TabIndex = 5;
            this.btn_Disconnect.Text = "断开";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // receiveText
            // 
            this.receiveText.Location = new System.Drawing.Point(43, 105);
            this.receiveText.Multiline = true;
            this.receiveText.Name = "receiveText";
            this.receiveText.ReadOnly = true;
            this.receiveText.Size = new System.Drawing.Size(306, 240);
            this.receiveText.TabIndex = 6;
            // 
            // sendText
            // 
            this.sendText.Location = new System.Drawing.Point(43, 65);
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(306, 21);
            this.sendText.TabIndex = 7;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(397, 63);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 8;
            this.btn_Send.Text = "发送";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(397, 322);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "清空";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(395, 108);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(29, 12);
            this.labelX.TabIndex = 10;
            this.labelX.Text = "J1：";
            // 
            // textBoxX
            // 
            this.textBoxX.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxX.Location = new System.Drawing.Point(430, 105);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(66, 21);
            this.textBoxX.TabIndex = 11;
            this.textBoxX.Text = "0.00";
            // 
            // textBoxY
            // 
            this.textBoxY.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxY.Location = new System.Drawing.Point(430, 132);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(66, 21);
            this.textBoxY.TabIndex = 13;
            this.textBoxY.Text = "0.00";
            // 
            // labeY
            // 
            this.labeY.AutoSize = true;
            this.labeY.Location = new System.Drawing.Point(395, 135);
            this.labeY.Name = "labeY";
            this.labeY.Size = new System.Drawing.Size(29, 12);
            this.labeY.TabIndex = 12;
            this.labeY.Text = "J2：";
            // 
            // textBoxZ
            // 
            this.textBoxZ.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxZ.Location = new System.Drawing.Point(430, 159);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.ReadOnly = true;
            this.textBoxZ.Size = new System.Drawing.Size(66, 21);
            this.textBoxZ.TabIndex = 15;
            this.textBoxZ.Text = "0.00";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(395, 162);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(29, 12);
            this.labelZ.TabIndex = 14;
            this.labelZ.Text = "J3：";
            // 
            // textBoxA
            // 
            this.textBoxA.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxA.Location = new System.Drawing.Point(430, 186);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.ReadOnly = true;
            this.textBoxA.Size = new System.Drawing.Size(66, 21);
            this.textBoxA.TabIndex = 17;
            this.textBoxA.Text = "0.00";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(395, 189);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(29, 12);
            this.labelA.TabIndex = 16;
            this.labelA.Text = "J4：";
            // 
            // textBoxB
            // 
            this.textBoxB.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxB.Location = new System.Drawing.Point(430, 213);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.ReadOnly = true;
            this.textBoxB.Size = new System.Drawing.Size(66, 21);
            this.textBoxB.TabIndex = 19;
            this.textBoxB.Text = "0.00";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(395, 216);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(29, 12);
            this.labelB.TabIndex = 18;
            this.labelB.Text = "J5：";
            // 
            // textBoxC
            // 
            this.textBoxC.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxC.Location = new System.Drawing.Point(430, 240);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.ReadOnly = true;
            this.textBoxC.Size = new System.Drawing.Size(66, 21);
            this.textBoxC.TabIndex = 21;
            this.textBoxC.Text = "0.00";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(395, 243);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(29, 12);
            this.labelC.TabIndex = 20;
            this.labelC.Text = "J6：";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // autoSend
            // 
            this.autoSend.AutoSize = true;
            this.autoSend.Location = new System.Drawing.Point(500, 67);
            this.autoSend.Name = "autoSend";
            this.autoSend.Size = new System.Drawing.Size(48, 16);
            this.autoSend.TabIndex = 22;
            this.autoSend.Text = "自动";
            this.autoSend.UseVisualStyleBackColor = true;
            this.autoSend.CheckedChanged += new System.EventHandler(this.autoSend_CheckedChanged);
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Location = new System.Drawing.Point(554, 65);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(66, 21);
            this.textBoxInterval.TabIndex = 24;
            this.textBoxInterval.Text = "100";
            // 
            // textBoxJ7
            // 
            this.textBoxJ7.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxJ7.Location = new System.Drawing.Point(430, 267);
            this.textBoxJ7.Name = "textBoxJ7";
            this.textBoxJ7.ReadOnly = true;
            this.textBoxJ7.Size = new System.Drawing.Size(66, 21);
            this.textBoxJ7.TabIndex = 26;
            this.textBoxJ7.Text = "0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(646, 392);
            this.Controls.Add(this.textBoxJ7);
            this.Controls.Add(this.textBoxInterval);
            this.Controls.Add(this.autoSend);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxZ);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.labeY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.sendText);
            this.Controls.Add(this.receiveText);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipText);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ModbusTCP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipText;
        private System.Windows.Forms.TextBox portText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.TextBox receiveText;
        private System.Windows.Forms.TextBox sendText;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labeY;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox autoSend;
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.TextBox textBoxJ7;
    }
}

