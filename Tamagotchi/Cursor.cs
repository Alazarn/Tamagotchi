using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Cursor
    {
        public static int cursorX = 18;
        public static int cursorY = 5;
        public static int cursorOldX = 18;
        public static int cursorOldY = 5;
        string cursor = ">>";
        internal void DrawCursor()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.SetCursorPosition(cursorOldX, cursorOldY);
            Console.Write("  ");
            Console.SetCursorPosition(cursorX, cursorY);            
            Console.Write(cursor);            
        }
        internal void CursorPosition(int x, int y)
        {
            cursorX = x;
            cursorY = y;
            DrawCursor();            
        }

        public void MoveCursorUp()
        {
            cursorOldY = cursorY;
            cursorOldX = cursorX;
            cursorY -= 2;

        }
        public void MoveCursorDown()
        {
            cursorOldY = cursorY;
            cursorOldX = cursorX;
            cursorY += 2;
        }
    }
}
