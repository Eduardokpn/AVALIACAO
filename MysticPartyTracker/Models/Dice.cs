using Microsoft.Maui.Controls.PlatformConfiguration;

namespace MysticPartyTracker.Models
{
    public class Dice
    {
        public int Side { get; set; }
       
        public Dice (int side) 
        {
            
            Side = side; 
        
        }
        public int Rolar()
        {
        

            return new Random().Next(1, Side + 1);

        }
    }
}
