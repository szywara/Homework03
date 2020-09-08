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

        public Employee (string name, string surname, double rate)
        {
            this.name = name; this.surname = surname;this.rate = rate;
        }
        public string Name { get { return name; } }
        public string Surname { get { return surname; } }
        public double Rate { get { return rate; } }

        public double RegisterTime (double time, double rate)
        {
            double salary;
            if (time <= 8 && time >= 0)
            {
                salary = time * rate;
            }
            else
            {
                salary = (time -8) * 2 * rate + 8 * rate;
            }
            
            return salary;
        }

        public void PaySalary(double x)
        {

            Console.WriteLine("Należność po stronie pracodawcy wynosi {0:C2}",x);
        }
    }
}
