using Models.Interfaces;

namespace Models
{
    public class Book : IGenericItem<Section>, IVisitee
    {
        public string Title { get; set; }
        public List<Section> Items { get; }
        public List<Author> Authors { get; set; }

        public Book(string title)
        {
            Title = title;
            Items = new List<Section>();
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

        public void Accept(IVisitor visitor)
        {
            visitor.VisitBook(this);
            Items.ForEach(item =>
            {
                if(item is IVisitee visitee)
                {
                    visitee.Accept(visitor);
                }
            });
        }
    }
}
