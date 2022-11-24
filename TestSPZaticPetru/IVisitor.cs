public interface IVisitor
{
    void VisitFirma(Firma firma);
    void VisitDepartament(Departament departament);
    void VisitManager(Manager manager);
    void VisitProgramator(Programator programator);
    void VisitTester(Tester tester);
}