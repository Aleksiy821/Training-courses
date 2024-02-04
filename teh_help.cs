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
    public partial class teh_help : Form
    {
        public teh_help()
        {
            InitializeComponent();
            textBox1.Text = "Введите имя";
            textBox2.Text = "Введите электронную почту";
            textBox3.Text = "Введите описания проблемы";
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
            textBox3.ForeColor = Color.Gray;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox txtName = new TextBox();
            txtName.Location = new Point(10, 10);
            txtName.Size = new Size(200, 20);
            this.Controls.Add(txtName);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox txtEmail = new TextBox();
            txtEmail.Location = new Point(10, 40);
            txtEmail.Size = new Size(200, 20);
            this.Controls.Add(txtEmail);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmbCategory = new ComboBox();
            cmbCategory.Location = new Point(10, 70);
            cmbCategory.Size = new Size(200, 20);
            cmbCategory.Items.Add("Проблемы с программным обеспечением");
            cmbCategory.Items.Add("Проблемы с аппаратным обеспечением");
            cmbCategory.Items.Add("Другие проблемы");
            this.Controls.Add(cmbCategory);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox txtDescription = new TextBox();
            txtDescription.Location = new Point(10, 100);
            txtDescription.Size = new Size(200, 100);
            txtDescription.Multiline = true;
            this.Controls.Add(txtDescription);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ваш запрос принят в обработку.");
            this.Hide();
            MainForm newForm = new MainForm();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm newForm = new MainForm();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите имя")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Введите имя";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введите электронную почту")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Введите электронную почту";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Введите описания проблемы")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Введите описания проблемы";
                textBox3.ForeColor = Color.Gray;
            }
        }
    }
}
