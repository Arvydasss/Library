using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Library
{
    public partial class ReaderFunctions : Form
    {
        List<Book> books = new();
        public ReaderFunctions()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"books.json"))
            {
                using (StreamWriter r = File.AppendText(@"books.json")) ;
            }
            else
            {
                using (StreamReader r = new StreamReader(@"books.json"))
                {
                    string json = r.ReadToEnd();
                    books = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Book>>(json);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchBooks form3 = new SearchBooks();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            title2Box.Visible = false;
            isbn2Box.Visible = false;
            title2Label.Visible = false;
            isbn2Label.Visible = false;
            error2Label.Visible = false;
            val2Label.Visible = false;
            search2Btn.Visible = false;

            titleBox.Visible = true;
            isbnBox.Visible = true;
            titleLabel.Visible = true;
            isbnLabel.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void resNameBox_TextChanged(object sender, EventArgs e) { }

        private void label1_Click_1(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) 
        {
            string isbn = isbnBox.Text;
            int number;
            bool isNumber = int.TryParse(isbn, out number);
            if (isNumber || isbn == "")
            {
                search2Btn.Visible = true;
                val2Label.Visible = false;
            }
            else
            {
                val2Label.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            titleBox.Visible = false;
            isbnBox.Visible = false;
            titleLabel.Visible = false;
            isbnLabel.Visible = false;
            errorLabel.Visible = false;
            valLabel.Visible = false;
            searchBtn.Visible = false;

            title2Box.Visible = true;
            isbn2Box.Visible = true;
            title2Label.Visible = true;
            isbn2Label.Visible = true;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login form = new Login();
            form.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            String title = titleBox.Text;
            String isbn = isbnBox.Text;
            int index = 0;
            foreach (var book in books)
            {
                try
                {
                    if (book.Title == title && book.ISBN == isbn && book.Reserved == false && book.Available == true)
                    {
                        index++;
                        book.Reserved = true;
                        var booki = Newtonsoft.Json.JsonConvert.SerializeObject(books, (Newtonsoft.Json.Formatting)Formatting.Indented);
                        File.WriteAllText(@"books.json", booki);
                        errorLabel.Visible = false;
                        resLabel.Visible = true;
                        valLabel.Visible = false;
                    }
                }
                catch (Exception)
                {
                    errorLabel.Visible = true;
                }
            }
            if (index == 0)
            {
                valLabel.Visible = false;
                errorLabel.Visible = true;
                titleBox.Text = "";
                isbnBox.Text = "";
            }
        }

        private void search2Btn_Click(object sender, EventArgs e)
        {
            String title = title2Box.Text;
            String isbn = isbn2Box.Text;
            int index = 0;
            foreach (var book in books)
            {
                try
                {
                    if (book.Title == title && book.ISBN == isbn && book.Available == true && book.Reserved == false)
                    {
                        index++;
                        book.Available = false;
                        var booki = Newtonsoft.Json.JsonConvert.SerializeObject(books, (Newtonsoft.Json.Formatting)Formatting.Indented);
                        File.WriteAllText(@"books.json", booki);
                        error2Label.Visible = false;
                        borLabel.Visible = true;
                        val2Label.Visible = false;
                    }
                }
                catch (Exception)
                {
                    error2Label.Visible = true;
                }
            }
            if (index == 0)
            {
                val2Label.Visible = false;
                error2Label.Visible = true;
                title2Box.Text = "";
                isbn2Box.Text = "";
            }

        }

        private void isbnBox_TextChanged(object sender, EventArgs e)
        {
            string isbn = isbnBox.Text;
            int number;
            bool isNumber = int.TryParse(isbn, out number);
            if (isNumber || isbn == "")
            {
                searchBtn.Visible = true;
                valLabel.Visible = false;
            }
            else
            {
                valLabel.Visible = true;
            }
        }

        private void valLabel_Click(object sender, EventArgs e) { }
    }
}
