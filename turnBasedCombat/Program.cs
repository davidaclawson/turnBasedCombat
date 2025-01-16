using System;

namespace turnBasedCombat
{
    class Program
    {
        static void Main(string[] args)
        {
            int userHp = 40;
            int enemyHp = 20;

            int userAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5;

            Random random = new Random();

            while(userHp > 0 && enemyHp > 0)
            {
                // user turn
                Console.WriteLine("-- User Turn --");
                Console.WriteLine("User HP: " + userHp + ".     Enemy HP: " + enemyHp + ".");
                Console.WriteLine("Enter 'a' to attack, or 'h' to heal.");
                
                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    enemyHp -= userAttack;
                    Console.WriteLine("User attacks the enemy and deals " + userAttack + " damage!\n"); ;
                }
                else
                {
                    userHp += healAmount;
                    Console.WriteLine("Player restores " + healAmount + " health points!\n");
                  
                }

                // enemy turn
                if(enemyHp > 0)
                {
                    Console.WriteLine("-- Enemy Turn --");
                    Console.WriteLine("User HP: " + userHp + ".     Enemy HP: " + enemyHp + ".");

                    int enemyChoice = random.Next(0, 2);

                    if(enemyChoice == 0)
                    {
                        userHp -= enemyAttack;
                        Console.WriteLine("Enemy attacks and deals " + enemyAttack + " damage!\n");
                        
                    }
                    else
                    {
                        enemyHp += healAmount;
                        Console.WriteLine("Enemy restores " + healAmount + " health points!\n"); ;
                    }
                }
            }

            if(userHp > 0)
            {
                Console.WriteLine("Congratulations, you have defeated the enemy!");
            }
            else
            {
                Console.WriteLine("You have been defeated by the enemy!"); 
            }
        }
    }

}