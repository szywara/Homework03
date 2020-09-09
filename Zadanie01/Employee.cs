using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie01
{
    public class Employee
    {
        private string name;
        private string surname;
        private double rate;
        private double salary;

        public Employee (string name, string surname, double rate, double salary=0)
        {
            this.name = name; this.surname = surname;this.rate = rate; this.salary = salary;
        }
        public string Name { get { return name; } }
        public string Surname { get { return surname; } }
        public double Rate { get { return rate; } }

        public double RegisterTime (double time, double rate)
        {
            double onedaysalary;
            if (time <= 8 && time >= 0)
            {
                onedaysalary = time * rate;
            }
            else
            {
                onedaysalary = (time -8) * 2 * rate + 8 * rate;
            }
            
            return salary += onedaysalary;
        }

        

        public double Salary { get { return salary; } set { } }

        public void PaySalary(double x)
        {

            Console.WriteLine("Należność po stronie pracodawcy wynosi {0:C2}",x);
        }
    }
}
