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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursovoy_project
{
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
            Login.Text = "Введите логин";
            parol.Text = "Введите пароль";
            Login.ForeColor = Color.Gray;
            parol.ForeColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            if (Login.Text == "Введите логин")
            {
                Login.Text = "";
                Login.ForeColor = Color.Black;
            }
        }


        private void Login_Leave(object sender, EventArgs e)
        {
            if (Login.Text == "")
            {
                Login.Text = "Введите логин";
                Login.ForeColor = Color.Gray;
            }
        }

        private void parol_Enter(object sender, EventArgs e)
        {
            if (parol.Text == "Введите пароль")
            {
                parol.Text = "";
                parol.ForeColor = Color.Black;
            }
        }

        private void parol_Leave(object sender, EventArgs e)
        {
            if (parol.Text == "")
            {
                parol.Text = "Введите пароль";
                parol.ForeColor = Color.Gray;

            }
        }

        private void InitializeMyControl()
        {
            parol.Text = "";
            parol.PasswordChar = '*';
            parol.MaxLength = 32;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string LoginUser = Login.Text;
            string parolUser = parol.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT id_accaunt FROM `accaunt` WHERE `login` = @uL AND `parol` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = parolUser;
            
            adapter.SelectCommand= command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                MainForm mainForm = new MainForm();
                string queryAccount = $"SELECT role FROM accaunt WHERE login = '{Login.Text}'";
                MySqlCommand mySqlCommand = new MySqlCommand(queryAccount, db.getConnection());

                db.OpenConnection();

                mainForm.isAdmin = mySqlCommand.ExecuteScalar().ToString();
                mainForm.isMentor= mySqlCommand.ExecuteScalar().ToString();

                using (MySqlDataReader readere = command.ExecuteReader())
                {
                    while (readere.Read())
                    {
                        mainForm.idUser = (int)readere[0];
                    }
                }
                Hide();
                mainForm.ShowDialog();

            }
            else
                MessageBox.Show("No");
            db.ClosedConnection();

        }

        Point LastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X - LastPoint.X;
                this.Top = e.Y - LastPoint.Y;
            }
        }
    }
}
