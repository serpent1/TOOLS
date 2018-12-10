namespace DispenserCOMM
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SendReceiveData = new System.Windows.Forms.Button();
            this.clearSendData = new System.Windows.Forms.Button();
            this.openCloseSpbtn = new System.Windows.Forms.Button();
            this.CommCheck = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "连接油机通讯测试";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(150, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 64);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "串口选择";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SendReceiveData);
            this.groupBox2.Controls.Add(this.clearSendData);
            this.groupBox2.Controls.Add(this.openCloseSpbtn);
            this.groupBox2.Controls.Add(this.CommCheck);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(630, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 378);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COMM";
            // 
            // SendReceiveData
            // 
            this.SendReceiveData.Location = new System.Drawing.Point(30, 295);
            this.SendReceiveData.Name = "SendReceiveData";
            this.SendReceiveData.Size = new System.Drawing.Size(148, 41);
            this.SendReceiveData.TabIndex = 13;
            this.SendReceiveData.Text = "清空接收";
            this.SendReceiveData.UseVisualStyleBackColor = true;
            this.SendReceiveData.Click += new System.EventHandler(this.SendReceiveData_Click);
            // 
            // clearSendData
            // 
            this.clearSendData.Location = new System.Drawing.Point(30, 228);
            this.clearSendData.Name = "clearSendData";
            this.clearSendData.Size = new System.Drawing.Size(148, 40);
            this.clearSendData.TabIndex = 12;
            this.clearSendData.Text = "清空发送";
            this.clearSendData.UseVisualStyleBackColor = true;
            this.clearSendData.Click += new System.EventHandler(this.clearSendData_Click);
            // 
            // openCloseSpbtn
            // 
            this.openCloseSpbtn.Location = new System.Drawing.Point(30, 100);
            this.openCloseSpbtn.Name = "openCloseSpbtn";
            this.openCloseSpbtn.Size = new System.Drawing.Size(148, 39);
            this.openCloseSpbtn.TabIndex = 11;
            this.openCloseSpbtn.Text = "打开串口";
            this.openCloseSpbtn.UseVisualStyleBackColor = true;
            this.openCloseSpbtn.Click += new System.EventHandler(this.openCloseSpbtn_Click);
            // 
            // CommCheck
            // 
            this.CommCheck.Location = new System.Drawing.Point(30, 166);
            this.CommCheck.Name = "CommCheck";
            this.CommCheck.Size = new System.Drawing.Size(148, 35);
            this.CommCheck.TabIndex = 10;
            this.CommCheck.Text = "开始寻址";
            this.CommCheck.UseVisualStyleBackColor = true;
            this.CommCheck.Click += new System.EventHandler(this.CommCheck_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 454);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(935, 25);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslabel
            // 
            this.statuslabel.ActiveLinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statuslabel.BackColor = System.Drawing.SystemColors.Control;
            this.statuslabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(920, 20);
            this.statuslabel.Spring = true;
            this.statuslabel.Text = "Not Connected";
            // 
            // sendtbx
            // 
            this.sendtbx.Location = new System.Drawing.Point(21, 65);
            this.sendtbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendtbx.Multiline = true;
            this.sendtbx.Name = "sendtbx";
            this.sendtbx.Size = new System.Drawing.Size(240, 247);
            this.sendtbx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 0);
            this.label2.TabIndex = 3;
            this.label2.Text = "发送框";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "接收框";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(293, 65);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 247);
            this.textBox2.TabIndex = 5;
            // 
            // Data
            // 
            this.Data.Controls.Add(this.label5);
            this.Data.Controls.Add(this.textBox2);
            this.Data.Controls.Add(this.label3);
            this.Data.Controls.Add(this.label2);
            this.Data.Controls.Add(this.sendtbx);
            this.Data.Location = new System.Drawing.Point(40, 124);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(559, 327);
            this.Data.TabIndex = 7;
            this.Data.TabStop = false;
            this.Data.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "发送框";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 479);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "DispenserCOMM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Data.ResumeLayout(false);
            this.Data.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel;
        private System.Windows.Forms.Button CommCheck;
        private System.Windows.Forms.TextBox sendtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox Data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button openCloseSpbtn;
        private System.Windows.Forms.Button SendReceiveData;
        private System.Windows.Forms.Button clearSendData;
    }
}

