namespace ProiectSP
{
    public class SubChapter : IGenericItem<BookItem>
    {
        public string Name { get; set; }
        public List<BookItem> Items { get; }

        public SubChapter(string name)
        {
            Name = name;
            Items = new List<BookItem>();
        }
        public void Print()
        {
            Console.WriteLine($"Titlu subcapitol: {Name}\n");
            Items.ForEach(item => item.Print());
        }
    }
}