namespace ProiectSP
{
    public class Image : BookItem
    {
        public Image(string content) : base(content) { }
        public override void Print() => Console.WriteLine(Content + " * rendering *");
    }
}