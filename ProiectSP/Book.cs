namespace ProiectSP
{
    public class Book : IGenericItem<Chapter>
    {
        public string Title { get; set; }
        public List<Chapter> Items { get; }
        public List<Author> Authors { get; set; }

        public Book(string title)
        {
            Title = title;
            Items = new List<Chapter>();
            Authors = new List<Author>();
        }


        public int AddAuthor(Author author)
        {
            Authors.Add(author);
            return Authors.IndexOf(author);
        }

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
            Items.ForEach(item => item.Print());
        }
    }
}
