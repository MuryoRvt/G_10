using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P_Sante.Controllers;

namespace P_Sante.Models
{
    public class Model
    {
        /// <summary>
        /// Controller to manage the model
        /// </summary>
        public Controller Controller {get;set;}

        public string Name { get; set; } = "John";

        public string LastName { get; set; } = "Doe";

        public string Email { get; set; } = "example@gamil.com";

        public string Password { get; set; } = "4444";

        public int State { get; set; }

        public int Friends { get; set; }

        public int Anxiety { get; set; }

        public int RelationshipFacility { get; set; }

        public List<string> Favourites { get; set; }

        public int MentalScore { get; set; }

        public Model()
        {
            Favourites = new List<string>();
        }
    }
}
