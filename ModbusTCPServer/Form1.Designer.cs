namespace ModbusTCPServer
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
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.autoSend = new System.Windows.Forms.CheckBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.sendText = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.receiveText = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP：";
            // 
            // ipText
            // 
            this.ipText.Location = new System.Drawing.Point(76, 20);
            this.ipText.Name = "ipText";
            this.ipText.Size = new System.Drawing.Size(143, 21);
            this.ipText.TabIndex = 2;
            this.ipText.Text = "127.0.0.1";
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(278, 20);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(66, 21);
            this.portText.TabIndex = 5;
            this.portText.Text = "502";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port：";
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(501, 18);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_Disconnect.TabIndex = 7;
            this.btn_Disconnect.Text = "断开";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(398, 18);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 6;
            this.btn_Create.Text = "创建";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Location = new System.Drawing.Point(555, 60);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(66, 21);
            this.textBoxInterval.TabIndex = 28;
            this.textBoxInterval.Text = "100";
            // 
            // autoSend
            // 
            this.autoSend.AutoSize = true;
            this.autoSend.Location = new System.Drawing.Point(501, 62);
            this.autoSend.Name = "autoSend";
            this.autoSend.Size = new System.Drawing.Size(48, 16);
            this.autoSend.TabIndex = 27;
            this.autoSend.Text = "自动";
            this.autoSend.UseVisualStyleBackColor = true;
            this.autoSend.CheckedChanged += new System.EventHandler(this.autoSend_CheckedChanged);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(398, 58);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 26;
            this.btn_Send.Text = "发送";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // sendText
            // 
            this.sendText.Location = new System.Drawing.Point(44, 60);
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(306, 21);
            this.sendText.TabIndex = 25;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(397, 331);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 30;
            this.btn_Clear.Text = "清空";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // receiveText
            // 
            this.receiveText.Location = new System.Drawing.Point(43, 114);
            this.receiveText.Multiline = true;
            this.receiveText.Name = "receiveText";
            this.receiveText.ReadOnly = true;
            this.receiveText.Size = new System.Drawing.Size(306, 240);
            this.receiveText.TabIndex = 29;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 398);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.receiveText);
            this.Controls.Add(this.textBoxInterval);
            this.Controls.Add(this.autoSend);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.sendText);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ModbusTCPServer";
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
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.CheckBox autoSend;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox sendText;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox receiveText;
        private System.Windows.Forms.Timer timer1;
    }
}

