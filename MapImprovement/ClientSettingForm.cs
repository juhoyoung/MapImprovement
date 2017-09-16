﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapImprovement
{
    public partial class ClientSettingForm : Form
    {
        public ClientSettingForm()
        {
            InitializeComponent();
        }

        private void Connect_Btn_Click(object sender, EventArgs e) // 아이피 주소와 포트번호 넘겨줌
        {
            OptionController.instance.setConnectIP(IP_textBox.Text);
            OptionController.instance.setConnectPort(int.Parse(Port_textBox.Text));


            this.Close();
        }
    }
}
