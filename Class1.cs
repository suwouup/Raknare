using System;

namespace räknare
{
    class Program
    {
        static void Main(string[] args)
        {
            Random siffror = new Random();
            int suwouup_tal = siffror.Next(100);

            bool vinst = false;
            while (vinst == false)
            {

                int tal;

                Console.WriteLine("Gissa ett tal mellan 1 och 100");
                tal = Convert.ToInt32(Console.ReadLine());


                if (tal == suwouup_tal)
                {
                    vinst = true;
                    Console.WriteLine("Talet är rätt");
                }

                else if (tal > suwouup_tal)
                {
                    Console.WriteLine("Talet är för högt");
                }
                else if (tal < suwouup_tal)
                {
                    Console.WriteLine("Talet är för lågt");
                }
            }
        }
    }
}
