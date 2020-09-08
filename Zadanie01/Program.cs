using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Zadanie01
{
    class Program
    {
        static void Main(string[] args)
        {
            double time;

            do
            {
                Employee emp1 = new Employee("Jan", "Nowak", 100);
                Console.WriteLine("podaj czas pracy pracownika {0} {1}", emp1.Name, emp1.Surname);
                time = Convert.ToDouble(Console.ReadLine());
                double salary = emp1.RegisterTime(time, emp1.Rate);
                emp1.PaySalary(salary);
            } while (time>0);
             

            Console.ReadLine();
        }
    }
}
