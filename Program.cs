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
            char[] charArray = random.ToCharArray();
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
            // List<char> checkLet = new List<char>(idRname);
            int letterCkloop = 0;

            string[] newArray = File.ReadAllLines(@"../../TextFile1.txt");
            var newList = newArray.ToList<string>();
            var rng = new Random();
            int randomName = rng.Next(newList.Count);
            string random = newList[randomName];
            //Console.WriteLine(newList[randomName]);
            while (letterCkloop == 0)

            {
                char[] charArray = idRname.ToCharArray();
                string charEntered;
                char letter;
                charEntered = Console.ReadLine();
                letter = charEntered[0];
                
                for (int count = 0; count < idRname.Length; count++) 
                {
                    if (idRname[count] == letter)
                    {
                        charArray[count] = letter;
                    }
                    
                }
                Console.Write(string.Join(" ", letter));
                foreach(char entry in idRname)
                {
                    idRname.Remove(letter);
                }


            }
            Console.WriteLine("Game Over");
        }



    }






}
    // string idRname = RandomName();
    // string replaceLetter = alph.Remove('a');
    //Console.WriteLine($"{replaceLetter}***");
    //Console.WriteLine(string.Join(" ",alph));




    //char newChar = "ABCD".ToList<char>();








