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
            double min1, max1, decimals;

            Console.WriteLine("Enter a minimum value: ");
            min1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a maximum value: ");
            max1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number of decimal places you want: ");
            decimals = double.Parse(Console.ReadLine());

            Console.WriteLine("Three random values within that range: ");

            for (int i = 0; i < 3; i++)
            {
                Console.Write((rnd.NextDouble()* (max - min) + min).ToString("0.0") + "   ");

             
            }

        }
    }
}