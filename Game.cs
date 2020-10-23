using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assessment
{
    class Game
    {


        public static Player _currentPlayer = new Player();
        public static bool mainLoop = true;

        public void Start()
        {
            Beginning();
        }

        public void Run()
        {
            Start();
            Battle.FirstEncounter();
            
        }

        

        public void GetPlayerName()
        {
            Console.WriteLine("Landen's Dungeon!");
            Console.WriteLine("Name: ");
            _currentPlayer._name = Console.ReadLine();
            Console.Clear();
        }

        public void Beginning()
        {
            GetPlayerName();

            Console.WriteLine("You awake in a cold stone dark room. You feel dazed and are having trouble remembering");
            Console.WriteLine("anything about your past.");

            if (_currentPlayer._name == "")
            {
                Console.WriteLine("You can't even remember your own name...");
            }
            else
            {
                Console.WriteLine("You know your name is " + _currentPlayer._name);
            }
            Console.WriteLine("press [Enter] to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You grope around in the darkness until you find a door handle. You feel some resistance as");
            Console.WriteLine("you turn the handle, but the rusty lock breaks with little effort. You see your captor");
            Console.WriteLine("standing with his back to you outside the door");
        }





    }






}
