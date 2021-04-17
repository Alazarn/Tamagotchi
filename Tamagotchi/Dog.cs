using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tamagotchi
{
    class Dog : Pet, IPet
    {
        public override string PetImage { get; } = @"
             _ 
        /\,_/\| 
        /==_ ( 
       (Y_.) /       /// 
        U ) (__,_____) ) 
          )'   >     `/ 
          |._  _____  | 
          | | (    \| ( 
          | | |    || | 
          ),)_/    ))_/";

        public override string Name { get; set; }
        public override int Age { get; set; }

        private int yearsCounter;

        public override void Years()                   
        {
            yearsCounter++;
            if (yearsCounter % 2 == 0)
                Age++;           
        }


        public override void Poop()
        {
            Console.SetCursorPosition(24, 7);            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            int temp = 25;
            for (int i = 7; i < 12; i++)
            {
                for (int j = 24; j <= temp; j++)
                {
                    Console.SetCursorPosition(j, i);
                    if (j == temp)
                    {                                                
                        Console.Write("#");
                        Thread.Sleep(400);
                        Console.SetCursorPosition(j, i);
                        Console.Write(" ");
                    }
                    else if (i == 11 && j == temp - 2)
                    {                        
                        Console.Write("###");
                        Thread.Sleep(3000);
                        Console.SetCursorPosition(j, i);
                        Console.Write("     ");
                        break;
                    }
                }
                temp += 1;
            }
        }

        public override void Wuuf()
        {
            Console.SetCursorPosition(1, 7);            
            Console.Write("Woof-Woof");

            Thread.Sleep(1500);

            Console.SetCursorPosition(1, 7);
            Console.Write("         ");
        }

        public override void LoveYou()
        {
            Console.SetCursorPosition(1, 7);            
            Console.Write("Love you!");

            Thread.Sleep(1500);

            Console.SetCursorPosition(1, 7);
            Console.Write("         ");
        }

        public override void SleepEffect()
        {
            int temp = 15;
            for (int i = 4; i >= 1; i--)
            {                
                for (int j = 15; j < 21; j++)
                {                    
                    Console.SetCursorPosition(j, i);

                    if (j == temp)
                        Console.Write("Z");

                    Thread.Sleep(90);
                }
                temp += 2;
            }
            temp = 15;
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 15; j < 21; j++)
                {
                    Console.SetCursorPosition(j, i);

                    if (j == temp)
                        Console.Write(" ");                    
                }
                temp += 2;
            }
        }

        public override void Play()
        {
            Console.SetCursorPosition(1, 7);
            Console.Write("So much fun!");

            Thread.Sleep(1500);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(1, 7);
            Console.Write("         )' ");
        }
    }    
}
