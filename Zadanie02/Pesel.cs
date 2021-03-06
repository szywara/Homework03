﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie02
{
    public class Pesel
    {
        public string numerPesel;
        
        public Pesel(string pesel="")
        {
            numerPesel = pesel;
        }
        
        public PeselValidationResult Validate(string pesel)
        {

            PeselValidationResult result = new PeselValidationResult();

            if (pesel[2].ToString() == "0" || pesel[2].ToString() == "1")
            {
                string day = pesel[4].ToString() + pesel[5].ToString();
                string month = pesel[2].ToString() + pesel[3].ToString();
                string year = pesel[0].ToString() + pesel[1].ToString();

                result.date = String.Join("-", "19" + year, month, day);
                Console.WriteLine(result.date);
            }
            else if (pesel[2].ToString() == "2")
            {
                string day = pesel[4].ToString() + pesel[5].ToString();
                string month = "0" + pesel[3].ToString();
                string year = pesel[0].ToString() + pesel[1].ToString();

                result.date = String.Join("-", "20" + year, month, day);
                Console.WriteLine(result.date);
            }
            else if (pesel[2].ToString() == "3")
            {
                string day = pesel[4].ToString() + pesel[5].ToString();
                string month = "1" + pesel[3].ToString();
                string year = pesel[0].ToString() + pesel[1].ToString();

                result.date = String.Join("-", "20" + year, month, day);
                Console.WriteLine(result.date);
            }

            int x = pesel[9];
            if (x % 2 == 0)
            {
                result.sex = Sex.Kobieta;
            }
            else if (x % 2 != 0)
            {
                result.sex = Sex.Mężczyzna;
            }

            ;
            Console.WriteLine(result.sex);


            int control = 0;

            List<int> weights1 = new List<int>(10);

            int[] weights = {

            Convert.ToInt32(pesel[0].ToString()) *1,
            Convert.ToInt32(pesel[1].ToString()) *3,
            Convert.ToInt32(pesel[2].ToString()) *7,
            Convert.ToInt32(pesel[3].ToString()) *9,
            Convert.ToInt32(pesel[4].ToString()) *1,
            Convert.ToInt32(pesel[5].ToString()) *3,
            Convert.ToInt32(pesel[6].ToString()) *7,
            Convert.ToInt32(pesel[7].ToString()) *9,
            Convert.ToInt32(pesel[8].ToString()) *1,
            Convert.ToInt32(pesel[9].ToString())*3
                };

            int[] controlTab = new int[10];

            for (int i = 0; i < weights.Length; i++)
            {
                if (weights[i] > 10)
                {
                    controlTab[i] = weights[i] % 10;

                }
                else
                {
                    controlTab[i] = weights[i];
                }
            }

            control = 10 - controlTab.Sum() % 10;


            if (control.ToString() == pesel[10].ToString())
            {
                result.isValid = true;
                result.message = "Wprowadziłeś poprawny numer PESEL";
            }
            else
            {
                result.isValid = false;
                result.message = "Wprowadziłeś niepoprawny numer PESEL";
            }
            Console.WriteLine(control);

            Console.WriteLine(result.isValid);
            Console.WriteLine(result.message);

            return result;
        }

    }
}
