using System;


namespace Tamagotchi
{
    class ProgramExecuter
    {    
        static void Main(string[] args)
        {    
            IUserInterface keyboard = new KeyboardController();
            Engine engine = new Engine(keyboard);
            Cursor cursor = new Cursor();          
            
            keyboard.OnMenuDownButton += (sender, eventInfo) => { cursor.MoveCursorDown(); };

            keyboard.OnMenuUpButton += (sender, eventInfo) => { cursor.MoveCursorUp(); };

            keyboard.OnMenuEnterButton += (sender, eventInfo) => { engine.RunSecondMenu(); };

            keyboard.OnIntermediateMenuEnterButton += (sender, eventInfo) => { engine.Game(); };

            keyboard.OnGameMenuEnterButton += (sender, eventInfo) => { engine.Action(); };



            Console.CursorVisible = false;
            engine.RunMenu();
            

        }
    }
}
