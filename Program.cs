using System;

namespace Vektor_del_3_skriv_ut_och_jämför
{
    class Program
    {
        static void Main(string[] args)
        {
            const int tal = 11; //försatta talet.
            Console.WriteLine("Hej skriv in 10 tal:"); //utsrkift
            int[] anvandareTal = new int[10]; //vektor med 10 platser

            for (int i = 0; i < anvandareTal.Length; i++)//for loop som kommer köras.
            {
                anvandareTal[i] = Convert.ToInt32(Console.ReadLine());//läser in talen från användaren som läggs in i vektorn.
            }
            foreach (int t in anvandareTal) //  kommer loopa igenom "anvadareTal"
            {
                if (t != tal) // om t är skilt från tal så kommer nedanför skrivas ut annars 
                {
                    Console.Write(t + " ");
                }
                else //annars detta 
                {
                    Console.Write(">" + t + "< "); // visar att det är t eller 11 som är det försatta talet samt skriver ut allt som användare har skrivit i
                }

            }
             
        }
    }
}
