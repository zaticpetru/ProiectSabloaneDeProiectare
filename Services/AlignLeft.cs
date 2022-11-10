using Models;
using Models.Interfaces;

namespace Services
{
    public class AlignLeft : IAlignStrategy
    {
        public void render(Paragraph paragraph, string Context = "")
        {
            Console.WriteLine(paragraph.Content);
        }
    }
}
