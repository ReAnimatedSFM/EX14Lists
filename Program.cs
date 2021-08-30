using System;
using System.Collections.Generic;

namespace EX14Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            /* OPGAVE 1 - 3
            //Ages List
            List<int> ages = new List<int>();
            //Ages værdier
            ages.Add(5);
            ages.Add(17);
            ages.Add(20);
            ages.Add(40);
            ages.Add(51);
            //Names List
            List<string> names = new List<string>();
            //Names Værdier
            names.Add("Karl");
            names.Add("Johannes");
            names.Add("Anton");
            names.Add("Nicklas");
            //List percentages (Fulde kald)
            List<double> percentages = new List<double> { 0.75, 0.23, 0.86, 0.17 };
            //True/false areMarried Liste
            List<bool> areMarried = new List<bool>{true, false, false, true, true};

            int i = 0;
            int p = 0;
            foreach (int value in ages)
            {
                Console.WriteLine(ages[i]);
                i++;
            }
            Console.WriteLine();
            foreach (string item in names)
            {
                Console.WriteLine(names[p]);
                p++;
            }
            */


            //--------------------------------------------------------------------------------------------------------------------------


            /*OPGAVE 4
            int y = 0;

            //Navne liste
            List<string> namesAlt = new List<string> {"Hans", "Kristian", "Jens", "Karsten", "Ib" };

            Console.Write("Udskrivning af følgende navne: ");

            foreach (string item in namesAlt)
            {
                Console.Write(namesAlt[y] + ", ");
                y++;
            }
            Console.WriteLine();
            Console.Write($"\nIndtast et navn du ville tilføje til listen: ");
            string namesInput = Console.ReadLine();
            namesAlt.Insert(3, "Anders");
            namesAlt.Insert(2, "Lars");
            namesAlt.Insert(namesAlt.Count, namesInput);
            Console.Clear();
            int k = 0;
            foreach (string item in namesAlt)
            {
                Console.Write(namesAlt[k] + ", ");         //Hans, Kristian, Lars, Anders, Jens, Karsten, Ib, NameInput (Forkert)
                k++;
            } */


            //------------------------------------------------------------------------------------------------------------------------


            //OPGAVE 5
            int z = 0;

            List<int> alder = new List<int> { 13, 14, 13, 15, 13, 14, 14, 15 };
            alder.Remove(13);
            alder.Remove(15);
            alder.RemoveAt(3);

            foreach (int item in alder)
            {
                Console.WriteLine(alder[z]);
                z++;
            }

            Console.ReadKey();
            
        }
    }
}
