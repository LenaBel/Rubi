using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, Rubius! :) ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" v ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("### \n### \n###");
            Console.ResetColor();
            Console.WriteLine("Я маленькая консольная программа. Моя разработчица только осваивает С#, поэтому я ещё мало чего умею, но ведь не это главное, а главное - что у меня внутри. \nДавай я расскажу, что я умею, а ты выбирай!");
            string vibor;
            do
            {
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Чем займёмся? \n1. Я умею сравнивать два простых числа. \n2. Перемножить 2 числа не больше 10. \n3. Могу производить всяческие другие математические операции на твой выбор. \n4. Кстати, ты знаешь таблицу умножения? Я знаю! Показать? \n5. Могу посчитать сумму вклада с учётом процентов и бонусов. \n6. Или можешь сыграть с другом в крестики-нолики.");
                Console.WriteLine("Напиши номер операции, которую мне стоит выполнить или нажми любую другую клавишу, если я тебя утомил.");
                Console.ResetColor();
                vibor = Console.ReadLine();
                switch (vibor)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("О! Я люблю сравнивать!");
                        Sravni();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Могу перемножить небольшие целые числа от 0 до 10 включительно. \nЧур не жульничать!");
                        Smallnum010();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Давай что-нибудь посчитаем!");
                        Calkul();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Вот она какая:");
                        Tabum();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Чего расскажу! От СамГлавБанка поступило заманчивое предложение на годовые вклады: \n- при вкладе до 10000 рублей начисляется 5%, \n- при вкладе от 10000 до 20000 рублей начисляют 7%, \n- а при вкаде больше 20000 рублей начисляют 10%. \nИ бонусом 15 рублей на конфетку при любом раскладе! Надо соглашаться!");
                        Vklad();
                        break;
                    case "6":
                        ConsoleXO();
                        break;
                }
            } while (vibor == "1" || vibor == "2" || vibor == "3" || vibor == "4" || vibor == "5" || vibor == "6");
            Console.Clear();
            Console.WriteLine("Хммм... \nАНЕКДОТ: Голодный программист открывает холодильник, достаёт пачку масла, читает- \"72%\". С мыслью \"ещё не загрузилось\" кладёт масло обратно. \nНе будь как он, отдохни, завари себе кофейку :) \nСпасибо, что был со мной! \nПока-пока!");
            Console.ReadKey();
        }
        public static void Sravni()
        {
            Console.WriteLine("Введи первое число: ");
            int srav1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи второе число: ");
            int srav2 = Convert.ToInt32(Console.ReadLine());
            if (srav1 > srav2)
                Console.WriteLine("Первое число больше второго.");
            else if (srav1 < srav2)
                Console.WriteLine("Первое число меньше второго.");
            else
                Console.WriteLine("Числа равны.");
        }
        public static void Smallnum010()
        {
            while (true)
            {
                Console.WriteLine("Введи первое число: ");
                int snum1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введи второе число: ");
                int snum2 = Convert.ToInt32(Console.ReadLine());
                if (snum1 < 0 || snum1 > 10 || snum2 < 0 || snum2 > 10)
                {
                    Console.WriteLine("Эээй! Оба числа должны быть в диапазоне от 0 до 10 включительно, мы же договаривались!");
                }
                else
                {
                    Console.WriteLine($"{snum1} * {snum2} = {snum1 * snum2}");
                    break;
                }
            }
        }
        public static void Calkul() // упрощённый калькулятор с двумя числами
        {
            Console.WriteLine("Введи первое число: ");
            int calkulnum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи второе число: ");
            int calkulnum2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи номер операции: \n1. Сложение \n2. Вычитание \n3. Умножение");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Ага! Сложение!");
                    int slozhen = calkulnum1 + calkulnum2;
                    Console.WriteLine($"Итог такой: {calkulnum1} + {calkulnum2} = {slozhen}");
                    break;
                case "2":
                    Console.WriteLine("Так-так, вычитание!");
                    int vichitan = calkulnum1 - calkulnum2;
                    Console.WriteLine($"Итог такой: {calkulnum1} - {calkulnum2} = {vichitan}");
                    break;
                case "3":
                    Console.WriteLine("Вот оно что?! Умножение!");
                    int umnozhen = calkulnum1 * calkulnum2;
                    Console.WriteLine($"Итог такой: {calkulnum1} * {calkulnum2} = {umnozhen}");
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    break;
            }
        }
        public static void Tabum() // таблица умножения
        {
            for (int tabum1 = 1; tabum1 < 10; tabum1++)
            {
                for (int tabum2 = 1; tabum2 < 10; tabum2++)
                {
                    Console.Write($"{tabum2 * tabum1}\t");
                }
                Console.WriteLine();
            }
        }
        public static void Vklad()
        {
            Console.WriteLine("Введи сумму вклада в рублях!");
            Double money = Convert.ToDouble(Console.ReadLine());
            if (money < 10000)
            {
                money += money * 0.05;
            }
            else if (money >= 10000 && money <= 20000)
            {
                money += money * 0.07;
            }
            else
            {
                money += money * 0.1;
            }
            double bonus = 15;
            double sum = money + bonus;
            Console.WriteLine($"По итогам года сумма составит {sum} рублей.");
        }
        static char[] XOarr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }; //подготовка к крестикам-ноликам
        static int XOplayer = 1;
        static int choice;
        static int XOstop = 0;
        static void ConsoleXO()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Игрок №1 - Х, игрок №2 - О. \nВыбери и напиши номер ячейки, на которую хочешь поставить Х или О.\n");
                if (XOplayer % 2 == 0)
                {
                    Console.WriteLine("Ход игрока №2 \n");
                }
                else
                {
                    Console.WriteLine("Ход игрока №1 \n");
                }
                Board();
                choice = int.Parse(Console.ReadLine());
                if (XOarr[choice] != 'X' && XOarr[choice] != 'O')
                {
                    if (XOplayer % 2 == 0)
                    {
                        XOarr[choice] = 'O';
                        XOplayer++;
                    }
                    else
                    {
                        XOarr[choice] = 'X';
                        XOplayer++;
                    }
                }
                else
                {
                    Console.WriteLine("Пардон, клетку {0} уже занял {1}. \nПодожди секунду и выбери другую клетку.", choice, XOarr[choice]);
                    Thread.Sleep(2000);
                }
                XOstop = CheckWin();
            } while (XOstop != 1 && XOstop != -1);
            Console.Clear();
            Board();
            if (XOstop == 1)
            {
                Console.WriteLine("Выиграл игрок №{0}!", (XOplayer % 2) + 1);
            }
            else
            {
                Console.WriteLine("Ничья! Победила дружба :)");
            }
        }
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", XOarr[1], XOarr[2], XOarr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", XOarr[4], XOarr[5], XOarr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", XOarr[7], XOarr[8], XOarr[9]);
            Console.WriteLine("     |     |      ");
        }
        private static int CheckWin()
        {
            if (XOarr[1] == XOarr[2] && XOarr[2] == XOarr[3])
            {
                return 1;
            }
            else if (XOarr[4] == XOarr[5] && XOarr[5] == XOarr[6])
            {
                return 1;
            }
            else if (XOarr[6] == XOarr[7] && XOarr[7] == XOarr[8])
            {
                return 1;
            }
            else if (XOarr[1] == XOarr[4] && XOarr[4] == XOarr[7])
            {
                return 1;
            }
            else if (XOarr[2] == XOarr[5] && XOarr[5] == XOarr[8])
            {
                return 1;
            }
            else if (XOarr[3] == XOarr[6] && XOarr[6] == XOarr[9])
            {
                return 1;
            }
            else if (XOarr[1] == XOarr[5] && XOarr[5] == XOarr[9])
            {
                return 1;
            }
            else if (XOarr[3] == XOarr[5] && XOarr[5] == XOarr[7])
            {
                return 1;
            }
            else if (XOarr[1] != '1' && XOarr[2] != '2' && XOarr[3] != '3' && XOarr[4] != '4' && XOarr[5] != '5' && XOarr[6] != '6' && XOarr[7] != '7' && XOarr[8] != '8' && XOarr[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}

