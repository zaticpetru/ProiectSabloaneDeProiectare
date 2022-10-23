namespace ProiectSP
{
    public class Chapter : GenericItem<SubChapter>
    {
        public string Name { get; set; }
        public List<SubChapter> Items { get; }

        public Chapter(string name)
        {
            Name = name;
            Items = new List<SubChapter>();
        }

        public SubChapter GetItem(int index) => Items[index];

        public int AddItem(SubChapter item)
        {
            Items.Add(item);
            return Items.IndexOf(item);
        }

        public bool RemoveItem(SubChapter item) => Items.Remove(item);
        public void Print()
        {
            Console.WriteLine($"Titlu capitol: {Name}\n");
            Items.ForEach(item => item.Print());
        }
    }
    
    interface GenericItem<T>
    {
        List<T> Items { get; }
        T GetItem(int index);
        int AddItem(T item);
        bool RemoveItem(T item);
        void Print();
    }
}