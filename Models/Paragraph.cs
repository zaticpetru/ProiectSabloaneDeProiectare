using Models.Interfaces;

namespace Models
{
    public class Paragraph : BookItem, IVisitee
    {
        public Paragraph(string content) : base(content) { }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitParagraph(this);
        }

        public override void Print()
        {
            if(AlignStrategy != null)
            {
                AlignStrategy.render(this);
            } else
            {
                base.Print();
            }
        }
    }
}