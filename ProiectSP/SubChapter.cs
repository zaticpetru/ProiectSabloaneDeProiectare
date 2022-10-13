namespace ProiectSP
{
    public class SubChapter
        {
            public string Name { get; set; }
            public List<BookItem> SubChapterItems { get; set; }
            public SubChapter(string name)
            {
                Name = name;
                SubChapterItems = new List<BookItem>();
            }
            public void CreateNewParagraph(string content)
            {
                SubChapterItems.Add(new Paragraph(content));
            }
            public void CreateNewImage(string content)
            {
                SubChapterItems.Add(new Image(content));
            }
            public void CreateNewTable(string content)
            {
                SubChapterItems.Add(new Table(content));
            }
            public void Print()
            {
                Console.WriteLine($"Titlu subcapitol: {Name}\n");
                SubChapterItems.ForEach(item => item.Print());
            }
        }
}