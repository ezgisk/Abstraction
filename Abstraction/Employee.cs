 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    //Base class
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        public Employee(string firstName, string lastName, string department) 
        { 
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }
        public abstract void Gorev();
    }
    // Inharatance class
    public class YazilimGelistirici : Employee
    {
        public YazilimGelistirici(string firstName, string lastName) : base(firstName, lastName, "Software")
        {
           
        }

        public override void Gorev()
        {
            Console.WriteLine($"{FirstName} {LastName}, Yazılım Geliştirici olarak çalışıyorum.");
        }
    }
    // Inharatance class
    public class ProjeYoneticisi : Employee
    {
        public ProjeYoneticisi(string firstName, string lastName)
            : base(firstName, lastName, "Proje Yönetimi") { }

        public override void Gorev()
        {
            Console.WriteLine($"{FirstName} {LastName}, Proje Yöneticisi olarak çalışıyorum.");
        }
    }
    // Inharatance class
    public class SatisTemsilcisi : Employee
    {
        public SatisTemsilcisi(string firstName, string lastName)
            : base(firstName, lastName, "Satış") { }

        public override void Gorev()
        {
            Console.WriteLine($"{FirstName} {LastName}, Satış Temsilcisi olarak çalışıyorum.");
        }
    }
}
