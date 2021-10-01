using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_25._09._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год");
            int year = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(year, 1, 1);
            Console.WriteLine("Введите кол-во дней от 1 до 365");
            int days = int.Parse(Console.ReadLine());
            if ((days > 365) | (days < 1))
            {
                Console.WriteLine("кол-во дней должно быть = [1; 365]");
                days = 1;
            }
            date = date.AddDays(days - 1);
            Console.WriteLine("{0}", date.ToLongDateString());

            Console.ReadKey();
        }
    }
}
