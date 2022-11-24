public class Departament : IVisitee
{
    public List<IAngajat> Angajati { get; private set; }
    public string Nume { get; private set; }

    public Departament(string nume)
    {
        Angajati = new List<IAngajat>();
        Nume = nume;
    }

    public int AddAngajat(IAngajat angajat)
    {
        Angajati.Add(angajat);
        return Angajati.IndexOf(angajat);
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitDepartament(this);
        Angajati.ForEach(angajat =>
        {
            if(angajat is IVisitee visitee)
            {
                visitee.Accept(visitor);
            }
        });
    }
}
