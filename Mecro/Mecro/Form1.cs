using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Mecro
{
    public partial class Mecro : Form
    {
        public Mecro()
        {
            InitializeComponent();
        }

        private void Mecro_Load(object sender, EventArgs e)
        {

        }

        private void stop_Click(object sender, EventArgs e)



        {
            this.Close();
        }

        private void start_Click(object sender, EventArgs e)
        {
            MessageBox.Show("매크로가 시작됩니다.");
            while (true)
            {
                Thread.Sleep(Convert.ToInt32(time.Text));
                SendKeys.Send(content.Text + "{ENTER}");
            }
        }
    }
}
