using static lab3.Form1;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }
        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }
        public class Ebook : Book
        {
            public string FileFormat { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author} - Format: {FileFormat}";
            }
        }
        public class TextBook : Book
        {
            public string Subject { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author} - Subject: {Subject}";
            }
        }
        public class AudioBook : Book
        {
            public double Duration { get; set; }
            public string Narrator { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author} - Duration: {Duration} hours - Narrator: {Narrator}";
            }
        }
        private void PolymorphicFunction(Book[] books)
        {
            foreach (Book book in books)
            {
                txtInfo.Items.Add(book.GetInfo());
            }
        }
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            var books = new Book[]
            {
                new Book { Title = "Lab 3", Author = "Zeur Baraquero" },
                new Magazine { Title = "Tech Weekly", Author = "John Doe", IssueNumber = 45 },
                new Ebook { Title = "Software Design", Author = "Engr. Jay Al Gallenero", FileFormat = "PDF" },
                new TextBook { Title = "Java Programming", Author = "Engr. Emmy Jill Funa", Subject = "Object-Oriented Programming" },
                new AudioBook { Title = "Prorunning Explained", Author = "BkayB", Duration = 3.5, Narrator = "Ethan" }
            };
            PolymorphicFunction(books);
        }
    }
}