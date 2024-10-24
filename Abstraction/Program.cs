using Abstraction;
Employee employee = new YazilimGelistirici("Hasan", "Çıldırmış");
employee.Gorev();
Employee employee1 = new ProjeYoneticisi("Ayşe", "Yılmaz");
employee1.Gorev();
Employee employee2 = new SatisTemsilcisi("Mehmet", "Demir");
employee2.Gorev();

Console.ReadKey();


