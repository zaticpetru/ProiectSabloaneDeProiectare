namespace Models.Interfaces
{
    public interface IVisitor
    {
        void VisitBook(Book book);
        void VisitSection(Section section);
        
        void VisitParagraph(Paragraph paragraph);
        void VisitImageProxy(ImageProxy imageProxy);
        void VisitSubChapter(SubChapter subChapter);
        void VisitImage(Image image);
        void VisitTable(Table table);
    }
}
