using Models.Interfaces;

namespace Models
{
    public class Table : BookItem, IVisitee
    {
        public Table(string content) : base(content) { }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitTable(this);
        }
    }
}