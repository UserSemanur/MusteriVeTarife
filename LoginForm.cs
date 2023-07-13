using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriVeTarife
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool ValidateUser(string username, string password)
        {
           

            if (username == "admin" && password == "password")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (ValidateUser(username, password))
            {
                MessageBox.Show("Login successful!");
                this.Hide();
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.ShowDialog();
                

            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

       
    }
    
}
