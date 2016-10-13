using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outfit_Organizer_App.Data_Classes
{
    public class Profile
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Gender { get; set; }
        public ICollection<Wardrobe> MyWardrobes { get; set; }
        public ICollection<Wardrobe> FollowingWardrobes { get; set; }
        //preferences 
    }
}
