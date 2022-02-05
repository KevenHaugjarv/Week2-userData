using System;

namespace Driving_license
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //kui kasutaja on noorem, kui 18, siis kuvab konsoolis
            // "oled liiga noor, et juhilube saada";
            //Kui kasutaja on vanem, kui 18, siis programm kuvab konsoolis
            //"oled piisavalt vana, et juhilube saada";
            // kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne nüüd sa saad ka juhilube taotleda";

            Console.WriteLine("Palun sisesta oma sünniaasta!");
            int yearofBirth = Convert.ToInt32(Console.ReadLine());
            int userAge = 2022 - yearofBirth;
            Console.WriteLine($"Oled {userAge} aastat vana");

            if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhiluba saada");

            }
            else if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada");
            }
            else
            {
                Console.WriteLine("Palju õnne nüüd sa saad ka juhilube taotleda");
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
