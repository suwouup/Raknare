using System;

namespace räknare
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomerare = new Random();
            int slump_tal = randomerare.Next(100);

            bool vinst = false;
            while (vinst == false)
            {

                int tal;

                Console.WriteLine("gissa ett tal mellan 1 och 100");
                tal = Convert.ToInt32(Console.ReadLine());


                if (tal == slump_tal)
                {
                    vinst = true;
                    Console.WriteLine("talet är rätt");
                }

                else if (tal > slump_tal)
                {
                    Console.WriteLine("talet är för högt");
                }
                else if (tal < slump_tal)
                {
                    Console.WriteLine("talet är för lågt");
                }
            }
        }
    }
}
