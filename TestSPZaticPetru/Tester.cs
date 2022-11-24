public class Tester : IAngajat, IVisitee
{
    public string Nume { get; private set; }

    public int Salariu { get; private set; }
    public Tester(string nume, int salariu)
    {
        Nume = nume;
        Salariu = salariu;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitTester(this);
    }
}
