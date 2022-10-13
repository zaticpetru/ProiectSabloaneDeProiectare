namespace ProiectSP
{
    public class Chapter
    {
        public string Name { get; set; }
        public List<SubChapter> SubChapters { get; set; }
        public Chapter(string name)
        {
            Name = name;
            SubChapters = new List<SubChapter>();
        }
        public int CreateSubChapter(string name)
        {
            var subChapter = new SubChapter(name);
            SubChapters.Add(subChapter);
            return SubChapters.IndexOf(subChapter);
        }
        public SubChapter GetSubChapter(int index) => SubChapters[index];
        public void Print()
        {
            Console.WriteLine($"Titlu capitol: {Name}\n");
            SubChapters.ForEach(item => item.Print());
        }
    }
}