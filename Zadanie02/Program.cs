using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie02
{
    class Program
    {
        static void Main(string[] args)
        {
            string pesel = "88091203652";
            string peselB = "88050211568";
            
            //PeselValidationResult check = new PeselValidationResult();
            Pesel check = new Pesel();
            
            check.Validate(pesel);
            check.Validate(peselB);

            Console.WriteLine("Wprowadź numer PESEL");
            check.Validate(Console.ReadLine());


            Console.ReadLine();
        }
    }
}
