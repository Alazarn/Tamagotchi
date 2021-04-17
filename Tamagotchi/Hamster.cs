using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Hamster : Pet  //can be expanded in the future with additional methods
    {
        public override string PetImage { get; } = @"
             .     .
            (>\---/<)
            ,'     `.
           /  q   p  \
          (  >(_Y_)<  )
           >-' `-' `-<-.
          /  _.== ,=.,- \
         /,    )`  '(    )
        ; `._.'      `--<
       :     \        |  )
       \      )       ;_/~~~
        `._ _/_  ___.'-\\\
           `--\\\";
        public override string Name { get; set; }

        public override int Age { get; set; }

        public override void Years() { }
        public override void Poop() { }
        public override void Wuuf() { }
        public override void LoveYou() { }
        public override void SleepEffect() { }
        public override void Play() { }



    }
}
