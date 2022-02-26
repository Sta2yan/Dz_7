using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст для вывода: ");
            string userText = Console.ReadLine();
            Console.Write("Введите сколько раз нужно вывести текст: ");
            int countTextOutput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < countTextOutput; i++)
                Console.WriteLine((i + 1) + ". " + userText);
        }
    }
}