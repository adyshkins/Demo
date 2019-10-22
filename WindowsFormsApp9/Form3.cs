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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
         }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection(@"Data Source=HOME-ПК\SQLEXPRESS;Initial Catalog=UserBase;Integrated Security=True");
            SqlConnection.Open();


            SqlCommand SqlCommand = new SqlCommand("DELETE FROM users WHERE login = '"+Class1.Log+"';", SqlConnection);
            SqlCommand.ExecuteNonQuery();
            MessageBox.Show("Пользователь удален");
            new Form1().Show();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Text = Class1.Log;
        }
    }
}
