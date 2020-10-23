using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assessment
{
    public class Battle
    {
        


        static Random rand = new Random();
        //Encounter Generic


        //Encounters
        public static void FirstEncounter()
        {
            Console.WriteLine("You throw open the door and grab a rusty metal sword, while charging toward your captor");
            Console.WriteLine("He turns...");
            Console.WriteLine(" ");
            Console.WriteLine("press [Enter] to continue.");
            Console.ReadKey();
            Combat(false, GetName(), 1, 10);
        }

        

        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;

            if (random)
            {
                n = GetName();
                p = rand.Next(1, 5);
                h = rand.Next(1, 8);
            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while (h >= 0)
            {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine("Attack Power: " + p + "/" + "Health: " + h);
                Console.WriteLine("----------------------");
                Console.WriteLine("- (A)ttack  (D)efend -");
                Console.WriteLine("- (E)vade   (H)eal   -");
                Console.WriteLine("----------------------");
                Console.WriteLine(" Health: " + Game._currentPlayer._health);
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //Attack
                    Console.WriteLine("You strike the " + n + ", but he strikes you back immediately afterwards.");
                    int damage = p - Game._currentPlayer._armorValue;
                    //doesn't let damage go below negative
                    if (damage < 0)
                    {
                        damage = 0;
                    }
                    //decides a random number of damage based 
                    int attack = rand.Next(0, Game._currentPlayer._weaponValue) + rand.Next(1, 4);
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage");
                    Game._currentPlayer._health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //Defend
                    Console.WriteLine("The " + n + " attempts to strike you, but you defended it.");
                    int damage = (p / 10) - Game._currentPlayer._armorValue;
                    if (damage < 0)
                    {
                        damage = 0;
                    }
                    int attack = rand.Next(0, Game._currentPlayer._weaponValue) / 2;
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage.");
                    Game._currentPlayer._health -= damage;
                    h -= attack;

                }
                else if (input.ToLower() == "e" || input.ToLower() == "evade")
                {
                    //Evade
                    if (rand.Next(0, 2) == 0)
                    {
                        int damage = p - Game._currentPlayer._armorValue;
                        
                        Console.WriteLine("You try to evade the " + n + "'s attack.");
                        if (damage < 0)
                        {
                            damage = 0;
                        }
                        Console.WriteLine("You fail and lose " + damage + " health.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You successfully evade the attack from the " +  n  + " and take no damage.");
                        Console.ReadKey();
                    }

                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //Heal
                    if (Game._currentPlayer._heal == 0)
                    {


                        Console.WriteLine("You reach for a potion in your bag but have none");
                        int damage = p - Game._currentPlayer._armorValue;
                        damage = 0;
                        Console.WriteLine("The " + n + " strikes you and you lose " + damage + " health!");
                    }
                    else
                    {
                        Console.WriteLine("You manage to find a spare potion in your bag");
                        int healV = 5;
                        Console.WriteLine("You gain " + healV + " health");
                        Game._currentPlayer._health += healV;
                        Console.WriteLine("As you were occupied the " + " attacked you!");
                        int damage = (p / 2) - Game._currentPlayer._armorValue;
                        if (damage < 0)
                        {
                            damage = 0;
                        }
                        Console.WriteLine("You lose " + damage + " health!");
                    }
                    Console.ReadKey();


                }

                if(Game._currentPlayer._health <= 0)
                {
                    //Death code
                    Console.WriteLine("[ Y O U  D I E D ! ]");
                    Console.WriteLine("press [Enter] to continue.");
                    Console.ReadKey();
                    
                }
                Console.ReadKey();
            }
            //Displays win message and ends game
            Console.WriteLine("You have DEFEATED the " + n + ", Congratulations");
            Console.WriteLine("[  Y O U  W I N  ]");
            Console.WriteLine("press [Enter] to end game");
            Console.ReadKey();

        }

        public static string GetName()
        {
            switch (rand.Next(0, 4))
            {
                case 0:
                    return "Skeleton";
                case 1:
                    return "Zombie";
                case 2:
                    return "Dweller";
                case 3:
                    return "Corrupt Mage";
            }
            return "Human Rogue";
        }

    }
}
