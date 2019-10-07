using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vieyra18022490_RTS_Game
{   //Abstract class with no code implemented
    //Used for the sake of re-use and inheritance
    
    abstract class Unit
    {
        
        protected int xPos { get; set; }
        protected int yPos { get; set; }
        protected int health { get; set; }
        protected int maxHealth { get; }
        protected int speed { get; set; }
        protected int attack { get; set; }
        protected int attackRange { get; set; }
        protected string symbol { get; set; }
        protected int faction { get; set; }
        protected bool attacking { get; set; }

        public abstract void Move(int dir);

        public abstract void Attack(Unit attacker);

        public abstract bool inRange(Unit other);

        public abstract (Unit, int) Closest(List<Unit> units);

        public abstract void Death();

        public abstract override string ToString();
        
    }
}
