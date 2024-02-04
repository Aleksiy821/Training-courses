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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Kursovoy_project
{
    public partial class accaunt : Form
    {
        public accaunt()
        {
            InitializeComponent();

             Imya.Text = "Введите Имя";
            family.Text = "Введите Фамилию";
           Surname.Text = "Введите Отчество";
            Data_rod.Text = "Введите даду рождения 0000-00-00";
            Email.Text = "Введите электронную почту";
            Login.Text = "Введите логин";
            parol.Text = "Введите пароль";
            Imya.ForeColor = Color.Gray;
            family.ForeColor = Color.Gray;
            Surname.ForeColor = Color.Gray;
            Data_rod.ForeColor = Color.Gray;
            Email.ForeColor = Color.Gray;
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

        Point LastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X - LastPoint.X;
                this.Top = e.Y - LastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void Imya_Enter(object sender, EventArgs e)
        {
            if (Imya.Text == "Введите Имя") 
            {
                Imya.Text = "";
                Imya.ForeColor = Color.Black;
            }
        }

        private void Imya_Leave(object sender, EventArgs e)
        {
            if (Imya.Text == "") 
            {
                Imya.Text = "Введите Имя";
                Imya.ForeColor = Color.Gray;
            }
        }

        private void family_Enter(object sender, EventArgs e)
        {
            if (family.Text == "Введите Фамилию") 
            {
                family.Text = "";
                family.ForeColor = Color.Black;
            }
        }

        private void family_Leave(object sender, EventArgs e)
        {
            if (family.Text == "") 
            {
                family.Text = "Введите Фамилию";
                family.ForeColor = Color.Gray;
            }
        }

        private void Surname_Enter(object sender, EventArgs e)
        {
            if (Surname.Text == "Введите Отчество") 
            {
                Surname.Text = "";
                Surname.ForeColor = Color.Black;

            }
        }

        private void Surname_Leave(object sender, EventArgs e)
        {
            if (Surname.Text == "") 
            {
                Surname.Text = "Введите Отчество";
                Surname.ForeColor = Color.Gray;
            }
        }

        private void Data_rod_Enter(object sender, EventArgs e)
        {
            if (Data_rod.Text == "Введите даду рождения 0000-00-00") 
            {
                Data_rod.Text = "";
                Data_rod.ForeColor = Color.Black;
            }
        }

        private void Data_rod_Leave(object sender, EventArgs e)
        {
            if (Data_rod.Text == "") 
            {
                Data_rod.Text = "Введите даду рождения 0000-00-00";
                Data_rod.ForeColor = Color.Gray;
            }
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (Email.Text == "Введите электронную почту") 
            {
                Email.Text = "";
                Email.ForeColor = Color.Black;
            }
        }


        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "") 
            {
                Email.Text = "Введите электронную почту";
                Email.ForeColor = Color.Gray;
            }
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://mtec.by/ru/");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.epam.com/"); 
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://rs.school/");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.park.by/en/");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.it-academy.by/"); 
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://openai.com/");
        }

        private void Sambit_Click(object sender, EventArgs e)
        {

            if(Imya.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя!");
                return;
            }

            if (family.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию!");
                return;
            }

            if (Surname.Text == "Введите Отчество")
            {
                MessageBox.Show("Введите Отчество!");
                return;
            }

            if (Data_rod.Text == "Введите введите дату рождения")
            {
                MessageBox.Show("Введите введите дату рождения!");
                return;
            }

            if (Email.Text == "Введите электронную почту")
            {
                MessageBox.Show("Введите электронную почту!");
                return;
            }

            if (Login.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин!");
                return;
            }

            if (parol.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль!");
                return;
            }

            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `accaunt` (`Imya`, `family`, `surname`, `data_rod`, `email`, `login`, `parol`) VALUES (@Imya, @family, @surname, @data_rod, @email, @login, @parol);", db.getConnection());
            command.Parameters.Add("@Imya", MySqlDbType.VarChar).Value = Imya.Text;
            command.Parameters.Add("@family", MySqlDbType.VarChar).Value = family.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = Surname.Text;
            command.Parameters.Add("@data_rod", MySqlDbType.VarChar).Value = Data_rod.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Login.Text;
            command.Parameters.Add("@parol", MySqlDbType.VarChar).Value = parol.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)

                MessageBox.Show("Аккаунт был создан");

            else

                MessageBox.Show("Аккаутн не был создан");

            db.ClosedConnection();
        }

        public Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `accaunt` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Login.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже есть, введите другой");
                return true;
            }
             else
                return false;
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            authorization newForm = new authorization();
            newForm.Show();
        }
    }
}

