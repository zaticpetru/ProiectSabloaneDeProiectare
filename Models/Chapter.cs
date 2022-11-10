namespace Models
{
    public class Chapter : IGenericItem<SubChapter>
    {
        public string Name { get; set; }
        public List<SubChapter> Items { get; }

        public Chapter(string name)
        {
            Name = name;
            Items = new List<SubChapter>();
        }

        public void Print()
        {
            Console.WriteLine($"Titlu capitol: {Name}\n");
            Items.ForEach(item => item.Print());
        }
    }
}