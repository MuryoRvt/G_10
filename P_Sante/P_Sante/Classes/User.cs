using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Sante.Classes
{
    public class User
    {
        //base data

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }

        public string Password { get; set; }

        //interests

        public bool IntMentalHealth { get; set; }

        public bool IntPhysicalHealth { get; set; }

        //mental health

        public byte State { get; set; }

        public bool Friends { get; set; }

        public bool Anxiety { get; set; }

        public byte EaseToRelate { get; set; }

        public string Favourites1 { get; set; }

        public string Favourites2 { get; set; }

        public string Favourites3 { get; set; }

        public int MentalScore { get; set; }

        //phisycal health

        public bool Sleep { get; set; }

        public bool Exercises { get; set; }

        public bool Water { get; set; }

        public byte FoodQuality { get; set; }

        public bool Medicines { get; set; }

        public string Medicines1 { get; set; }

        public string Medicines2 { get; set; }

        public string Medicines3 { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public int PhysicalScore { get; set; }
    }
}
