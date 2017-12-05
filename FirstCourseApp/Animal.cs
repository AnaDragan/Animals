using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCourseApp
{
    class Animal
    {
        string name = "";
        string sound = "";

        public Animal(string newName, string newSound)
        {
            name = newName;
            sound = newSound;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Sound
        {
            get => sound;
            set => sound = value;
        }
    }
}
