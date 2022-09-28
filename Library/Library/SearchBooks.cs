using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class SearchBooks : Form
    {
        List<Book> books = new();
        public SearchBooks()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            String search = titleText.Text;
            foreach (var book in books)
            {
                try
                {
                    if (book.Title == search)
                    {
                        var text = Newtonsoft.Json.JsonConvert.SerializeObject(book, Formatting.Indented);
                        resultBox.Text = text;
                    }
                }
                catch (Exception)
                {
                    resultBox.Text = "There is no that book";
                }
            }
            titleText.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            String search = authorText.Text;
            foreach (var book in books)
            {
                try
                {
                    if (book.Author == search)
                    {
                        var text = Newtonsoft.Json.JsonConvert.SerializeObject(book, Formatting.Indented);
                        resultBox.Text += text;
                    }
                }
                catch (Exception)
                {
                    resultBox.Text = "There is no that book";
                }
            }
            authorText.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            String search = publisherText.Text;
            foreach (var book in books)
            {
                try
                {
                    if (book.Publisher == search)
                    {
                        var text = Newtonsoft.Json.JsonConvert.SerializeObject(book, Formatting.Indented);
                        resultBox.Text += text;
                    }
                }
                catch (Exception)
                {
                    resultBox.Text = "There is no that book";
                }
            }
            publisherText.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            string years = yearText.Text;
            int year = Int32.Parse(years);
            string months = monthText.Text;
            int month = Int32.Parse(months);
            string days = dayText.Text;
            int day = Int32.Parse(days);
            var date = new DateTime(year, month, day).ToString("dd/MM/yyyy");

            foreach (var book in books)
            {
                try
                {
                    if (book.Date == date)
                    {
                        var text = Newtonsoft.Json.JsonConvert.SerializeObject(book, Formatting.Indented);
                        resultBox.Text += text;
                    }
                }
                catch (Exception)
                {
                    resultBox.Text = "There is no that book";
                }
            }
            yearText.Text = "";
            monthText.Text = "";
            dayText.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            String search = isbnText.Text;
            foreach (var book in books)
            {
                try
                {
                    if (book.ISBN == search)
                    {
                        var text = Newtonsoft.Json.JsonConvert.SerializeObject(book, Formatting.Indented);
                        resultBox.Text += text;
                    }
                }
                catch (Exception)
                {
                    resultBox.Text = "There is no that book";
                }
            }
            isbnText.Text = "";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            foreach (var book in books)
            {
                try
                {
                    if (book.Available == true && book.Reserved == false)
                    {
                        var text = Newtonsoft.Json.JsonConvert.SerializeObject(book, Formatting.Indented);
                        resultBox.Text += text;
                    }
                }
                catch (Exception)
                {
                    resultBox.Text = "There is no that book";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            foreach (var book in books)
            {
                try
                {
                    if (book.Available == false && book.Reserved == true)
                    {
                        var text = Newtonsoft.Json.JsonConvert.SerializeObject(book, Formatting.Indented);
                        resultBox.Text += text;
                    }
                }
                catch (Exception)
                {
                    resultBox.Text = "There is no that book";
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ReaderFunctions form = new ReaderFunctions();
            form.Show();
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {
            resultBox.Multiline = true;
            resultBox.ScrollBars = (RichTextBoxScrollBars)ScrollBars.Vertical;
        }

        private void genreBtn_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            string search = genreText.Text;
            foreach (var book in books)
            {
                try
                {
                    if (book.Genre == search)
                    {
                        var text = Newtonsoft.Json.JsonConvert.SerializeObject(book, Formatting.Indented);
                        resultBox.Text += text;
                    }
                }
                catch (Exception)
                {
                    resultBox.Text = "There is no that book";
                }
            }
            genreText.Text = "";

        }

        private void isbnText_TextChanged(object sender, EventArgs e)
        {
            string isbn = isbnText.Text;
            int number;
            bool isNumber = int.TryParse(isbn, out number);
            if (isNumber || isbn == "")
            {
                valLabel.Visible = false;
            }
            else
            {
                valLabel.Visible = true;
            }
        }

        private void yearText_TextChanged(object sender, EventArgs e)
        {
            string year = yearText.Text;
            int number;
            bool isNumber = int.TryParse(year, out number);
            if (isNumber || year == "")
            {
                valLabel.Visible = false;
            }
            else
            {
                valLabel.Visible = true;
            }
        }

        private void monthText_TextChanged(object sender, EventArgs e)
        {
            string month = monthText.Text;
            int number;
            bool isNumber = int.TryParse(month, out number);
            if (isNumber || month == "")
            {
                valLabel.Visible = false;
            }
            else
            {
                valLabel.Visible = true;
            }
        }

        private void dayText_TextChanged(object sender, EventArgs e)
        {
            string day = dayText.Text;
            int number;
            bool isNumber = int.TryParse(day, out number);
            if (isNumber || day == "")
            {
                valLabel.Visible = false;
            }
            else
            {
                valLabel.Visible = true;
            }
        }

        private void authorText_TextChanged(object sender, EventArgs e) { }
    }
}
