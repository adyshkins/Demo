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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection(@"Data Source=HOME-ПК\SQLEXPRESS;Initial Catalog=UserBase;Integrated Security=True");
            SqlConnection.Open();

           
            SqlCommand SqlCommand = new SqlCommand("Select * from users where login = '"+textBox1.Text+ "' and login ='" + textBox2.Text + "'",SqlConnection);
            SqlDataReader SqlDataReader = SqlCommand.ExecuteReader();
            Class1.Log = textBox1.Text;
            if (SqlDataReader.HasRows)
            {
                new Form3().Show();
                this.Hide();
            }
            else MessageBox.Show("Пользователь не найден");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
    }
}
