using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    interface IPet
    {
        public string Name { get; set; }

        string PetImage { get; }

        int Age { get; set; }

        int Health { get; set; }

        const string FinalWords = @"
 ██▓███  ▓█████▄▄▄█████▓    ██▓  ██████    ▓█████▄ ▓█████ ▄▄▄      ▓█████▄ 
▓██░  ██▒▓█   ▀▓  ██▒ ▓▒   ▓██▒▒██    ▒    ▒██▀ ██▌▓█   ▀▒████▄    ▒██▀ ██▌
▓██░ ██▓▒▒███  ▒ ▓██░ ▒░   ▒██▒░ ▓██▄      ░██   █▌▒███  ▒██  ▀█▄  ░██   █▌
▒██▄█▓▒ ▒▒▓█  ▄░ ▓██▓ ░    ░██░  ▒   ██▒   ░▓█▄   ▌▒▓█  ▄░██▄▄▄▄██ ░▓█▄   ▌
▒██▒ ░  ░░▒████▒ ▒██▒ ░    ░██░▒██████▒▒   ░▒████▓ ░▒████▒▓█   ▓██▒░▒████▓ 
▒▓▒░ ░  ░░░ ▒░ ░ ▒ ░░      ░▓  ▒ ▒▓▒ ▒ ░    ▒▒▓  ▒ ░░ ▒░ ░▒▒   ▓▒█░ ▒▒▓  ▒ 
░▒ ░      ░ ░  ░   ░        ▒ ░░ ░▒  ░ ░    ░ ▒  ▒  ░ ░  ░ ▒   ▒▒ ░ ░ ▒  ▒ 
░░          ░    ░          ▒ ░░  ░  ░      ░ ░  ░    ░    ░   ▒    ░ ░  ░ 
            ░  ░            ░        ░        ░       ░  ░     ░  ░   ░    
                                            ░                       ░      
";


        void Feed();
        void PlayWithPet();
        void HugPet();
        void PetToToilet();

        void Years();
        void StatusBar();
        void PetAgeNameBar();


        void Sleep();
        void Poop();
        void Wuuf();
        void LoveYou();
        void SleepEffect();
        void Play();        
    }
}
