using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //programm kuvab kasutaja vanust konsoolist;

            Console.WriteLine("Palun sisesta oma sünniaasta");
            int yearofBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearofBirth;
            //Console.WriteLine("Oled " + userAge + " aastat vana");
            // string iterpolation

            Console.WriteLine($"Oled {userAge} aastat vana");







       
        }
    }
}
