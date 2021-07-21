using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
    class Bear
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int NumberOfFishEaten { get; private set; }
        public string EducationLevel { get; set; } = "GED"; // property with a default value
        public Tiger BestTigerFriend { get; set; }
        public bool LovesHoney { get; } // read only property

        public Bear(string name, string type) // constructor, no one can make a bear unless they supply these 2 things
        {
            Name = name;
            Type = type;

            if (name == "Winnie the Pooh")
            {
                LovesHoney = true;
            }
            else if (name == "Yogi")
            {
                EducationLevel = "Above Average";
            }
        }

        public Bear(string name, string type, string educationLevel) : this(name, type)
        {
            EducationLevel = educationLevel;
        }

        public Bear(string name, string type, string educationLevel, int howManyFish) : this(name, type, educationLevel)
        {
            NumberOfFishEaten = howManyFish;
        }

        public void EatFish(int howMany)
        {
            if (howMany <= 0) return;

            NumberOfFishEaten += howMany;
        }

        public void HangOutWithBestFriend()
        {
            Console.WriteLine($"{Name} the bear is hanging out with its best tiger friend, {BestTigerFriend.Name} the {BestTigerFriend.Size} sized tiger.");
        }
    }
}
