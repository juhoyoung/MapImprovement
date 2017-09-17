namespace MapImprovement
{
    partial class HotKeyForm
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
            this.KeyHide_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.KeyReset_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KeyDrawing_comboBox = new System.Windows.Forms.ComboBox();
            this.Submit_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "숨기기 / 보이기";
            // 
            // KeyHide_comboBox
            // 
            this.KeyHide_comboBox.FormattingEnabled = true;
            this.KeyHide_comboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "Space"});
            this.KeyHide_comboBox.Location = new System.Drawing.Point(165, 21);
            this.KeyHide_comboBox.Name = "KeyHide_comboBox";
            this.KeyHide_comboBox.Size = new System.Drawing.Size(69, 20);
            this.KeyHide_comboBox.TabIndex = 1;
            this.KeyHide_comboBox.Text = "Q";
            this.KeyHide_comboBox.SelectedIndexChanged += new System.EventHandler(this.KeyHide_comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = ": Ctrl + ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.KeyReset_comboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.KeyDrawing_comboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.KeyHide_comboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 151);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "화면 초기화";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = ": Ctrl + ";
            // 
            // KeyReset_comboBox
            // 
            this.KeyReset_comboBox.FormattingEnabled = true;
            this.KeyReset_comboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "Space"});
            this.KeyReset_comboBox.Location = new System.Drawing.Point(165, 111);
            this.KeyReset_comboBox.Name = "KeyReset_comboBox";
            this.KeyReset_comboBox.Size = new System.Drawing.Size(69, 20);
            this.KeyReset_comboBox.TabIndex = 7;
            this.KeyReset_comboBox.Text = "Space";
            this.KeyReset_comboBox.SelectedIndexChanged += new System.EventHandler(this.KeyReset_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "그리기 On/Off";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = ": Ctrl + ";
            // 
            // KeyDrawing_comboBox
            // 
            this.KeyDrawing_comboBox.FormattingEnabled = true;
            this.KeyDrawing_comboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "Space"});
            this.KeyDrawing_comboBox.Location = new System.Drawing.Point(165, 66);
            this.KeyDrawing_comboBox.Name = "KeyDrawing_comboBox";
            this.KeyDrawing_comboBox.Size = new System.Drawing.Size(69, 20);
            this.KeyDrawing_comboBox.TabIndex = 4;
            this.KeyDrawing_comboBox.Text = "W";
            this.KeyDrawing_comboBox.SelectedIndexChanged += new System.EventHandler(this.KeyDrawing_comboBox_SelectedIndexChanged);
            // 
            // Submit_button
            // 
            this.Submit_button.Location = new System.Drawing.Point(105, 178);
            this.Submit_button.Name = "Submit_button";
            this.Submit_button.Size = new System.Drawing.Size(75, 23);
            this.Submit_button.TabIndex = 4;
            this.Submit_button.Text = "확인";
            this.Submit_button.UseVisualStyleBackColor = true;
            this.Submit_button.Click += new System.EventHandler(this.Submit_button_Click);
            // 
            // HotKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 216);
            this.Controls.Add(this.Submit_button);
            this.Controls.Add(this.groupBox1);
            this.Name = "HotKeyForm";
            this.Text = "단축키";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.HotKeyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox KeyHide_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox KeyDrawing_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox KeyReset_comboBox;
        private System.Windows.Forms.Button Submit_button;
    }
}