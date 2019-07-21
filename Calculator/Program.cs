using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {

            do
            {
                try
                {
                    string wybor = Menu();
                    int dzialanie = Int32.Parse(wybor);
                    Dzialania klasa = new Dzialania();
                    switch (Int32.Parse(wybor))
                    {
                        case 1:
                            Console.WriteLine("Wybrałeś Dodawanie. Wprowadddz dwie liczby.");
                            int wynikDodawania = klasa.dodawanie();
                            Console.WriteLine(wynikDodawania);
                            break;
                        case 2:
                            Console.WriteLine("Wybrałeś Odejmowanie Wprowadz dwie liczby.");
                            int wynikOdejmowania = klasa.odejmowanie();
                            Console.WriteLine(wynikOdejmowania);
                            break;
                        case 3:
                            Console.WriteLine("Wybrałeś Mnożenie");
                            int wynikMnozenia = klasa.mnozenie();
                            Console.WriteLine(wynikMnozenia);
                            break;
                        case 4:
                            Console.WriteLine("Wybrałeś Dzielenie");
                            float wynikDzielenia = klasa.dzielenie();
                            if (wynikDzielenia != 9999999999)
                            {
                                Console.WriteLine(wynikDzielenia);
                            }
                            else
                            {
                                Console.WriteLine("Nie dziel przez 0!");
                            }
                            break;
                        case 5:
                            Console.WriteLine("Wybrałeś Dzielenie Modulo");
                            int wynikModulo = klasa.dzielenieModulo();
                            Console.WriteLine(wynikModulo);
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Wybrałeś numer spoza zakresu. Wybierz jeszcze raz.");
                            break;
                    }
                    Console.ReadLine();
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Podaj odpowiednią liczbę!");
                    Console.ReadLine();
                }
            }
            while (true);
            
        }
        private static string Menu()
        {
            Console.Clear();
            Console.WriteLine("Wybierz numer działania:\n 1. Dodawanie \n 2. Odejmowanie \n 3. Mnożenie \n 4. Dzielenie \n 5. Modulo \n 0. Wyjście");
                string dzialanie = Console.ReadLine();
                return dzialanie;
        }
    }
}
