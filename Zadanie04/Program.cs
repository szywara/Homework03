using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie04
{
    enum liczby
    {
        I = 1,
        II = 2,
        III = 3,
        IV = 4,
        V = 5,
        VI = 6,
        VII = 7,
        VIII = 8,
        IX = 9,
        X = 10
    }
    class Program
    {
        //   Napisać klasę statyczną udostępniająca możliwość konwersji liczb arabskich na rzymskie i liczb rzymskich na liczby 
        //arabskie.Algorytmu najlepiej poszukać w necie.
        //- zdefiniować dwie metody: ArabskieNaRzymskie(int liczba) , RzymskieNaArabskie(string liczba)
        //- metody mają zwracać przekonwertowane wartości
        //- parametrem wywołania ww.metod jest liczba: odpowiednio arabska (np. 1988) jako integer lub rzymska(np.MMII) jako string
        //- zweryfikować poprawność wprowadzanych danych, w przypadku gdy nie jest możliwe skonwertowanie jakieś wartości np.jako 
        //parametr do RzymskieNaArabskie(string liczba) 
        //został wprowadzony string zawierający znaki ZSAB(czyli spoza poprawnych znaków dla liczb rzymskich)
        //- ograniczyć zakres wprowadzonej wartości w przypadku funkcji ArabskieNaRzymskie(int liczba) do zakresu od 1 do 3999 (włącznie)

        
        static void Main(string[] args)
        {
            Console.WriteLine(Converter.arabic2roman(1988));
            Console.WriteLine(Converter.roman2arabic("ZSAB"));
            Console.ReadKey();
        }
    }
}
