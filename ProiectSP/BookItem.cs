namespace ProiectSP
{
    public abstract class BookItem
    {
        public string Content { get; set; }

        public BookItem(string content)
        {
            Content = content;
        }

        public virtual void Print() => Console.WriteLine(Content);
    }
}