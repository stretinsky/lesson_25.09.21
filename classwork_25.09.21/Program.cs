using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork_25._09._21
{
    public enum DayOfWeek
    {
        Понедельник,
        Втроник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }

    public enum Cards
    {
        Шестерка,
        Семерка,
        Восьмерка,
        Девятка, 
        Десятка,
        Валет,
        Дама,
        Король,
        Туз
    }
    class Program
    {
        static double Distance(int height)
        {
            int R = 6370;
            return Math.Sqrt((R + height) * (R + height) - R * R);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1\nВведите трёхзначное число");
            short number = short.Parse(Console.ReadLine());
            if((number % 10) == (number / 100))
            {
                Console.WriteLine("Число {0} является палиндромом", number);
            }
            else
            {
                Console.WriteLine("Число {0} не является палиндромом", number);
            }

            Console.WriteLine("\nTask 2\nВведите а - ширину форточки");
            byte a = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите b - высоту форточки");
            byte b = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите диаметр головы d");
            byte d = byte.Parse(Console.ReadLine());
            if(d <= (Math.Min(a,b) - 1))
            {
                Console.WriteLine("Вася сможет высунуть голову в форточку");
            }
            else
            {
                Console.WriteLine("Вася не сможет выснунуть голову в форточку");
            }

            Console.WriteLine("\nTask 3\nВведите порядковый номер дня недели");
            byte index = byte.Parse(Console.ReadLine());
            if ((index < 1) | (index > 7))
            {
                Console.WriteLine("Нет такого дня недели");
            }
            else 
            {
                Console.WriteLine((DayOfWeek)(index - 1));
            }
           
 
            try
            {
                Console.WriteLine("\nTask 4\nВведите номер карты от 6 до 14");
                index = byte.Parse(Console.ReadLine());
                if ((index < 6) | (index > 14))
                {
                    Console.WriteLine("Нет такой карты");
                }
                else
                {
                    Console.WriteLine((Cards)(index - 6));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число");
            }
            catch
            {
                Console.WriteLine("Что-то не так");
            }

            Console.WriteLine("\nTask 5");
            for (int height = 1; height < 11; height++)
            {
                Console.WriteLine("Расстояние до линии горизонта с высоты над Землей {0} км = {1} км", height, Distance(height));
            }

            Console.WriteLine("\nTask 6\nВведите число n (1 <= n <= 9)");
            byte n = byte.Parse(Console.ReadLine());
            Console.WriteLine("Таблица умножения для числа N:");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, n, i * n);
            }

            try
            {
                Console.WriteLine("\nTask 7\nВводите числа последовательности");
                int total = 0;
                int count = 0;
                int[] numbers = new int[134124124];
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                    if (numbers[i] < 0)
                    {
                        break;
                    }
                    total += numbers[i];
                    count += 1;
                }
                Console.WriteLine("Среднее арифметическое {0}", (double)total / count);
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число");
            }
            catch
            {
                Console.WriteLine("Что-то не так");
            }


            Console.WriteLine("\nTask 8\nВведите последовательность из 10 чисел через пробел (например, 0 1 4 32 7 45 42 12 6 234)");
            string [] sequence = Console.ReadLine().Split(' ');
            bool flag = false;
            for (int i = 1; i < sequence.Length; i++)
            {
                if (int.Parse(sequence[i]) < int.Parse(sequence[i-1]))
                {
                    Console.WriteLine("{0} член последовательности нарушает её возрастание", i+1);
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Последовательность все время возрастает");
            }

            Console.WriteLine("\nTask 9\nВводите числа последовательности");
            number = 0;
            int[] line = new int[123124215];
            for (int i = 0; i < line.Length; i++)
            {
                line[i] = int.Parse(Console.ReadLine());
                number++;
                if (line[i] == 0)
                {
                    break;
                }  
            }
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                if ((i + 1) % 3 != 0)
                {
                    continue;
                }
                sum += line[i];
            }
            Console.WriteLine("Сумма элементов последовательности, которые кратны трём, равна {0}", sum);

            Console.WriteLine("\nTask 10\nВведите последовательность через пробел (например, 0 1 4 32 7 45 42 12 6 234)");
            sequence = Console.ReadLine().Split(' ');
            int[] chain = new int[sequence.Length];
            for (int i = 0; i < sequence.Length; i++)
            {
                chain[i] = int.Parse(sequence[i]);
            }
            sum = 0;
            int j = 0;
        cycle:
            sum += chain[j];
            j++;
            if (j < chain.Length) goto cycle;
            Console.WriteLine("Сумма последовательности равна {0}", sum);
                 

            Console.ReadKey();
        }
    }
}
