using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRouletteGame.Models
{
    public class RoulettePlayer
    {
        public RoulettePlayer(string playerFirstName, string playerLastName)
        {
            //string FirstName, LastName;
            FirstName = playerFirstName;
            LastName = playerLastName;
            Health = 100;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Health { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public override string ToString() => FullName;

    }
}
