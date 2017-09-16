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
    public partial class ViewForm : Form
    {
        bool isVisible = true;

        public ViewForm()
        {
            InitializeComponent();
            
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            
            
            KeyProcessing.kProcessing.getViewForm(this);
            this.ShowInTaskbar = false;
            //this.Size = new Size(System.Windows.Forms.SystemInformation.VirtualScreen.Width, System.Windows.Forms.SystemInformation.VirtualScreen.Height);
            this.Location = new Point(0, 0);
            //Console.WriteLine(this.Size.Height + " " + this.Size.Width);
            //Console.WriteLine(this.Location);
        }



        public void SetVisibleForm() // 폼 visible 설정
        {
            Console.WriteLine("viewform setvisibleForm 호출");
            if (isVisible == true)
            {
                this.Hide();
                isVisible = false;
                
            }
            else
            {
                this.Show();
                isVisible = true;
            }
        }

        
    }
}
