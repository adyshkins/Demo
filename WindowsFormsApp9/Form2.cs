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

namespace WindowsFormsApp9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection(@"Data Source=HOME-ПК\SQLEXPRESS;Initial Catalog=UserBase;Integrated Security=True");
            SqlConnection.Open();


            SqlCommand SqlCommand = new SqlCommand("INsert into users(login,Password,Email) Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "'", SqlConnection);
            SqlCommand.ExecuteNonQuery();

            new Form3().Show();
            this.Close();
        }
    }
}
