using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class KeyboardController : IUserInterface
    {
        public event EventHandler OnMenuDownButton;
        public event EventHandler OnMenuUpButton;
        public event EventHandler OnMenuEnterButton;
        public event EventHandler OnIntermediateMenuEnterButton;
        public event EventHandler OnGameMenuEnterButton;
        public event EventHandler OnEscapeButton;        

        public static short PositionCounter = 1;

        public void MenuController()
        {
            var pressedKey = Console.ReadKey(true);
            
            switch (pressedKey.Key)
            {
                case ConsoleKey.DownArrow:
                    if (PositionCounter < 2)
                    {
                        OnMenuDownButton?.Invoke(this, new EventArgs());
                        ++PositionCounter;
                    }
                    break;

                case ConsoleKey.UpArrow:
                    if (PositionCounter > 1)
                    { 
                        OnMenuUpButton?.Invoke(this, new EventArgs());                    
                        --PositionCounter;
                    }
                    break;

                case ConsoleKey.Enter:
                    if (PositionCounter == 1)
                        OnMenuEnterButton?.Invoke(this, new EventArgs());
                    else
                        Environment.Exit(0);
                    break;

                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
            }
        }

        public void IntermediateMenuController()
        {
            var pressedKey = Console.ReadKey(true);

            switch (pressedKey.Key)
            {
                case ConsoleKey.DownArrow:
                    if (PositionCounter < 2)
                    {
                        OnMenuDownButton?.Invoke(this, new EventArgs());
                        ++PositionCounter;
                    }
                    break;

                case ConsoleKey.UpArrow:
                    if (PositionCounter > 1)
                    {
                        OnMenuUpButton?.Invoke(this, new EventArgs());
                        --PositionCounter;
                    }
                    break;

                case ConsoleKey.Enter:                    
                    OnIntermediateMenuEnterButton?.Invoke(this, new EventArgs()); 
                    break;                
            }
        }

        public void GameMenuController()
        {
            var pressedKey = Console.ReadKey(true);

            switch (pressedKey.Key)
            {
                case ConsoleKey.DownArrow:
                    if (PositionCounter < 6)
                    {
                        OnMenuDownButton?.Invoke(this, new EventArgs());
                        ++PositionCounter;
                    }
                    break;

                case ConsoleKey.UpArrow:
                    if (PositionCounter > 1)
                    {
                        OnMenuUpButton?.Invoke(this, new EventArgs());
                        --PositionCounter;
                    }
                    break;

                case ConsoleKey.Enter:                    
                    OnGameMenuEnterButton?.Invoke(this, new EventArgs());                    
                    break;                
            }
        }

    }
}
