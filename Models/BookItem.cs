using Models.Interfaces;

namespace Models
{
    public abstract class BookItem
    {
        public string Content { get; }
        public IAlignStrategy? AlignStrategy { get; set; }

        public BookItem(string content)
        {
            Content = content;
        }

        public virtual void Print() => Console.WriteLine(Content);
    }
}