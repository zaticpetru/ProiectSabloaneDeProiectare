public class Programator : IAngajat, IVisitee
{
    public string Nume { get; private set; }

    public int Salariu { get; private set; }

    public Programator(string nume, int salariu)
    {
        Nume = nume;
        Salariu = salariu;
    }

    public void Accept(IVisitor visitor) => visitor.VisitProgramator(this);
}
