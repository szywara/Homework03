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
            Employee emp1 = new Employee("Jan", "Nowak", 100);
            
            Console.WriteLine("Podawaj godziny pracy każdego dnia, żeby obliczyć wysokość wypłaty");
               Console.WriteLine("Żeby dokonać wypłaty wpisz 0");
            do
            {
                Console.WriteLine("Podaj czas pracy pracownika {0} {1}", emp1.Name, emp1.Surname);
                
                time = Convert.ToDouble(Console.ReadLine());

                emp1.Salary += emp1.RegisterTime(time, emp1.Rate);
                
            } while (time>0);

            emp1.PaySalary(emp1.Salary);
            Console.ReadLine();
        }
    }
}
