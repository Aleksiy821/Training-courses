using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoy_project
{
    public partial class Kurs : Form
    {
        public Kurs()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm newForm = new MainForm();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            java newForm = new java();
            newForm.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            C_sharp newForm = new C_sharp();
            newForm.Show();
        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CSS newForm = new CSS();
            newForm.Show();
        }
    }
}
