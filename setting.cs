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
    public partial class setting : Form
    {
        private int idUser;
        public setting(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("UPDATE accaunt SET login=@login, parol=@parol, Imya=@Imya, family=@family Where id_accaunt = @idA", db.getConnection());

            command.Parameters.AddWithValue("@login", UPLogin.Text);
            command.Parameters.AddWithValue("@parol", UPparol.Text);
            command.Parameters.AddWithValue("@Imya", UPImya.Text);
            command.Parameters.AddWithValue("@family", UPfamily.Text);
            command.Parameters.AddWithValue("@idA", idUser);

            db.OpenConnection();

            command.ExecuteNonQuery();

            db.ClosedConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm newForm = new MainForm();
            newForm.idUser= idUser;
            newForm.isAdmin = idUser == 1 ? "Admin" : "";
            newForm.Show();
        }
    }
}