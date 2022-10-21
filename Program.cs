using System;
 
namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game, Press enter to start");
            Console.ReadKey();
            Console.WriteLine("Input name for your wizard");
            string wizName;
            wizName = Console.ReadLine();
            Console.WriteLine("This is " + wizName + "'s stats");
            Random numberGen = new Random();
 
            int health = numberGen.Next(50, 100);
            int stamina = numberGen.Next(5, 10);
            int power = numberGen.Next(10, 15);
            int smart = numberGen.Next(0, 100);
 
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Stamina: " + stamina);
            Console.WriteLine("Power: " + power);
            Console.WriteLine("Smarts: " + smart);
 
           string[] spell1 = { "Light Beam", "Air Blast" };
            string[] spell2 = { "Wild Fire", "Quake" };
            string[] spell3 = { "Krakatoa", "Tsunami" };

           
 
            if (smart <= 33) {
                Console.WriteLine("They have " + spell1[0] + " and " + spell1[1] + " as spells");
                string moveset = spell1[0];
                string moveset2 = spell1[1];
            }
            else if (smart >= 34 && smart <= 67) {
                Console.WriteLine("They have " + spell2[0] + " and " + spell2[1] + " as spells");
                string moveset = spell2[0];
                string moveset2 = spell2[1];
            }
            else {
                Console.WriteLine("They have " + spell3[0] + " and " + spell3[1] + " as spells");
                string moveset = spell3[0];
                string moveset2 = spell3[1];
                }
 
            Console.ReadKey();
            Console.WriteLine("Now, you have to fight the evil wizard, voldimore, here are his stats");
            Random numberGenV = new Random();
 
            int healthV = numberGenV.Next(50, 100);
            int staminaV = numberGenV.Next(5, 10);
            int powerV = numberGenV.Next(10, 15);
            int smartV = numberGenV.Next(0, 100);
 
            Console.WriteLine("Health: " + healthV);
            Console.WriteLine("Stamina: " + staminaV);
            Console.WriteLine("Power: " + powerV);
            Console.WriteLine("Smarts: " + smartV);
 
            string[] spellV1 = { "Light Beam", "Air Blast" };
            string[] spellV2 = { "Wild Fire", "Quake" };
            string[] spellV3 = { "Krakatoa", "Tsunami" };

        
 
            if (smart <= 33)
            {
                Console.WriteLine("They have " + spellV1[0] + " and " + spellV1[1] + " as spells");
                string movesetv = spellV1[0];
                string moveset2v = spellV1[1];
            }
            else if (smart >= 34 && smart <= 67)
            {
                Console.WriteLine("They have " + spellV2[0] + " and " + spellV2[1] + " as spells");
                string movesetv = spellV2[0];
                string moveset2v = spellV2[1];
            }
            if (smart >= 68 && smart <= 100)
            {
                Console.WriteLine("They have " + spellV3[0] + " and " + spellV3[1] + " as spells");
                string movesetv = spellV3[0];
                string moveset2v = spellV3[1];
            }
 
            Console.ReadKey();
            Console.WriteLine("Time to learn the basics");
            Console.ReadKey();
            Console.WriteLine("You can either attck with a spell, which decreases your enemies health and your stamina by 1, or meditate, which incrases your stamina. Also, the more power you have, the more dmaage you do. Laslty, the higher smarts you have, the more powerful spells you can use");
            Console.ReadKey();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Lets Fight!");

            int moveN;

 
            while (health >= 1 && healthV >= 1)
            {
                Console.WriteLine("Your Turn");
                Console.WriteLine("1 to attack, 2 to meditate, 3 to heal");
                moveN = Convert.ToInt32(Console.ReadLine());
                if (moveN == 1) {
                    Console.WriteLine("1 to use " + )

                }
                else if (moveN == 2) {

                }
                if (moveN == 3) {

                }
                
                

                
                
 
 
 
            }
            
 
 
 
 
 
 
 
        }
        
    }
}
 
 
 
 
 
