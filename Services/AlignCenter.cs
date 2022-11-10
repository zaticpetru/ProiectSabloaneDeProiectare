using Models;

namespace Services
{
    public class AlignCenter : IAlignStrategy
    {
        public void render(Paragraph paragraph, string Context = "")
        {
            Console.CursorLeft = (Console.BufferWidth - paragraph.Content.Length) / 2;
            Console.WriteLine(paragraph.Content);
        }
    }
}