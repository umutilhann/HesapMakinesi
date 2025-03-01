using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Sayıyı Giriniz:");
                int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İşlem (+,-,/,*) : ");
            String operation = Console.ReadLine();

            double result = 0;
            if (operation == "+")
            {
                result = number1 + number2;
            }
            else if (operation == "-")
            {
                result = number1 - number2;
            }
            else if (operation == "*")
            {
                result = number1 * number2;
            }
            else if(operation == "/")
            {
                if (number2 == 0)
                {
                    Console.WriteLine("Bölen sıfır olamaz!");
                }
                else
                {
                    result = number1 / number2;
                }
            }
            else
            {
                Console.WriteLine("Hatalı işlem girdiniz!");
            }
            Console.WriteLine("Sonuç: " + result);
            

        }
    }
}
