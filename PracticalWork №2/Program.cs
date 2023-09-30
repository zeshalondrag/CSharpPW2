using System;

class Program
{
    static void Main()
    {
        int sosiska;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Выберите программу: ");
            Console.WriteLine("Программа №1 - Игра 'Угадай число'");
            Console.WriteLine("Программа №2 - Таблица умножения");
            Console.WriteLine("Программа №3 - Вывод делителей числа");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("Введите номер программы, которую вы хотите запустить: ");
            
            if (!int.TryParse(Console.ReadLine(), out sosiska))
            {
                Console.WriteLine("Ошибка: Неправильный выбор программы. Пожалуйста, введите номер программы (число).");
                continue;
            }

            switch (sosiska)
            {
                case 1:
                    numbergame();
                    break;

                case 2:
                    Console.WriteLine("'Таблица умножения выбрана'");
                    multiplicationtable();
                    break;

                case 3:
                    Console.WriteLine("'Вывод делителей числа выбран'");
                    outputofnumberdivisors();
                    break;

                case 0:
                    Console.WriteLine("Выход из программы.");
                    break;

                default:
                    Console.WriteLine("Ошибка: Неправильный выбор программы. Пожалуйста, введите номер программы (1, 2, 3 или 0).");
                    break;

            }
        } while (sosiska != 0);
    }

    static void numbergame()
    {
        Random random = new Random();
        int snum = random.Next(101);

        Console.WriteLine("Вы попали в игру 'Угадай число'!");
        Console.WriteLine("Я загадал рандомное число от 0 до 100. Попробуйте угадать.");

        int popit = 0;
        int lolik;

        do
        {
            Console.Write("Введите ваше предположение: ");

            if (int.TryParse(Console.ReadLine(), out lolik))
            {
                if (lolik < snum)
                {
                    Console.WriteLine("Мое число больше.");
                }
                else if (lolik > snum)
                {
                    Console.WriteLine("Мое число меньше.");
                }

                popit++;
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное число.");
            }
        } while (lolik != snum);

        Console.WriteLine($"Отлично! Вы угадали число {snum} за {popit} попыток.");
        Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню выбора программы.");
        Console.ReadKey();
    }
    static void multiplicationtable()
    {
        int razmer = 9;
        int[,] multiplicationtable = new int[razmer, razmer];

        for (int i = 0; i < razmer; i++)
        {
            for (int j = 0; j < razmer; j++)
            {
                multiplicationtable[i, j] = (i + 1) * (j + 1);
            }
        }
        Console.WriteLine("Таблица умножения:");

        for (int i = 0; i < razmer; i++)
        {
            for (int j = 0; j < razmer; j++)
            {
                Console.Write($"{multiplicationtable[i, j],-4}");
            }
            Console.WriteLine();
        }
    }
    static void outputofnumberdivisors()
    {
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());

        for (int a = 1; a <= num; a++)
        {
            if (num % a == 0)
            {
                Console.Write("{0} ", a);
            }
        }
    }
}