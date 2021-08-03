using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DiceRoll

    {
        public void Test()
        {
            int max = 6;
            int min = 1;
            Random dice = new Random();
            int dice1 = dice.Next(max - min + 1) + min;
            int dice2 = dice.Next(max - min + 1) + min;
            int dice3 = dice.Next(max - min + 1) + min;
            int total = dice1 + dice2 + dice3;

            Console.WriteLine($"Dice roll: {dice1} + {dice2} + {dice3} = {total}");

            if (dice1 == dice2 || dice2 == dice3 || dice1 == dice3)
            {
                if (dice1 == dice2 && dice2 == dice3)
                {
                    Console.WriteLine("you rolled treeples! +3 bonus");
                    total += 3;
                }
                else
                {
                    Console.WriteLine("you rolled doubles! +2 bonus");
                    total += 2;
                }

            }

            if (total >= 16)
            {
                Console.WriteLine("You win! a new car ");
            }
            else if (total >= 10)
            {
                Console.WriteLine("You win a new laptop");
            }
            else if (total == 7)
            {
                Console.WriteLine("You win a trip");
            }
            else
            {
                Console.WriteLine("You win a kitten, gerrarahia");
            }
        }
    }
}
