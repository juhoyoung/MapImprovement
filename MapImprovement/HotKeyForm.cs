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
    public partial class HotKeyForm : Form
    {
        public HotKeyForm()
        {
            InitializeComponent();
            KeyHide_comboBox.SelectedItem = OptionController.instance.getHotKeyHide();
            KeyDrawing_comboBox.SelectedItem = OptionController.instance.getHotKeyDrawing();
            KeyReset_comboBox.SelectedItem = OptionController.instance.getHotKeyReset();
        }

        private void HotKeyForm_Load(object sender, EventArgs e)
        {

        }

        private void Submit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KeyHide_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(KeyHide_comboBox.SelectedItem.ToString());
            OptionController.instance.setHotKeyHide(KeyHide_comboBox.SelectedItem.ToString());
        }

        private void KeyDrawing_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(KeyDrawing_comboBox.SelectedItem.ToString());
            OptionController.instance.setHotKeyDrawing(KeyDrawing_comboBox.SelectedItem.ToString());
        }

        private void KeyReset_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(KeyReset_comboBox.SelectedItem.ToString());
            OptionController.instance.setHotKeyReset(KeyReset_comboBox.SelectedItem.ToString());
        }
    }
}
