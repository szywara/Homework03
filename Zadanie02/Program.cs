using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie02
{
    class Program
    {
        static void Main(string[] args)
        {
            string pesel = "88091203625";

            PeselValidationResult pesel1 = new PeselValidationResult();

            pesel1.date = "";
            pesel1.isValid = false;
            pesel1.message = "";
            pesel1.sex = Sex.Kobieta;

            Console.WriteLine(pesel1.GetDate(pesel));

            pesel1.date = pesel1.GetDate(pesel);

            Console.WriteLine(pesel1.date);

            Console.ReadLine();
        }
    }
}
