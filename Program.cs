/* Yoshni hisoblash
Foydalanuvchining tug’ilgan yilini (int x) consoledan oling. Uning yoshini kunlarda 
ifodalang. Kabisa yilini hisobga olmang
Input: x=2004
Output: 6935
-----------------
Input: x= 1996
Output: 9855
*/
using System;
using System.Dynamic;
namespace Vazifa
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Qaysi yilda tug'ulgansiz: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int currentYear = 2023;
            int output;
            output = (currentYear - x ) *365 ;
            System.Console.WriteLine($"Output: {output}");

        }
    }
}