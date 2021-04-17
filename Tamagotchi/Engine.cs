using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;



namespace Tamagotchi
{
    class Engine
    {     

        

        IUserInterface userInterface;
        Menu menu = new Menu();
        Cursor cursor = new Cursor();
        IPet pet;        
        
        public Engine(IUserInterface userInterface)
        {
            this.userInterface = userInterface;
        }           

        public void Action()
        {
            pet.Years();

            switch(KeyboardController.PositionCounter)
            {
                case 1:
                    pet.Wuuf();
                    pet.Feed();
                    break;
                case 2:
                    pet.Sleep();
                    pet.SleepEffect();
                    break;
                case 3:
                    pet.Poop();
                    pet.PetToToilet();
                    break;
                case 4:
                    pet.LoveYou();
                    pet.HugPet();
                    break;
                case 5:
                    pet.PlayWithPet();
                    pet.Play();
                    break;
                case 6:
                    KeyboardController.PositionCounter = 1;
                    RunMenu();
                    break;
            }
        }

        public void RunMenu()
        {
            Console.Clear();
            menu.MainMenuItems();            
            while (true)
            {                
                userInterface.MenuController();
                cursor.DrawCursor();

            }
        }

        public void RunSecondMenu()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);  
            
            menu.ChoosePetBar();
            
            while (true)
            {
                userInterface.IntermediateMenuController();
                cursor.DrawCursor();                
            }
        }

        public void Game()
        {           

            if (KeyboardController.PositionCounter == 1)
            {
                pet = new Dog();
            }
            else
            {
                pet = new Hamster();
            }

            pet.Name = menu.Intro();
            Console.Clear();

            Console.SetCursorPosition(0, 1);

            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.Write(pet.PetImage);
            Console.ForegroundColor = ConsoleColor.White;

            pet.StatusBar();
            menu.ActionVariants();
            cursor.CursorPosition(2, 15);
            
            KeyboardController.PositionCounter = 1;

            while (pet.Age != 15)
            {
                pet.StatusBar();
                pet.PetAgeNameBar();
                cursor.DrawCursor();
                userInterface.GameMenuController(); 

                if (pet.Health <= 0)
                    GameOver();
            }

            GameOver();
        }

        public void GameOver()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(0, 0);
            Console.Write(IPet.FinalWords);                       

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(0, 20);

            if (pet.Health <= 0)
                Console.Write("Your Pet got sick and died!\n\n");
            else
                Console.Write("Your Pet has become too old and died!\n\n");            

            Console.Write("Please, press Escape to exit, or Enter to play again.");
            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.Escape)
                Environment.Exit(0);
            else if (key.Key == ConsoleKey.Enter)
                RunSecondMenu();
        }
    }
}
