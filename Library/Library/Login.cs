using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace Library
{
    public partial class Login : Form
    {
        List<User> users = new();
        bool reader = false;
        public Login()
        {
            InitializeComponent();
        }


        private static bool CheckReader(string name, string pass, List<User> users, bool reader)
        {
            foreach (var user in users)
            {
                try
                {
                    if (user.Nickname == name && user.Password == pass && user.IsAdmin == false)
                    {
                        Console.WriteLine("\nWELCOME!");
                        reader = true;
                    }
                }
                catch (System.InvalidOperationException)
                {
                    Console.WriteLine("There is no that user!");
                }
            }
            return reader;
        }

        private static bool CheckAdmin(string name, string pass, List<User> users, bool reader)
        {
            foreach (var user in users)
            {
                try
                {
                    if (user.Nickname == name && user.Password == pass && user.IsAdmin == true)
                    {
                        Console.WriteLine("\nWELCOME!");
                        reader = true;
                    }
                }
                catch (System.InvalidOperationException)
                {
                    Console.WriteLine("There is no that user!");
                }
            }
            return reader;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"users.json"))
            {
                using (StreamWriter r2 = File.AppendText(@"users.json")) ;
            }
            else
            {
                using (StreamReader r2 = new StreamReader(@"users.json"))
                {
                    string json2 = r2.ReadToEnd();
                    users = JsonConvert.DeserializeObject<List<User>>(json2);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String pass = txtPass.Text;

            if (CheckReader(name, pass, users, reader) == true)
            {
                this.Close();
                ReaderFunctions form2 = new ReaderFunctions();
                form2.Show();
            }
            else
            {
                errorLabel.Visible = true;
                txtName.Text = "";
                txtPass.Text = "";
            }
            if (CheckAdmin(name, pass, users, reader) == true)
            {
                this.Close();
                AdminFunctions form = new AdminFunctions();
                form.Show();
            }
            else
            {
                errorLabel.Visible = true;
                txtName.Text = "";
                txtPass.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }
    }
}