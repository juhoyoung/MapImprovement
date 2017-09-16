using System;
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
    public partial class ServerSettingForm : Form
    {
        public ServerSettingForm()
        {
            InitializeComponent();
        }

        private void Connect_Btn_Click(object sender, EventArgs e)
        {
            OptionController.instance.setServerPort(int.Parse(Port_textBox.Text));
            this.Close();
        }
    }
}
