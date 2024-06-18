
namespace MysticPartyTracker.Models
{
    public class Character
    {
        public Character(string name, string race, string @class, int level)
        {
            Name = name;
            Race = race;
            Class = @class;
            Level = level;
        }

        public string Name { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
    }

}
