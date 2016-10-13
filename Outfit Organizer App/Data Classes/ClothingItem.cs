using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace Outfit_Organizer_App.Data_Classes
{
    public class ClothingItem
    {
        public String Name { get; set; }
        public int Type { get; set; }
        public Color Clr { get; set; } //primary vs secondary?
        public DateTime recentWear { get; set; }
        public int Fancy { get; set; }
        public int Wardrobe { get; set; }
        public int Favorite { get; set; }
        public String Brand { get; set; }
        public String Path { get; set; }//to store the path of the image
    }
}
