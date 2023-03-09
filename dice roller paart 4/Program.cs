using System.Threading;
using System.Transactions;

namespace dice_roller_paart_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max, min;
            //random integers2
            Console.WriteLine("Enter a minimum value: ");
            min = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a maximum value: ");
            max = int.Parse(Console.ReadLine());

            if (max < min)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invaild. Max value cannot be smaller than min value");
                Console.ResetColor();
                return;
            }

            Random rnd = new Random();
            Console.WriteLine("Five random values within that range: ");

            for (int i = 0;i < 5; i++)
            {
                Console.Write(rnd.Next(min, max + 1) + "   ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(900);


            //dice roller
            Die die1 = new Die();
            Die die2 = new Die();

            Console.WriteLine("Rolling dice...");
            Thread.Sleep(900);

            int sum = die1.RollDie() + die2.RollDie();
           
            die1.DrawRoll();
            Thread.Sleep(800);
            die2.DrawRoll();

            Thread.Sleep(500);
            Console.WriteLine("You rolled a " + sum);

            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(900);


            //random decimal numbers
            

            Console.WriteLine("Enter a minimum value: ");
            double min1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter a maximum value: ");
            double max1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (max1 < min1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invaild. Max value cannot be smaller than min value");
                Console.ResetColor();
                return;
            }

            Console.WriteLine("Enter a number of decimal places you want (1-15): ");
            int decimals = int.Parse(Console.ReadLine());

            if (decimals < 1 || decimals > 15)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invaild, choose from (1-15).");
                Console.ResetColor();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Three random values within that range: ");
            

            for (int i = 0; i < 3; i++)
            {
                double randomValue = rnd.NextDouble() * (max1 - min1) + min1;
                Console.Write(Math.Round(randomValue, decimals).ToString() + "  ");

            }

        }
    }
}