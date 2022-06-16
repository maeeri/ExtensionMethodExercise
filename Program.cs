using System;
using System.Threading;

namespace Game
{
    public class Raffle
    {
        public bool victory;

        // display welcome message
        public void Welcome()
        {
            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("Welcome to the lotto game\n");
        }

        // show dots while raffling
        static void ShowDots()
        {
            int i = 0;
            while (i < 3)
            {
                Console.Write(".");
                Thread.Sleep(1000);
                i++;
            }
            Console.WriteLine("\n\n");
        }

        void GetResult()
        {
            var rand = new Random();
            if (rand.Next(100) > 70)
            {
                this.victory = true;
            }
            else
            {
                this.victory = false;
            }
        }

        // play the game
        public void Play()
        {
            Console.WriteLine("Press any key to play\n");
            Console.ReadKey(true);
            Console.Write("Raffling ");
            ShowDots();
            GetResult();
        }
    }


    class Exercise
    {
        static void Main(string[] args)
        {

            //Raffle lotto = new Raffle();

            //lotto.Welcome();
            //lotto.Play();
            

            //if (lotto.victory)
            //{
            //    Console.WriteLine(" Congratulations! You won! \n");
            //}
            //else
            //{
            //    Console.WriteLine(" You lost :( \n");
            //}

            //lotto.victory.Prize();

            //Console.WriteLine("*********************************");

            Console.WriteLine("Give a number 1-10");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            var rand2 = new Random();
            var randNumber = rand2.Next(10);

            if (userNumber.Winner(randNumber))
                Console.WriteLine("Yay! You won!!!!");
            else
                Console.WriteLine("Sorry, you lost :(");

            //Console.WriteLine(userNumber + " " + randNumber);
        }
    }

    public static class Extensions
    {
        public static void Prize(this bool b)
        {
            if (b == true)
            {
                Console.WriteLine("Yay! ~~~ *** You won a million euros!!! *** ~~~~");
            }
        }

        public static bool Winner(this int i, int j)
        {
            bool b = (i == j) ? true : false;
            return b;
        }
    }

}