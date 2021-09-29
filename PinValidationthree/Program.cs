using System;

namespace PinValidationthree
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    i = 3;
                }
                else
                {
                    Console.WriteLine("Vale PIN! Proovi uuesti!");
                    i = i + 1;
                }



            }





































        }
    }
}