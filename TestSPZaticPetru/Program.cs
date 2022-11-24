var firma = new Firma("UVT");
var departamentDevOps = new Departament("DevOps");

departamentDevOps.AddAngajat(new Manager("Jhon", 3500));
departamentDevOps.AddAngajat(new Programator("Smith", 3150));
departamentDevOps.AddAngajat(new Tester("Bob", 3000));

var departamentFrontend = new Departament("Frontend");
departamentFrontend.AddAngajat(new Manager("Mikael", 3650));
departamentFrontend.AddAngajat(new Programator("Katie", 2000));

var departamentIntershipFrontend = new Departament("IntershipFrontend");
departamentIntershipFrontend.AddAngajat(new Programator("Teacher", 9090));
departamentIntershipFrontend.AddAngajat(new Programator("Guru", 9099));

departamentFrontend.AddSubDepartament(departamentIntershipFrontend);

firma.AddDepartament(departamentFrontend);
firma.AddDepartament(departamentDevOps);

var statisticiSalariu = new StatisticiSalariu();
firma.Accept(statisticiSalariu);
statisticiSalariu.PrintStatistics();