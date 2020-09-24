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
using Microsoft.VisualBasic;

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
            try
            {
                for (int i = 0; i < Convert.ToInt32(count.Text); i++)
                {
                    Delay(Convert.ToInt32(time.Text));
                    SendKeys.Send(content.Text + "{ENTER}");
                }
                MessageBox.Show("매크로가 종료되었습니다.");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private static void Delay(int MS) 
        { 
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);
            while (AfterWards >= ThisMoment) 
            {
                Application.DoEvents(); 
                ThisMoment = DateTime.Now; 
            }
        }
    }
}
