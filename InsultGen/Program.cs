using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsultGen
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Would you like to enter your own insults? (y/n)");
                string answer1 = Console.ReadLine();
                if (answer1 == "y")
                {
                    bool enterInsults = true;
                    while (enterInsults)
                    {
                        Console.WriteLine("Enter an insult (No words ending in 'ing'):");
                        string word = Console.ReadLine();

                        using (System.IO.StreamWriter file =
                            new System.IO.StreamWriter(@"C:\Users\computing\Documents\InsultGen\InsultGen\end.txt", true))
                        {
                            file.Write(" ");
                            file.WriteLine(word);
                        }
                        
                        Console.WriteLine("Enter another? ()y/n):");
                        string answer2 = Console.ReadLine();
                        if (answer2 == "y")
                        {
                            enterInsults = true;
                        }
                        else
                        {
                            enterInsults = false;
                        }
                    }
                }
            bool start = true;
            while (start)
            {
                
                string[] starter = System.IO.File.ReadAllLines(@"C:\Users\computing\Documents\InsultGen\InsultGen\starter.txt");
                //string[] starter = { "you are a", "your a", "at least im not a","your mums a","your grans a" };
                string[] middle = System.IO.File.ReadAllLines(@"C:\Users\computing\Documents\InsultGen\InsultGen\middle.txt");
                //string[] middle = new string[] { " smelly", " stupid", " silly", "n annoying", " boring", " poopy", " un-smart"," no-good"," evil"," minging"," stinky" };
                string[] end = System.IO.File.ReadAllLines(@"C:\Users\computing\Documents\InsultGen\InsultGen\end.txt");
                //string[] end = new string[] { " doody-head", " butt", " mongoose", " donkey", " weenie", " four eyes", " face"," crab"," mole"," worm"," baby", " breath"," dingus"," sixth-former"};
                


                Random rand = new Random();

                Console.ForegroundColor = (ConsoleColor)rand.Next(0, 16);
                string one = starter[rand.Next(starter.Length)];
                string two = middle[rand.Next(middle.Length)];
                string three = end[rand.Next(end.Length)];
                Console.Write(one + two + three);
                Console.ResetColor();
                Console.WriteLine();
                
                Console.ReadLine();
            }
            

            

            
            
        }
    }
}
