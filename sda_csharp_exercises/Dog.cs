using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Dog : IPet
    {
        public string name;
        private const string SOUND = "hau, hau";

        public Dog(string name)
        {
            this.name = name;
        }
        public string MakeSound()
        {
            return SOUND;
        }
    }
}
