public class Departament : IVisitee
{
    public Departament? ParentDepatament { get; set; }
    public List<Departament> SubDepartamente { get; private set; }
    public List<IAngajat> Angajati { get; private set; }
    public string Nume { get; private set; }

    public Departament(string nume)
    {
        SubDepartamente = new List<Departament>();
        Angajati = new List<IAngajat>();
        Nume = nume;
    }

    public int AddSubDepartament(Departament departament)
    {
        departament.ParentDepatament = this;
        SubDepartamente.Add(departament);
        return SubDepartamente.IndexOf(departament);
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

        SubDepartamente.ForEach(subDepartament => subDepartament.Accept(visitor));
    }
}
