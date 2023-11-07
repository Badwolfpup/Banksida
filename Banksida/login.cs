using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banksida
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string user = "";
            string username = "";
            string password = "";
            bool isUsername = true;
            string filgenväg = @"C:\\Bankapp\accountHolderList.txt"; 
            if (!File.Exists(filgenväg))
            {
                File.Create(filgenväg).Close();
            }


            using (StreamReader läsfil = new StreamReader(filgenväg))
            {
                user = läsfil.ReadLine();
            }

            try
            {
                foreach (char c in user)
                {
                    if (c == ',')
                    {
                        isUsername = !isUsername;
                        continue;
                    }
                    if (isUsername) username += c.ToString();
                    else password += c.ToString();
                }
            } catch { }

            if (username == usernameTextbox.Text && password == passwordTextbox.Text)
            {
                this.Close();
            } else
            {
                MessageBox.Show("Username or password is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
