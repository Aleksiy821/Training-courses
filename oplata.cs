using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics;

namespace Kursovoy_project
{
    public partial class oplata : Form
    {
        public oplata()
        {
            InitializeComponent();
            Imya.Text = "Введите Имя";
            family.Text = "Введите Фамилию";
            surname.Text = "Введите Отчество";
            ID.Text = "Введите ID";
            payment_number.Text = "Введите сумму пополнения";
            date_of_payment.Text = "Введите дату начала";
            expiration_date.Text = "Введите дату окончания";
            Imya.ForeColor = Color.Gray;
            family.ForeColor = Color.Gray;
            surname.ForeColor = Color.Gray;
            ID.ForeColor = Color.Gray;
            payment_number.ForeColor = Color.Gray;
            date_of_payment.ForeColor = Color.Gray;
            expiration_date.ForeColor = Color.Gray;
        }

        private void ID_MouseEnter(object sender, EventArgs e)
        {

            if (ID.Text == "Введите ID")
            {
                ID.Text = "";
                ID.ForeColor = Color.Black;
            }

        }

        private void ID_MouseLeave(object sender, EventArgs e)
        {
            
            if (ID.Text == "")
            {
                 ID.Text = "Введите ID";
                 ID.ForeColor = Color.Gray;
            }
            
        }

        private void Imya_MouseEnter(object sender, EventArgs e)
        {
            if (Imya.Text == "Введите Имя")
            {
                Imya.Text = "";
                Imya.ForeColor = Color.Black;
            }
        }

        private void Imya_MouseLeave(object sender, EventArgs e)
        {
            if (Imya.Text == "")
            {
                Imya.Text = "Введите Имя";
                Imya.ForeColor = Color.Gray;
            }
        }

        private void family_MouseEnter(object sender, EventArgs e)
        {
            if (family.Text == "Введите Фамилию")
            {
                family.Text = "";
                family.ForeColor = Color.Black;
            }
        }

        private void family_MouseLeave(object sender, EventArgs e)
        {
            if (family.Text == "")
            {
                family.Text = "Введите Фамилию";
                family.ForeColor = Color.Gray;
            }
        }

        private void surname_MouseEnter(object sender, EventArgs e)
        {
            if (surname.Text == "Введите Отчество")
            {
                surname.Text = "";
                surname.ForeColor = Color.Black;

            }
        }

        private void surname_MouseLeave(object sender, EventArgs e)
        {
            if (surname.Text == "")
            {
                surname.Text = "Введите Отчество";
                surname.ForeColor = Color.Gray;
            }
        }

        private void payment_number_MouseEnter(object sender, EventArgs e)
        {
            if (payment_number.Text == "Введите сумму пополнения")
            {
                payment_number.Text = "";
                payment_number.ForeColor = Color.Black;
            }
        }

        private void payment_number_MouseLeave(object sender, EventArgs e)
        {
            if (payment_number.Text == "")
            {
                payment_number.Text = "Введите сумму пополнения";
                payment_number.ForeColor = Color.Gray;
            }
        }

        private void date_of_payment_MouseEnter(object sender, EventArgs e)
        {
            if (date_of_payment.Text == "Введите дату начала")
            {
                date_of_payment.Text = "";
                date_of_payment.ForeColor = Color.Black;
            }
        }

        private void date_of_payment_MouseLeave(object sender, EventArgs e)
        {
            if (date_of_payment.Text == "")
            {
                date_of_payment.Text = "Введите дату начала";
                date_of_payment.ForeColor = Color.Gray;
            }
        }

        private void expiration_date_MouseEnter(object sender, EventArgs e)
        {
            if (expiration_date.Text == "Введите дату окончания")
            {
                expiration_date.Text = "";
                expiration_date.ForeColor = Color.Black;
            }
        }

        private void expiration_date_MouseLeave(object sender, EventArgs e)
        {
            if (expiration_date.Text == "")
            {
                expiration_date.Text = "Введите дату окончания";
                expiration_date.ForeColor = Color.Gray;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            if (payment_number.Text == "Введите сумму пополнения")
            {
                MessageBox.Show("Введите сумму пополнения!");
                return;
            }

            if (date_of_payment.Text == "Введите дату начала")
            {
                MessageBox.Show("Введите дату начала!");
                return;
            }

            if (expiration_date.Text == "Введите дату окончания")
            {
                MessageBox.Show("Введите дату окончания!");
                return;
            }

            if (ID.Text == "Введите ID")
            {
                MessageBox.Show("Введите ID!");
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `oplata`(`id_accaunt`, `Imya`, `family`, `surname`, `payment_number`, `date_of_payment`, `expiration_date`) VALUES (@id_accaunt, @Imya, @family, @surname, @payment_number, @date_of_payment, @expiration_date);", db.getConnection());
            command.Parameters.Add("@Imya", MySqlDbType.VarChar).Value = Imya.Text;
            command.Parameters.Add("@family", MySqlDbType.VarChar).Value = family.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname.Text;
            command.Parameters.Add("@payment_number", MySqlDbType.VarChar).Value = payment_number.Text;
            command.Parameters.Add("@date_of_payment", MySqlDbType.VarChar).Value = date_of_payment.Text;
            command.Parameters.Add("@expiration_date", MySqlDbType.VarChar).Value = expiration_date.Text;
            command.Parameters.Add("@id_accaunt", MySqlDbType.Int32).Value = ID.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)

                MessageBox.Show("Пополнение прошло успешно");

            else

                MessageBox.Show("Пополнение прошло не успешно");

            db.ClosedConnection();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm newForm = new  MainForm();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Word.Document doc = null;
            try
            {
              
                Word.Application app = new Word.Application();
                
                string source = @"D:\KIYAP\Курсовой проект ''Обучающие курсы'' Радомский Алексей Дмитриевич\Kursovoy project\Kursovoy project\bin\Debug\Я_пытался_побороть_эту_систему.docx";
               
                doc = app.Documents.Open(source);
                doc.Activate();

                Word.Bookmarks wBookmarks = doc.Bookmarks;
                Word.Range wRange;
                int i = 0;
                string[] data = new string[1] { bodyLabel.Text };
                foreach (Word.Bookmark mark in wBookmarks)
                {

                    wRange = mark.Range;
                    wRange.Text = data[i];
                    i++;
                }

                doc.Close();
                Process.Start(source);
                doc = null;
            }
            catch (Exception ex)
            {
               
                doc.Close();
                doc = null;
                Console.WriteLine("Во время выполнения произошла ошибка!");
                Console.ReadLine();
            }
        }    
    }
}
