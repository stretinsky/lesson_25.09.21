using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_25._09._21
{
    class Program
    {
        enum Mouth {small, wide}
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1.1\nВведите число");
            double number = double.Parse(Console.ReadLine());
            if (number >= 0)
            {
                Console.WriteLine("Его модуль {0}", number);
            }
            else
            {
                Console.WriteLine("его модуль {0}", (-1) * number);
            }

            Console.WriteLine("\nTask 1.2\nВведите первое число");
            double firstNubmer = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int secondNumber = int.Parse(Console.ReadLine());
            if (Math.Abs(firstNubmer) > Math.Abs(secondNumber))
            {
                firstNubmer /= 2;
            }
            Console.WriteLine("Первое число {0}", firstNubmer);

            Console.WriteLine("\nTask 3\nВведите имя животного");
            string animalName = Console.ReadLine();
            if (animalName.ToLower() == "аллигатор")
            {
                Mouth mouthSize = Mouth.small;
                Console.WriteLine("mouthSize = small");
            }
            else
            {
                Mouth mouthSize = Mouth.wide;
                Console.WriteLine("mouthSize = wide");
            }

            Console.WriteLine("\nTask 1.4\nВведите что-то из этого: Jarboni, School Counselor, Programmer, Bike Gang Member, Politician, Rapper, anything else");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "jarboni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }

            Console.WriteLine("\nTask 1.5\nВведите строку");
            input = Console.ReadLine().ToLower();
            bool answer;
            if (input.Length > input.Replace("english", "").Length)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            Console.WriteLine(answer);

            Console.WriteLine("\nTask 2.1");
            double sum = 1;
            for (int i = 0; i < 8; i++)
            {
                sum = (double)sum / 3 + 1;
            }
            Console.WriteLine(sum);

            Console.WriteLine("\nTask 2.2");
            byte N = 100;
            sum = 0;
            double distance = 0;
            for (int i = 1; i <= N; i++)
            {
                distance += (double)Math.Pow(-1, i-1) / i;
                sum += (double)1 / i;
            }
            Console.WriteLine("Он будет на расстоние {0} км от дома, всего он пройдет {1} км", distance, sum);

          /*  Console.WriteLine("\nTask 2.3\nВводите кол-во осадков выпадавших каждый день января и марта");
            int total = 0;
            for (int i = 0; i < 62; i++)
            {
                total += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Среднедневное кол-во осадков {0}", (double)total / 62);
          */
            Console.WriteLine("\nTask 3.1");
            double firstCount = 2;
            double secondCount = 3/2;
            int count = 3;
            sum = 0;
            while (Math.Abs(firstCount-secondCount) > 0.001)
            {
                count++;
                firstCount = secondCount;
                secondCount = (double)count / (count - 1);
            }
            Console.WriteLine("{0} член отличается от предыдущего меньше чем на 0.001", count);

            Console.WriteLine("\nTask 3.2\nВведите число n");
            double n = double.Parse(Console.ReadLine());
            int j = 1;
            number = 1;
            while (n > number)
            {
                number = Math.Pow(j++, 2);
            }
            Console.WriteLine("{0} первое число больше n", number);

            Console.WriteLine("\nTask 3.3");
            n = 100;
            while (n >= 80)
            {
                Console.WriteLine(n);
                n--;
            }
            n = 100;
            do
            {
                Console.WriteLine(n);
                n--;
            } while (n >= 80);

            Console.WriteLine("\ntask 3.4");
            for (int i = 4998; i > 39; i -= 3)
            {
                if (i % 39 == 0)
                {
                    Console.WriteLine("Наибольшее число не превыщающее 5000 это {0}", i);
                    break;
                }
            }

            Console.WriteLine("\nTask 3.5");
            for (int i = 1; i < 6; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write("5 ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            for (int i = 5; i > 0; i--)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write("1 ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\nДопка\nВведите число а - номер вертикали клетки, где стоит фигура");
            byte a = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b - номер горизонтали клетки, где стоит ");
            byte b = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите число c - номер вертикали второй клетки");
            byte c = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите число d - номер горизонтали второй клетки");
            byte d = byte.Parse(Console.ReadLine());
            if ((a == c) | (b == d))
            {
                Console.WriteLine("Ладья угрожает этому полю");
            }
            else
            {
                Console.WriteLine("Ладья не угрожает этому полю");
            }
            if (Math.Abs(a - c) == Math.Abs(b - d))
            {
                Console.WriteLine("Слон угрожает этому полю");
            }
            else
            {
                Console.WriteLine("Слон не угрожает этому полю");
            }
            if ((a == c) | (b == d) | Math.Abs(a - c) == Math.Abs(b - d))
            {
                Console.WriteLine("Ферзь угрожает этому полю");
            }
            else
            {
                Console.WriteLine("Ферзь не угрожает этому полю");
            }
            if ((a + 1 == c & b + 2 == d) | (a + 1 == c & b - 2 == d) | (a + 2 == c & b + 1 == d) | (a + 2 == c & b - 1 == d) | (a - 2 == c & b + 1 == d) | (a - 2 == c & b - 1 == d) | (a -1 == c & b + 1 == d) | (a - 1 == c & b - 1 == d))
            {
                Console.WriteLine("Конь угрожает этому полю");
            }
            else
            {
                Console.WriteLine("Конь не угрожает этому полю");
            }
            Console.WriteLine("\nВведите число а - номер вертикали клетки, где стоит фигура");
            a = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b - номер горизонтали клетки, где стоит ");
            b = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите число c - номер вертикали второй клетки");
            c = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите число d - номер горизонтали второй клетки");
            d = byte.Parse(Console.ReadLine());
            if (Math.Abs(a - c) <= 1 & Math.Abs(b - d) <= 1)
            {
                Console.WriteLine("Король может попасть на поле за 1 ход");
            }
            else
            {
                Console.WriteLine("Король не может попасть за 1 ход на это поле");
            }

            Console.ReadKey();
        }
    }
}
