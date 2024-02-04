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
    public partial class admins : Form
    {
        public admins()
        {
            InitializeComponent();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            prepod newForm = new prepod();
            newForm.Show();
        }
    }
}
