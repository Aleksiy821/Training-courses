using MySql.Data.MySqlClient;
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
    public partial class MainForm : Form
    {
        public string isAdmin;
        public string isMentor;
        public int idUser;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Zapis_na_curs newForm = new Zapis_na_curs();
            newForm.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Kurs newForm = new Kurs();
            newForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (isAdmin == "Admin")
                btn_adminForm.Visible = true;
            else
                btn_adminForm.Visible = false;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Material newForm = new Material();
            newForm.Show();
        }

        private void btn_adminForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            admins newForm = new admins();
            newForm.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            User newForm = new User(idUser);
            newForm.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            oplata newForm = new oplata();
            newForm.Show();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Spravochnik newForm = new Spravochnik();
            newForm.Show();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            teh_help newForm = new teh_help();
            newForm.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Zapis newForm = new Zapis();
            newForm.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            informals newForm = new informals();
            newForm.Show();
        }
    }
}
