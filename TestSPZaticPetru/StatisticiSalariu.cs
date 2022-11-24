public class StatisticiSalariu : IVisitor
{
    public int SalariuTotalAngajati {
        get {
            return SalariuTotalTesteri
                + SalariuTotalProgramatori
                + SalariuTotalManageri;
            }
    }
    public int SalariuTotalTesteri { get; private set; } = 0;
    public int SalariuTotalManageri { get; private set; } = 0;
    public int SalariuTotalProgramatori { get; private set; } = 0;

    public void VisitFirma(Firma firma)
    {
        Console.WriteLine("Visitam firma:" + firma.Nume);

    }
    public void VisitDepartament(Departament departament)
    {
        Console.WriteLine("Visitam departamentul:" + departament.Nume);
    }


    public void VisitManager(Manager manager)
    {
        Console.WriteLine("Visitam manager:" + manager.Nume);
        SalariuTotalManageri += manager.Salariu;
    }

    public void VisitProgramator(Programator programator)
    {
        Console.WriteLine("Visitam programator:" + programator.Nume);
        SalariuTotalProgramatori += programator.Salariu;
    }

    public void VisitTester(Tester tester)
    {
        Console.WriteLine("Visitam tester:" + tester.Nume);
        SalariuTotalTesteri += tester.Salariu;
    }

    public void PrintStatistics()
    {
        Console.WriteLine("Salariu total angajati: " + SalariuTotalAngajati);
        Console.WriteLine("Salariu total manageri: " + SalariuTotalManageri);
        Console.WriteLine("Salariu total programatori: " + SalariuTotalProgramatori);
        Console.WriteLine("Salariu total testeri: " + SalariuTotalTesteri);
    }
}
