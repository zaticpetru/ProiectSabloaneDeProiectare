public class Manager : IAngajat, IVisitee
{
    public string Nume { get; private set; }

    public int Salariu { get; private set; }

    public Manager(string nume, int salariu)
    {
        Nume = nume;
        Salariu = salariu;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitManager(this);
    }
}
