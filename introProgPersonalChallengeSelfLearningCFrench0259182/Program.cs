using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introProgPersonalChallengeSelfLearningCFrench0259182
{

    //code by written by  Chris French 0259812
    //references used:
    //https://www.youtube.com/watch?v=hpaH6eoKKcI&list=PLdYuBFQaeYTs460QSUVj11nPQslGyzeMX
    //https://www.youtube.com/watch?v=N1YxtK2YrAw


    internal class Program
    {
        //fist = 0
        //pistol = 1
        //RocketLauncher = 2
        //sniperRifle = 3

        //Static variable array
        static int weapon = 0;        // Weapon selected
        static int enemyHealth = 100;  // Enemy health
        static int health = 100;   // Player Health
        static int fistDmg = 5;     // Fist damage
        static int pisDmg = 15;   //Pistol damage
        static int rlDmg = 100;    //Rocket Launcher damage
        static int snpDmg = 50;    //Sniper Rifle damage
        static string Character; // initalizes  variable
        static string wepType = "big stick"; // initalizes  variable
        static string hStat = "Catch Phrase!";
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("What is your character's name");
            Console.ForegroundColor = ConsoleColor.Blue;
            Character = Console.ReadLine();

            Console.Clear();

            name();//  call to method

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            /*
                        if (IsAlive())
                        {
                            Console.WriteLine($"Your Health is {health} you  are alive. ");
                        }
                        else 
                        {
                            Console.WriteLine($"Your health is {health} you are dead. " + "\n");
                        }

                        Console.ReadKey(true);
            */
            //method activators  for reference
            //combatdmg();
            //IsAlive();
            //name();
            //weaponSelector();
            //HUD();
            //LifeStat();
            //statsBlock();


            HUD();
            /* statsBlock();
             LifeStat();*/
            weaponSelector();
            combatdmg();

            bool isEnemyDead = false; //  check to see if enemy is dead

            while (!isEnemyDead)   //while enemy is  not dead this will continue player attack in loop
            {
                if (enemyHealth > 0)
                {
                    Console.WriteLine($"Your enemy yet lives, your task is not yet complete. " + "\n " + "\n ");
                    weaponSelector();
                    combatdmg();
                }
                else 
                {
                    Console.WriteLine("you have slain your enemy. You can rest easy until your next inevitable combat." + "\n");
                    weapon = 0;  //modify weapon value based on user input  to  weaponSelect.
                    break; // breaks the  loop

                }
                
            }




























            Console.ForegroundColor = ConsoleColor.White;
        }
        //Methods below here
/*
        //method 1
        static bool IsAlive()

        {
            if (health > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
*/
        //method 2

        static void combatdmg()
        {
            switch (weapon)
            {
                case 0:
                    Console.WriteLine($"You Fist the enemy for {fistDmg} damage. ");
                    DealDamageToEnemy(5);

                    break;

                case 1:
                    Console.WriteLine($"You shoot the enemy for {pisDmg} damage. ");
                    DealDamageToEnemy(15);

                    break;

                case 2:
                    Console.WriteLine($"You explodinate the enemy for {rlDmg} damage. ");
                    DealDamageToEnemy(100);
                    weapon = 0;
                    break;

                case 3:
                    Console.WriteLine($"You snipe the enemy for {snpDmg} damage. ");
                    DealDamageToEnemy(50);
                    break;

                default:
                    Console.WriteLine("Weapon was not packed in you kit. Please choose again.");

                    break;

            }
            
        }


        //method 3

        static void DealDamageToEnemy(int amount)
        {
            Console.WriteLine($"Enemy Health was {enemyHealth} they took {amount} damage...");

            enemyHealth -= amount;

            Console.WriteLine($"enemy health now {enemyHealth}. " +"\n");
        }


        //method 4

        static void name()
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Name : ");
            Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine($"{Character}" + "\n");

        }



        //method 5

        static void weaponSelector()
        {
            Console.WriteLine(" Please choose a weapon: 0 = Fist, 1 = Pistol, 2 = Rocket Launcher, 3 = Sniper Rifle" + "\n");

            string weaponSelect = Console.ReadLine(); //store  weapon  selection

            if (weaponSelect == "0")
            {
                Console.WriteLine("You choose to attack your enemy with your Bare Hands. " + "\n");
                weapon = 0;  //modify weapon value based on user input  to  weaponSelect.
                wepType = "Fist";  // modify weapon description in stats 
            }
            else if (weaponSelect == "1")
            {
                Console.WriteLine("You choose to attack your enemy with your trusty Pistol. " + "\n");
                weapon = 1;  //modify weapon value based on user input  to  weaponSelect.
                wepType = "Pistol";  // modify weapon description in stats
            }
            else if (weaponSelect == "2")
            {
                Console.WriteLine("You choose to attack your enemy with a FRIKKIN Rocket Launcher... Overkill much? " + "\n");
                weapon = 2;  //modify weapon value based on user input  to  weaponSelect.
                wepType = "Rocket Launcher";  // modify weapon description in stats
            }
            else if (weaponSelect == "3")
            {
                Console.WriteLine("You choose to attack your enemy with a sleek andd stylish Sniper Rifle. Woot Headshot! " + "\n");
                weapon = 3;  //modify weapon value based on user input  to  weaponSelect.
                wepType = "Sniper Rifle";  // modify weapon description in stats
            }
            else
            {
                Console.WriteLine("You  did not have room totake that weapon with you it is at home in your footlocker." + "\n");
                weapon = 0;  //modify weapon value based on user input  to  weaponSelect.
                wepType = "Fist";  // modify weapon description in stats
            }
        }


        //method 6
       static void statsBlock()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("{0,0}{1,15}{2,12}", "life", "condition", "weapon");

            Console.Write("{0,2}", health );
            Console.Write("{0,17}", hStat );
            Console.WriteLine("{0,15}", wepType + "\n");

            //Console.WriteLine("{0,2}{1,13}{2,14}", health, hStat, wepType + "\n");
        }
      
        
        //method 7
        
       static void LifeStat()
         
        {
            if (health == 100) 
            {
                hStat = "Fit as a fiddle";
             }
            else if (health > 75)
            {
                hStat = "Healthy as a horse";
            }
            else if (health > 50)
            {
                hStat = "Feeling fine";
            }
            else if (health > 25)
            {
                hStat = "Little winded";
            }
            else if (health > 10)
            {
                hStat = "Just a flesh wound";
            }
            else if (health <= 0)
            {
                hStat = "Dead as a doornail";
            }

        }



        //method 8
        static void HUD()
        {

            statsBlock();
            LifeStat();
        }
       


        //Methods above here
    }
}
