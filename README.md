# HelloWorld
 
| Landen Guilbeau|
| :---              |
| s208060     |
| Text Based Adventure Game Read Me |

## How To Play:
Requires a keyboard.

### Controls:
User will be promted with a custom UI that shows:
(A)ttack
(D)efend
(H)eal
(E)vade

Must press [Enter] after selecting what action you want to take.


### Abilities:

User has the ability to attack, defend, heal, and evade an enemy that they encounter. 

### Note to Lodis and/or Van:

I researched ways to create and implemept random variables in a battle loop, for example
        
------------------------------------------
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
 -----------------------------------------
This is a function that sets names to numbers, then it gets a random number (0-3)
and whatever number it selects that corresponds with the name it was given, is
set as the name for that enemy and will change everytime you play.

I've also learned a new way to receive player input.

----------------------------------------------------------------------------------------------------------------------------
    if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //Attack
                    Console.WriteLine("You strike the " + n + ", but he strikes you back immediately afterwards.");
                    int damage = p - Game._currentPlayer._armorValue;
                    if (damage < 0)
                    {
                        damage = 0;
                    }
                    int attack = rand.Next(0, Game._currentPlayer._weaponValue) + rand.Next(1, 4);
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage");
                    Game._currentPlayer._health -= damage;
                    h -= attack;
                }
---------------------------------------------------------------------------------------------------------------------------

this "if" statment reads the input, ("a"), and the player does a random number of damage to enemy between arrays of 1-4 (0-3).

These were the only implementations that required assisstance, the rest of the game and game logic were created by me.