namespace Igra2
{
    internal class Program
    {
        static void Main()
        {

            Actions();
        }
        static void UgadaiChislo()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 100);
            Console.WriteLine("Попробуй угадай: ");
            while (true)
            {
                int gnumber = Convert.ToInt32(Console.ReadLine());
                if (gnumber < number)
                {
                    Console.WriteLine("Больше! ");
                }
                else if (gnumber > number)
                {
                    Console.WriteLine("Меньше!! ");
                }
                else if (gnumber == number)
                {
                    Console.WriteLine("Красаваааа!!!");
                    break;
                }

            }
        }
        static void umnojenietab()
        {
            string[,] mtab = new string[10, 10];

            for (int chis1 = 1; chis1 < 10; chis1++)
            {
                for (int chis2 = 1; chis2 < 10; chis2++)
                {
                    Console.Write(chis1 * chis2 + "\t");
                }

                Console.WriteLine();
            }
        }
        static void Delitel()
        {
            int dnum = Convert.ToInt32(Console.ReadLine());
            int xod = 0;
            while (xod <= dnum)
            {
                xod++;
                if (dnum % xod == 0)
                    Console.Write(xod + "\t");

            }
            Console.WriteLine();
        }

        static void Actions()
        {
            while (true)
            {
                Console.WriteLine("1) Игра угадай число");
                Console.WriteLine("2) Таблица умножения");
                Console.WriteLine("3) Найти делители числа");
                Console.WriteLine("4) Выйти из программы");
                Console.WriteLine("Введите действие: ");
                int action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                {
                    UgadaiChislo();
                }
                else if (action == 2)
                {
                    umnojenietab();
                }
                else if (action == 3)
                {
                    Console.WriteLine("Введите число: ");
                    Delitel();
                }
                else if (action == 4)
                {
                    break;
                }
            }

        }
    }
}