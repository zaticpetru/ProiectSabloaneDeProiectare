using Models;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookStatistics : IVisitor
    {
        private int sectionCounter = 0;
        private int imageCounter = 0;
        private int tableCounter = 0;
        private int paragaphCounter = 0;

        public void PrintStatistics()
        {
            Console.WriteLine("Book statistics:");
            Console.WriteLine("*** Number of images: " + imageCounter);
            Console.WriteLine("*** Number of tables: " + tableCounter);
            Console.WriteLine("*** Number of paragaphs: " + paragaphCounter);
        }
        public void VisitBook(Book book)
        {
            Console.WriteLine(book.Title + " from visitor");
        }
        public void VisitSection(Section section)
        {
            sectionCounter++;
            Console.WriteLine(section.Name);
        }
        public void VisitImage(Image image)
        {
            imageCounter++;
        }

        public void VisitImageProxy(ImageProxy imageProxy)
        {
            throw new NotImplementedException();
        }

        public void VisitParagraph(Paragraph paragraph)
        {
            paragaphCounter++;
        }

        public void VisitTable(Table table)
        {
            tableCounter++;
        }

        public void VisitSubChapter(SubChapter subChapter)
        {
            Console.WriteLine("in sub chap");
        }
    }
}
