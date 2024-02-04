using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Kursovoy_project
{
    public partial class prepod : Form
    {
        public prepod()
        {
            InitializeComponent();
            Imya.Text = "Введите Имя";
            family.Text = "Введите Фамилию";
            surname.Text = "Введите Отчество";
            job_title.Text = "Введите вид деятельности";
            IDacc.Text = "Введите ID аккаунта";
            Imya.ForeColor = Color.Gray;
            family.ForeColor = Color.Gray;
            surname.ForeColor = Color.Gray;
            job_title.ForeColor = Color.Gray;
            IDacc.ForeColor = Color.Gray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void surname_Enter(object sender, EventArgs e)
        {
            if (surname.Text == "Введите Отчество")
            {
                surname.Text = "";
                surname.ForeColor = Color.Black;

            }
        }

        private void surname_Leave(object sender, EventArgs e)
        {
            if (surname.Text == "")
            {
                surname.Text = "Введите Отчество";
                surname.ForeColor = Color.Gray;
            }
        }

        private void job_title_Enter(object sender, EventArgs e)
        {
            if (job_title.Text == "Введите вид деятельности")
            {
                job_title.Text = "";
                job_title.ForeColor = Color.Black;

            }
        }

        private void job_title_Leave(object sender, EventArgs e)
        {
            if (job_title.Text == "")
            {
                job_title.Text = "Введите вид деятельности";
                job_title.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idPrepod = 0;
            if (Imya.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя!");
                return;
            }

            if (family.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию!");
                return;
            }

            if (surname.Text == "Введите Отчество")
            {
                MessageBox.Show("Введите Отчество!");
                return;
            }

            if (job_title.Text == "Введите вид деятельности")
            {
                MessageBox.Show("Введите вид деятельности");
                return;
            }

            if (IDacc.Text == "Введите ID аккаунта")
            {
                MessageBox.Show("Введите ID аккаунта");
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `prepod` (`Imya`, `family`, `surname`, `job_title`, `id_accaunt`) VALUES (@Imya, @family, @surname, @job_title, @id_accaunt);", db.getConnection());
            command.Parameters.Add("@Imya", MySqlDbType.VarChar).Value = Imya.Text;
            command.Parameters.Add("@family", MySqlDbType.VarChar).Value = family.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname.Text;
            command.Parameters.Add("@job_title", MySqlDbType.VarChar).Value = job_title.Text;
            command.Parameters.Add("@id_accaunt", MySqlDbType.Int32).Value = IDacc.Text;
            MySqlCommand command2 = new MySqlCommand("SELECT id_prepod FROM prepod ORDER BY id_prepod DESC LIMIT 1;", db.getConnection());

            db.OpenConnection();
            MySqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                idPrepod = int.Parse(reader[0].ToString());
                MessageBox.Show(idPrepod.ToString());
            }
            reader.Close();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Преподователь был добавлен");
            else

                MessageBox.Show("Преподователь не был добавлен");

            db.ClosedConnection(); 
            MySqlCommand command3 = new MySqlCommand($"update accaunt set id_prepod= {idPrepod}", db.getConnection());


            db.OpenConnection();

            command3.ExecuteNonQuery();
            db.ClosedConnection();
        }

        private void IDacc_Enter(object sender, EventArgs e)
        {
            if (IDacc.Text == "Введите ID аккаунта")
            {
                IDacc.Text = "";
                IDacc.ForeColor = Color.Black;

            }
        }
        private void IDacc_Leave(object sender, EventArgs e)
        {
            if (IDacc.Text == "")
            {
                IDacc.Text = "Введите ID аккаунта";
                IDacc.ForeColor = Color.Gray;
            }
        }  
    }
}