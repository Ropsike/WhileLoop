using System;

namespace LoopActive
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;

            while(i < 3)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    i = i + 1;
                }

                else
                {
                    Console.WriteLine("Vale PIN! Proovi uuesti!");

                }



            }





































        }
    }
}
