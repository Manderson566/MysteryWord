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
        static string RandomList()
        {
            string[] newArray = File.ReadAllLines(@"../../TextFile1.txt");
            var newList = newArray.ToList<string>();
            var rng = new Random();
            int randomNumber = rng.Next(newList.Count);
            string random = newList[randomNumber];
            Console.WriteLine(newList[randomNumber]);
            Console.WriteLine(rng.Next(100, 400));
            return random;

        }
    
        static void Main(string[] args)
        {
            //"ABCDEF".ToList<char>();
            string[] newArray = File.ReadAllLines(@"../../TextFile1.txt");
             var newList = newArray.ToList<string>();
            Console.WriteLine(string.Join(" ", newList.GetRange(1, 5)));
            Console.ReadLine();
            {
                RandomList();
            }
        }

       
        
    }
}
