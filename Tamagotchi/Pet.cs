using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Tamagotchi
{
    abstract class Pet : IPet
    {    
        private protected int health = 80;
        private protected int hunger = 60;
        private protected int need = 20;
        private protected int energy = 50;
        private protected int sleepiness = 20;
        private protected int happiness = 50;

        #region Properies
        public abstract string Name { get; set; }

        public abstract string PetImage { get; }

        public abstract int Age { get; set; }    

        public int Health
        {
            get { return health; }

            set
            {
                health = value;
                if (health < 0)
                {
                    health = 0;
                }
                if (health > 100)
                {
                    health = 100;
                }
            }
        }

        public int Hunger
        {
            get { return this.hunger; }

            set
            {
                this.hunger = value;
                if (this.hunger < 0)
                {
                    this.hunger = 0;
                }
                if (this.hunger > 100)
                {
                    this.hunger = 100;
                }
            }
        }

        public int Need
        {
            get { return this.need; }

            set
            {
                this.need = value;
                if (this.need < 0)
                {
                    this.need = 0;
                }
                if (this.need > 100)
                {
                    this.need = 100;
                }
            }
        }

        public int Energy
        {
            get { return energy; }

            set
            {
                energy = value;
                if (energy < 0)
                {
                    energy = 0;
                }
                if (energy > 100)
                {
                    energy = 100;
                }
            }
        }

        public int Sleepiness
        {
            get { return sleepiness; }

            set
            {
                sleepiness = value;
                if (sleepiness < 0)
                {
                    sleepiness = 0;
                }
                if (sleepiness > 100)
                {
                    sleepiness = 100;
                }
            }
        }

        public int Happiness
        {
            get { return happiness; }

            set
            {
                happiness = value;
                if (happiness < 0)
                {
                    happiness = 0;
                }
                if (happiness > 100)
                {
                    happiness = 100;
                }
            }
        }
        #endregion         
        
        public  void Feed()
        {
            Hunger -= 50;
            Need += 30;
            Energy += 40;
            Sleepiness += 20;
            Health += 10;

            HealthController();
        }

        public void PlayWithPet()
        {
            Happiness += 30;
            Sleepiness += 20;
            Hunger += 30;
            Need += 10;
            Energy -= 60;

            HealthController();
        }

        public void HugPet()
        {
            Happiness += 10;
            Need += 10;
            Hunger += 10;
            Sleepiness += 20;
            Energy -= 10;

            HealthController();
        }

        public void PetToToilet()
        {
            Need -= 60;
            Hunger += 20;            
            Sleepiness += 10;
            
            HealthController();
        }

        public void Sleep() 
        {
            Sleepiness -= 100;
            Hunger += 20;
            Happiness += 10;
            Need += 30;
            Energy += 50;
            Health += 10;

            HealthController();
        }

        private void HealthController()
        {
            if (Need > 70 || Hunger > 70 || Sleepiness > 70)
            {
                Health -= 30;
                Happiness -= 30;
            }

            if (Age % 3 == 0 || Happiness == 100)
                Health += 10;             
        }

        public void StatusBar()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 30; j < 56; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(" ");
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(30, 0);
            Console.Write($"\tHealth : {Health}%");
            Console.SetCursorPosition(30, 1);
            Console.Write($"\tHunger : {Hunger}%");
            Console.SetCursorPosition(30, 2);
            Console.Write($"\tNeed : {Need}%");
            Console.SetCursorPosition(30, 3);
            Console.Write($"\tSleepiness : {Sleepiness}%");
            Console.SetCursorPosition(30, 4);
            Console.Write($"\tHappiness : {Happiness}%");
            Console.SetCursorPosition(30, 5);
            Console.Write($"\tEnergy : {Energy}%");            
        }

        public void PetAgeNameBar()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Name);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"Age: {Age}");            
        }        

        public abstract void Years();
        public abstract void Poop();
        public abstract void Wuuf();
        public abstract void LoveYou();
        public abstract void SleepEffect();
        public abstract void Play();
    }
}
