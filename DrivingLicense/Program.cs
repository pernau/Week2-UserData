using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem kui 18, siis programm kuvab konsoolis
            //"oled liiga noor, et juhiluba saada"
            //kui kasutaja on vanem kui 18, siis programm kuvab konsoolis
            //"oled piisavalt vana, et juhiluba saada";
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne, nüüd sa saad juhiluba taotleda"

            Console.WriteLine("Palun sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhiliba taotleda");
            }
            else if (userAge > 18)
            {
                Console.WriteLine("Palju õnne, nüüd saad juhiluba taotleda.");

            }
            else
            {
                Console.WriteLine("Palju õnne, nüüd saad endale juhiluba taotleda");
            }

            

        }
    }
}
