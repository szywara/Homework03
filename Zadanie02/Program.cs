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
            
            PeselValidationResult check = new PeselValidationResult();

            check.CheckPesel(pesel);
            check.CheckPesel(peselB);

            Console.WriteLine("Wprowadź numer PESEL");
            check.CheckPesel(Console.ReadLine());


            Console.ReadLine();
        }
    }
}
