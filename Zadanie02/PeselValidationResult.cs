using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie02
{
    public enum Sex
    {Kobieta=1, Mężczyzna=2 };



    public class PeselValidationResult
    {

        public bool isValid;
        public Sex sex = Sex.Kobieta;
        public string date;
        public string message;

        public PeselValidationResult(bool isValid=false,Sex sex = Sex.Kobieta, string date = "", string message = "" )
        {
            this.isValid = isValid; this.sex = sex; this.date = date; this.message = message;
        }

              

    }
}
