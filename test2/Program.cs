using System.Xml;
using static System.Formats.Asn1.AsnWriter;

namespace test2
{
    internal class Program
    {



        static void Main(string[] args)
        {

            Console.WriteLine("WELCOME TO GUSS GAME !");
            Console.WriteLine("--------------------------");
            while (true)
            {
                Console.WriteLine("CHOOSE THE LEVEL:");
                Console.WriteLine("1-EASY");
                Console.WriteLine("2-MEDIUM");
                Console.WriteLine("3-HARD");
                Console.WriteLine("4-EXIT");
                Console.WriteLine("--------------------------");


                string UserChoice = Console.ReadLine();
                switch (UserChoice)
                {
                    case "1":
                        EasyGuss();
                        break;
                    case "2":
                        MedGuss();
                        break;
                    case "3":
                        HardyGuss();
                        break;
                    case"4":
                        Console.WriteLine("----------GAME OVER-----------");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("PLEASE, CHOOSE BETWEEN 1:4");
                        Console.WriteLine("--------------------------");
                        break;

                }
            }
            
            

        }
        static void EasyGuss()
        {
            Random rand = new Random();
            int RandNum1 = rand.Next(1, 10);
            for (int i = 3; i>0; i--)
            {
                Console.WriteLine("please,gess a num. between (1:10) ");
                string UserInput = Console.ReadLine();
                int Userinput = Convert.ToInt32(UserInput);


                if (Userinput>RandNum1)
                {
                    Console.WriteLine("num high");
                    int score = (RandNum1/Userinput)*100;
                    Console.WriteLine($"score:{score}% and trial left {i-1} ");
                    Console.WriteLine("--------------------------");

                }
                else if (Userinput<RandNum1)
                {
                    Console.WriteLine("num low");
                    int score = (Userinput/RandNum1)*100;
                    Console.WriteLine($"score:{score}% and trial left {i-1}");
                    Console.WriteLine("--------------------------");


                }
                else
                {
                    Console.WriteLine("CONGRATULATE , U WIN  :) ");
                    Console.WriteLine($" trial left {i-1} and the randam is already {RandNum1}");
                    Console.WriteLine("--------------------------");
                    break;


                }

            }


        }
        static void MedGuss()
        {
            Random rand = new Random();
            int RandNum1 = rand.Next(10, 30);
            for (int i = 3; i>0; i--)
            {
                Console.WriteLine("please,guss a num. between (10:30) ");
                string UserInput = Console.ReadLine();
                int Userinput = Convert.ToInt32(UserInput);

                if (Userinput>RandNum1)
                {
                    Console.WriteLine("num high");
                    int score = (RandNum1/Userinput)*100;
                    Console.WriteLine($"score:{score}% and trial left {i-1} ");
                    Console.WriteLine("--------------------------");

                }
                else if (Userinput<RandNum1)
                {
                    Console.WriteLine("num low");
                    int score = (Userinput/RandNum1)*100;
                    Console.WriteLine($"score:{score}% and trial left {i-1} ");
                    Console.WriteLine("--------------------------");


                }
                else
                {
                    Console.WriteLine("CONGRATULATE , U WIN  :) ");
                    Console.WriteLine($" trial left {i-1} and the randam is already {RandNum1}");
                    Console.WriteLine("--------------------------");
                    break;



                }
            }



        }
        static void HardyGuss()
        {
            Random rand = new Random();
            int RandNum1 = rand.Next(30, 50);
            for (int i = 3; i>0; i--)
            {
                Console.WriteLine("please,guss a num. between (30:50) ");
                string UserInput = Console.ReadLine();
                int Userinput = Convert.ToInt32(UserInput);

                if (Userinput>RandNum1)
                {
                    Console.WriteLine("num high");
                    int score = (RandNum1/Userinput)*100;
                    Console.WriteLine($"score:{score}% and trial left {i-1} ");
                    Console.WriteLine("--------------------------");

                }
                else if (Userinput<RandNum1)
                {
                    Console.WriteLine("num low");
                    int score = (Userinput/RandNum1)*100;
                    Console.WriteLine($"score:{score}% and trial left {i-1} ");
                    Console.WriteLine("--------------------------");


                }
                else
                {
                    Console.WriteLine("CONGRATULATE , U WIN  :) ");
                    Console.WriteLine($" trial left {i-1} and the randam is already {RandNum1}");
                    Console.WriteLine("--------------------------");
                    break;


                }


            }



        }

    }
}
