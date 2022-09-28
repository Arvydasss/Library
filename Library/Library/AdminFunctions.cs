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
    public partial class AdminFunctions : Form
    {
        List<Book> books = new();
        public AdminFunctions()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            title2Text.Text = "";
            isbn2Text.Text = "";
            title2Label.Visible = true;
            isbn2Label.Visible=true;
            title2Text.Visible=true;
            isbn2Text.Visible=true;
            rtrnBtn.Visible = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            titleText.Text = "";
            authorText.Text = "";
            publisherText.Text = "";
            yearText.Text = "";
            monthText.Text = "";
            dayText.Text = "";
            isbnText.Text = "";
            genreText.Text = "";
            titleLabel.Visible = true;
            authorLabel.Visible = true;
            publisherLabel.Visible = true;
            publisherText.Visible = true;
            yearLabel.Visible = true;
            monthLabel.Visible = true;
            dayLabel.Visible = true;
            isbnLabel.Visible = true;
            titleText.Visible = true;
            authorText.Visible = true;
            yearText.Visible = true;
            monthText.Visible = true;
            dayText.Visible = true;
            isbnText.Visible = true;
            genreLabel.Visible = true;
            genreText.Visible = true;
            add2Btn.Visible = true;
        }

        private void add2Btn_Click(object sender, EventArgs e)
        {
            string title = titleText.Text;
            string author = authorText.Text;
            string publisher = publisherText.Text;
            string years = yearText.Text;
            int year = Int32.Parse(years);
            string months = monthText.Text;
            int month = Int32.Parse(months);
            string days = dayText.Text;
            int day = Int32.Parse(days);
            var date = new DateTime(year, month, day).ToString("dd/MM/yyyy");
            string isbn = isbnText.Text;
            string genre = genreText.Text;

            Book newBook = new Book()
            {
                Title = title,
                Author = author,
                Publisher = publisher,
                Date = date,
                Genre = genre,
                ISBN = isbn,
                Available = true,
                Reserved = false
            };

            try
            {
                books.Add(newBook);
                var meetJson = JsonConvert.SerializeObject(books, Formatting.Indented);
                File.WriteAllText(@"books.json", meetJson);
                sucLabel.Visible = true;
            }
            catch (Exception)
            {
                errorLabel.Visible = true;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login form = new Login();
            form.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }

        private void rtrnBtn_Click(object sender, EventArgs e)
        {
            String title = title2Text.Text;
            String isbn = isbn2Text.Text;
            int index = 0;
            foreach (var book in books)
            {
                try
                {
                    if (book.Title == title && book.ISBN == isbn && book.Available == false)
                    {
                        index++;
                        book.Available = true;
                        book.Reserved = false;
                        var booki = Newtonsoft.Json.JsonConvert.SerializeObject(books, (Newtonsoft.Json.Formatting)Formatting.Indented);
                        File.WriteAllText(@"books.json", booki);
                        error2Label.Visible = false;
                        suc2Label.Visible = true;
                    }
                }
                catch (Exception)
                {
                    errorLabel.Visible = true;
                }
            }
            if (index == 0)
            {
                error2Label.Visible = true;
                title2Text.Text = "";
                isbn2Text.Text = "";
            }
        }

        private void isbnText_TextChanged(object sender, EventArgs e) { }
    }
}
