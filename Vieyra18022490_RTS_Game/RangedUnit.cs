using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vieyra18022490_RTS_Game
{
    class RangedUnit : Unit
    {   //Ranged Unit class, Inherits from the Unit class
        //Variables reflect Unit class
        Random r = new Random();
        public bool isDead {get; set;}
        public int XPos
        {
            get { return base.xPos; }
            set { xPos = value; }
        }

        public int YPos
        {
            get { return base.yPos; }
            set { yPos = value; }
        }

        public string Symbol
        {
            get { return base.symbol; }
            set { symbol = value; }
        }
        public int Health
        {
            get { return base.health; }
            set { health = value; }
        }
        public int MaxHealth
        {
            get { return base.maxHealth; }
            
        }
        public int Atk
        {
            get { return base.attack; }
            set { attack = value; }
        }
        public int AttackRange
        {
            get { return base.attackRange; }
            set { attackRange = value; }
        }
        public int Speed
        {
            get { return base.speed; }
            set { speed = value; }
        }
        public bool Attacking
        {
            get { return base.attacking; }
            set { attacking = value; }
        }
        public string Faction
        {
            get { return base.faction; }
            set { faction = value; }
        }

        public override string ToString()
        {   //Override of the ToString Funciton in order to return the required string output when needed with ease.
            return "Unit: " + symbol + "\nHealth: " + health + "\nMax Health: " + maxHealth + "\nAttack: " + attack + "\nAttack Range: " + attackRange + "\nSpeed: " + speed
                + "\nPosition: X- " + xPos + "\tY-" + yPos;
        }

        public RangedUnit() { }//Constructor
        public RangedUnit(int xPos, int yPos, int heath, string faction, int speed, int attack, int attackRange, string symbol, bool attacking)
        {   //Constructor
            this.XPos = xPos;
            this.YPos = yPos;
            this.Health = heath;
            this.Faction = faction;
            this.Speed = speed;
            this.Atk = attack;
            this.AttackRange = attackRange;
            this.Symbol = symbol;
            this.Attacking = attacking;
        }

        public override void Attack(Unit attacker)
        {
            //Method used when Units attack each other
            if(attacker is MeleeUnit)
            {
                MeleeUnit mu = ((MeleeUnit)attacker);
                Health = Health - mu.Atk;
            }
            else if (attacker is RangedUnit)
            {
                RangedUnit ru = (RangedUnit)attacker;
                Health = Health - (ru.Atk - ru.AttackRange);
            }
        }

        public override (Unit, int) Closest(List<Unit> units)
        {
            int shortest = 100;
            Unit closest = this;
            //Closest Unit and Distance                    
            foreach (Unit u in units)
            {
                if (u is MeleeUnit)
                {
                    MeleeUnit otherMu = (MeleeUnit)u;
                    int distance = Math.Abs(this.XPos - otherMu.XPos)
                               + Math.Abs(this.YPos - otherMu.YPos);
                    if (distance < shortest)
                    {
                        shortest = distance;
                        closest = otherMu;
                    }
                }
                else if (u is RangedUnit)
                {
                    RangedUnit otherRu = (RangedUnit)u;
                    int distance = Math.Abs(this.XPos - otherRu.XPos)
                               + Math.Abs(this.YPos - otherRu.YPos);
                    if (distance < shortest)
                    {
                        shortest = distance;
                        closest = otherRu;
                    }
                }

            }
            return (closest, shortest);
        }

        public override void Death()
        {
            //Method used to destroy Units
            //Must check if the Unit is dead before this can be implimented
            symbol = "X";
            isDead = true;
        }

        public override bool inRange(Unit other)
        {
            //Method used to check if a specified unit is within the attack range of a unit. In this case within one square as this is the melee unit class.
            //Method used to check if a unti is inRange to attack a specified unit
            int distance = 0;
            int otherX = 0;
            int otherY = 0;
            if (other is MeleeUnit)
            {
                otherX = ((MeleeUnit)other).XPos;
                otherY = ((MeleeUnit)other).YPos;
            }
            else if (other is RangedUnit)
            {
                otherX = ((RangedUnit)other).XPos;
                otherY = ((RangedUnit)other).YPos;
            }

            distance = Math.Abs(XPos - otherX) + Math.Abs(YPos - otherY);
            if (distance <= AttackRange)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Move(int dir)
        {
            switch (dir)
            {
                case 0: YPos--; break; //North
                case 1: XPos++; break; //East
                case 2: YPos++; break; //South
                case 3: XPos--; break; //West
                default: break;
            }
        }


    }
}
