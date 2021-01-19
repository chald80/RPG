using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Player
    {
        
        private string _name;
        private int _level;
        private int _hp;
        private int _dmg;
        private int _armour;

        public Player(string name, int level, int hp, int dmg, int armour)
        {
            Name = name;
            Level = level;
            Hp = hp;
            Dmg = dmg;
            Armour = armour;
        }

        public string Name 
        { 
            get { return _name; } 
            set { _name = value; }
        }
        public int Level 
        { 
            get { return _level; } 
            set { _level = value; }
        }
        public int Hp 
        { 
            get { return _hp; } 
            set { _hp = value; }
        }
        public int Dmg 
        { 
            get { return _dmg; } 
            set { _dmg = value; } 
        }
        public int Armour 
        { 
            get { return _armour; } 
            set { _armour = value; } 
        }


    }
}
