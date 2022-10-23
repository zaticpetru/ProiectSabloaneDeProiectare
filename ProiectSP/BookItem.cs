namespace ProiectSP
{
    public abstract class BookItem
    {
        public string Content { get; }

        public BookItem(string content)
        {
            Content = content;
        }

        public virtual void Print() => Console.WriteLine(Content);
    }
}