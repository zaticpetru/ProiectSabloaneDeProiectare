public class Firma : IVisitee
{
    public List<Departament> Departamente { get; private set; }
    public string Nume { get; private set; }
    public Firma(string nume)
    {
        Departamente = new List<Departament>();
        Nume = nume;
    }

    public int AddDepartament(Departament departament)
    {
        Departamente.Add(departament);
        return Departamente.IndexOf(departament);
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitFirma(this);
        Departamente.ForEach(departament =>
        {
            if(departament is IVisitee visitee)
            {
                visitee.Accept(visitor);
            }
        });
    }
}
