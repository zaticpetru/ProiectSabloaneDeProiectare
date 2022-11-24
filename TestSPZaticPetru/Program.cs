var firma = new Firma("UVT");
var departament = new Departament("DevOps");

departament.AddAngajat(new Manager("Jhon", 3500));
departament.AddAngajat(new Programator("Smith", 3150));
departament.AddAngajat(new Tester("Bob", 3000));

firma.AddDepartament(departament);

var statisticiSalariu = new StatisticiSalariu();
firma.Accept(statisticiSalariu);
statisticiSalariu.PrintStatistics();