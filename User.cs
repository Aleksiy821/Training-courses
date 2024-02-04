using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using Kursovoy_project.Properties;

namespace Kursovoy_project
{
    public partial class User : Form
    {
       
        private string idInfo;
        public User(int idUser)
        {
            InitializeComponent();
            idInfo = idUser.ToString();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm newForm = new MainForm();
            newForm.idUser = int.Parse(idInfo);
            newForm.isAdmin = idInfo == "1" ? "Admin" : "";
            newForm.Show();
        }

       

        private void User_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            string queryInfo = $"SELECT accaunt.*, oplata.payment_number from accaunt left join oplata on oplata.id_accaunt = {idInfo} and accaunt.id_accaunt = {idInfo} where accaunt.id_accaunt = {idInfo}";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.OpenConnection();

            using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDL.Text = reader["id_accaunt"].ToString();
                    LLogin.Text = reader["login"].ToString();
                    NameL.Text = reader["Imya"].ToString();
                    familyL.Text = reader["family"].ToString();
                    data_rodLabel.Text = reader["data_rod"].ToString();
                    LBalans.Text = reader["payment_number"].ToString();
                    Lrole.Text = reader["role"].ToString();

                    string ifImage = "";
                    if (ifImage != reader["image"].ToString())
                    {
                        System.Drawing.Image avatar = (Bitmap)((new ImageConverter()).ConvertFrom(reader["image"]));
                        avatarPicture.Image = avatar;
                        avatarPicture.Invalidate();
                    }
                }
                reader.Close();
            }



            db.ClosedConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            setting newForm = new setting(int.Parse(idInfo));
            newForm.Show();
        }

        private void avatarPicture_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"UPDATE accaunt SET image = @image WHERE id_accaunt = '{idInfo}'", db.getConnection());

            db.OpenConnection();

            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    command.Parameters.AddWithValue("@image", System.IO.File.ReadAllBytes($"{open_dialog.FileName}"));
                    command.ExecuteNonQuery();

                    Bitmap image = new Bitmap(open_dialog.FileName);
                    avatarPicture.Image = image;
                    avatarPicture.Invalidate();
                }
                catch
                {
                    MessageBox.Show("Выбранное вами изображение больше 16 МБ, выберите другое", "Ошибка изображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            db.ClosedConnection();
        }
    }
}
