using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {

            int active = 0;

            do
            {


                Console.WriteLine("Vilket programm? A,B, eller C");
                String choice = Console.ReadLine();
                String Change = choice.ToLower();
                switch (Change)
                {


                    case "a":

                        var Cards = new string[52];
                        int i = 0;
                        string color = "";
                        Random value = new Random();
                        

                        foreach(var kort in Cards)
                        {
                            int suit = value.Next(1, 5);
                            int number = value.Next(1, 13);

                            if (suit == 1)
                            {
                            color = "Klöver ";
                            }

                        else if (suit == 2)
                            {
                            color = "Hjärter ";
                            }

                        else if (suit == 3)
                            {
                            color = "Spader ";
                        }
                        else if (suit == 4)
                            {
                            color = "Diamant ";
                        }
                            string done = number + " " + color;
                            string val = number.ToString();
                            string compare = val + color;

                            int i = 0;
                            Console.WriteLine("{i}", kort);
                            //Console.WriteLine("Ditt kort är " + done );
                            i++;

                        }


                        
















                        active = 1;
                break;

                    case "b:":

                        active = 1;
                break;

                    case "c":



                        active = 1;
                break;

                }

            }
            while (active != 0);
        }
            
        }

}
