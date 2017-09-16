namespace MapImprovement
{
    partial class ClientSettingForm
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
            this.Connect_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IP_textBox = new System.Windows.Forms.TextBox();
            this.Port_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Connect_Btn
            // 
            this.Connect_Btn.Location = new System.Drawing.Point(199, 37);
            this.Connect_Btn.Name = "Connect_Btn";
            this.Connect_Btn.Size = new System.Drawing.Size(75, 23);
            this.Connect_Btn.TabIndex = 0;
            this.Connect_Btn.Text = "연결 하기";
            this.Connect_Btn.UseVisualStyleBackColor = true;
            this.Connect_Btn.Click += new System.EventHandler(this.Connect_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // IP_textBox
            // 
            this.IP_textBox.Location = new System.Drawing.Point(12, 38);
            this.IP_textBox.Name = "IP_textBox";
            this.IP_textBox.Size = new System.Drawing.Size(129, 21);
            this.IP_textBox.TabIndex = 3;
            this.IP_textBox.Text = "255.255.255.255";
            this.IP_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Port_textBox
            // 
            this.Port_textBox.Location = new System.Drawing.Point(147, 38);
            this.Port_textBox.Name = "Port_textBox";
            this.Port_textBox.Size = new System.Drawing.Size(44, 21);
            this.Port_textBox.TabIndex = 4;
            this.Port_textBox.Text = "10000";
            this.Port_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClientSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 71);
            this.Controls.Add(this.Port_textBox);
            this.Controls.Add(this.IP_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connect_Btn);
            this.Name = "ClientSettingForm";
            this.Text = "ClientSettingForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IP_textBox;
        private System.Windows.Forms.TextBox Port_textBox;
    }
}