namespace Models.Interfaces
{
    public interface IVisitee
    {
        void Accept(IVisitor visitor);
    }
}
