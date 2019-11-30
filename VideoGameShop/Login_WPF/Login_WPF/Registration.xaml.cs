using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Login_WPF
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            textBlockUsername.Text = "";
            textBlockPassword.Text = "";
            textBlockConfpaswd.Text = "";
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {

            string Username = textBoxUN.Text;
            string Password = textBoxPwd.Password;
            if (textBoxPwd.Password.Length == 0)
            {
                textBoxPwd.Focus();
            }
            else if (textBoxConfpwd.Password.Length == 0)
            {
                textBoxConfpwd.Focus();
            }
            else if (textBoxPwd.Password != textBoxConfpwd.Password)
            {
                textBoxConfpwd.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=TESTPURU;Initial Catalog=Data;User ID=sa;Password=wintellect");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Registration (Username,Password) values('" + Username + "','" + Password + "')", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                Reset();
            }


        }
    }
}

