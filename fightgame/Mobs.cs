using System;
using System.Collections.Generic;
using System.Text;

namespace fightgame
{
    class Mob
    {
        public int Health { get; set; }

        public Mob(int startinghp)
        {
            Health = startinghp;

        }
        public Level2(int startinghp2)
        {
            Health = startinghp2;
        }
    }
}