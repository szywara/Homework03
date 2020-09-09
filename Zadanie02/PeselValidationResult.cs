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

        public bool isValid;
        public Sex sex = Sex.Kobieta;
        public string date;
        public string message;

        public PeselValidationResult(Sex sex = Sex.Kobieta, string date = "", string message = "", bool isValid = false)
        {
            this.isValid = isValid; this.sex = sex; this.date = date; this.message = message;
        }


        public string GetDate(string x)
        {
            string day = x[4].ToString() + x[5].ToString();
            string month = x[3].ToString() + x[2].ToString();
            string year = x[0].ToString() + x[1].ToString();
            string date = String.Join("-", year, month, day);
            Console.WriteLine(date);
            return date;
        }
        public bool ValidCheck(string x)
        {
            string pesel = x;
            Console.WriteLine(pesel);
            return false;
        }



        


    }
}
