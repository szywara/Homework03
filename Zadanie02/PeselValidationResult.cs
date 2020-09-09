using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie02
{
    enum Sex
    {Kobieta=1, Mężczyzna=2 };



    class PeselValidationResult 
    {
        
        private bool czyPoprawny;
        private Sex sex = Sex.Kobieta;  
        private string date;
        private string komunikat;

        public string GetDate (string x)
        {
            string day = x[1].ToString();
            Console.WriteLine(day);
            return x;
        }
        


     
    }
}
