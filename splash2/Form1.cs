using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace splash2
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CeateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int RightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse

            );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CeateRoundRectRgn(0, 0, Width, Height, 25, 25));
            ProgressBar1.Value = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Value += 1;
            ProgressBar1.Text = ProgressBar1.Value.ToString() + "%";

            if (ProgressBar1.Value==100) {
                timer1.Enabled = false;
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
        }
    }
}
