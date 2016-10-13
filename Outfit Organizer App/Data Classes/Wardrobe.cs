using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outfit_Organizer_App.Data_Classes
{
    public class Wardrobe
    {
        public String Owner { get; set; }
        public String Name { get; set; }
        public ICollection<ClothingItem> Clothes { get; set; }
    }
}
