using Models;

namespace Services
{
    public class AlignRight : IAlignStrategy
    {
        public void render(Paragraph paragraph, string Context = "")
        {
            Console.CursorLeft = Console.BufferWidth - paragraph.Content.Length;
            Console.WriteLine(paragraph.Content);
        }
    }
}
