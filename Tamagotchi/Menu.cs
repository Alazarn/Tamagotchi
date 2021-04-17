using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Menu
    {
        Cursor cursor = new Cursor();
        
        public void MainMenuItems()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(21, 5);
            Console.Write("New Game");
            Console.SetCursorPosition(21, 7);
            Console.Write("Exit");
            cursor.CursorPosition(Cursor.cursorX = 18, Cursor.cursorY = 5);
            
        }

        internal void ChoosePetBar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Please, choose your pet: \n\n");            
            Console.Write("\t  Dog\n\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\t  Hamster (Beta)");            

            cursor.CursorPosition(7, 2);  
        }

        internal string Intro()
        {            
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Please, choose the name for your pet: \n");        
            return Console.ReadLine();        
            
        }

        internal void ActionVariants()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.SetCursorPosition(0, 15);
            Console.WriteLine("      Feed.\n");
            Console.WriteLine("      Sleep.\n");
            Console.WriteLine("      Take it outside.\n");
            Console.WriteLine("      Hug your pet.\n");
            Console.WriteLine("      Play with Pet.\n");
            Console.WriteLine("      Quit to the main menu.");
            
        }




    }
}
