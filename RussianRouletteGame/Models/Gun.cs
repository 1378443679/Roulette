using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRouletteGame.Models
{
    public class Gun
    {
        // interface
        //Random randomBulletgen = new Random();
        //int randomBullet = randomBullet.Next(1, NumberOfBullets + 1);
        public Gun()
        {
            Name = "Revolver";
            NumberOfBullets = 6;
            
        }
        public string Name { get; set; }
        public int NumberOfBullets { get; set; }

        


    }
}
