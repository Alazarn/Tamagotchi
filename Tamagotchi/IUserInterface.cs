using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public interface IUserInterface
    {
        event EventHandler OnMenuDownButton;
        event EventHandler OnMenuUpButton;
        event EventHandler OnMenuEnterButton;
        event EventHandler OnEscapeButton;
        event EventHandler OnIntermediateMenuEnterButton;
        event EventHandler OnGameMenuEnterButton;
        

        void MenuController();

        void IntermediateMenuController();

        void GameMenuController();
    }
}
