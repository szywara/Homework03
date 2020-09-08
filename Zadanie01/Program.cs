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
            double salary = 0;
            Console.WriteLine("Podawaj godziny pracy każdego dnia, żeby dokonać wypłaty wpisz 0");
            do
            {
                Console.WriteLine("Podaj czas pracy pracownika {0} {1}", emp1.Name, emp1.Surname);
                
                time = Convert.ToDouble(Console.ReadLine());
                
                salary += emp1.RegisterTime(time, emp1.Rate);
                
            } while (time>0);

            emp1.PaySalary(salary);
            Console.ReadLine();
        }
    }
}
