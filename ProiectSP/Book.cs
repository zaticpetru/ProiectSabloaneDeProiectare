namespace ProiectSP
{
    public class Book
    {
        public string Title { get; set; }
        public List<Chapter> Chapters { get; set; }
        public List<Author> Authors { get; set; }

        public Book(string title)
        {
            Title = title;
            Chapters = new List<Chapter>();
            Authors = new List<Author>();
        }

        public int CreateChapter(string name)
        {
            var chapter = new Chapter(name);
            Chapters.Add(chapter);
            return Chapters.IndexOf(chapter);
        }

        public int AddAuthor(Author author)
        {
            Authors.Add(author);
            return Authors.IndexOf(author);
        }

        public Chapter GetChapter(int index) => Chapters[index];

        public void Print()
        {
            Console.WriteLine($"Titlu: {Title}\n");
            if (Authors.Count > 0)
            {
                Console.WriteLine(Authors.Count > 1 ? "Autori:" : "Autor:");
                Authors.ForEach(item => item.Print());
            }
            else
            {
                Console.WriteLine("Carte fara autor");
            }
            Chapters.ForEach(item => item.Print());
        }
    }
}
