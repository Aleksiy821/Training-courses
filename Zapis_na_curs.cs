using Microsoft.Office.Interop.Word;
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
    public partial class Zapis_na_curs : Form
    {
        public Zapis_na_curs()
        {
            InitializeComponent();

            name_kurs.Text = "Введите имя курса";
            course_date.Text = "Введите дату курса";
            id_accaunt.Text = "Введите ID аккаунта";
            category.Text = "Введите категорию";
            price.Text = "Введите сумму";
            name_kurs.ForeColor = Color.Gray;
            course_date.ForeColor = Color.Gray;
            id_accaunt.ForeColor = Color.Gray;
            category.ForeColor = Color.Gray;
            price.ForeColor = Color.Gray;
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

        private void button3_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `kurs` (`name_kurs`, `course_date`, `id_accaunt`, `category`, `price`) VALUES (@name_kurs, @course_date, @id_accaunt, @category, @price);", db.getConnection());
            command.Parameters.Add("@name_kurs", MySqlDbType.VarChar).Value = name_kurs.Text;
            command.Parameters.Add("@course_date", MySqlDbType.VarChar).Value = course_date.Text;
            command.Parameters.Add("@id_accaunt", MySqlDbType.Int32).Value = id_accaunt.Text;
            command.Parameters.Add("@category", MySqlDbType.VarChar).Value = category.Text;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = price.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)

                MessageBox.Show("Вы были записаны на курс");

            else

                MessageBox.Show("Вы не были записаны на курс");

            db.ClosedConnection();
        }

        private void name_kurs_Enter(object sender, EventArgs e)
        {
            if (name_kurs.Text == "Введите имя курса")
            {
                name_kurs.Text = "";
                name_kurs.ForeColor = Color.Black;
            }
        }

        private void name_kurs_Leave(object sender, EventArgs e)
        {
            if (name_kurs.Text == "")
            {
                name_kurs.Text = "Введите имя курса";
                name_kurs.ForeColor = Color.Gray;
            }
        }

        private void course_date_Enter(object sender, EventArgs e)
        {
            if (course_date.Text == "Введите дату курса")
            {
                course_date.Text = "";
                course_date.ForeColor = Color.Black;
            }
        }

        private void course_date_Leave(object sender, EventArgs e)
        {
            if (course_date.Text == "")
            {
                course_date.Text = "Введите дату курса";
                course_date.ForeColor = Color.Gray;
            }
        }

        private void id_accaunt_Enter(object sender, EventArgs e)
        {
            if (id_accaunt.Text == "Введите ID аккаунта")
            {
                id_accaunt.Text = "";
                id_accaunt.ForeColor = Color.Black;
            }
        }

        private void id_accaunt_Leave(object sender, EventArgs e)
        {
            if (id_accaunt.Text == "")
            {
                id_accaunt.Text = "Введите ID аккаунта";
                id_accaunt.ForeColor = Color.Gray;
            }
        }

        private void category_Enter(object sender, EventArgs e)
        {
            if (category.Text == "Введите категорию")
            {
                category.Text = "";
                category.ForeColor = Color.Black;
            }
        }

        private void category_Leave(object sender, EventArgs e)
        {
            if (category.Text == "")
            {
                category.Text = "Введите категорию";
                category.ForeColor = Color.Gray;
            }
        }

        private void price_Enter(object sender, EventArgs e)
        {
            if (price.Text == "Введите сумму")
            {
                price.Text = "";
                price.ForeColor = Color.Black;
            }
        }

        private void price_Leave(object sender, EventArgs e)
        {
            if (price.Text == "")
            {
                price.Text = "Введите сумму";
                price.ForeColor = Color.Gray;
            }
        }
    }
}
