namespace Library
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public string Publisher { get; set; }
        public string Date { get; set; }
        public string Genre { get; set; }

        public string ISBN { get; set; }
        public bool Available { get; set; }

        public bool Reserved { get; set; }
    }
}
