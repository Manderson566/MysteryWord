using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysteryWord
{
    class Program
    {
        static string RandomName()
        {
            string[] newArray = File.ReadAllLines(@"../../TextFile1.txt");
            var newList = newArray.ToList<string>();
            var rng = new Random();
            int randomName = rng.Next(newList.Count);
            string random = newList[randomName];
            //Console.WriteLine(newList[randomName]);
            return random;

        }

        static void Main(string[] args)
        {


            string idRname = RandomName();
            int counter = 0;
            Console.WriteLine(idRname);
            foreach (char place in idRname)
            {
                Console.Write("_ ");
                counter++;

            }
            List<char> checkLet = new List<char>(idRname);
            //string guessLet = new string(idrname)
            string letter = Console.ReadLine();
            for (int i = 0; i < idRname.Count(); i++)
            {

                if (letter == idRname.ToString())
                {
                    Console.WriteLine("correct");
                }
            }



        }






    }
    // string idRname = RandomName();
    // string replaceLetter = alph.Remove('a');
    //Console.WriteLine($"{replaceLetter}***");
    //Console.WriteLine(string.Join(" ",alph));




    //char newChar = "ABCD".ToList<char>();


}





