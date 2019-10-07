using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vieyra18022490_RTS_Game
{
    class MeleeUnit : Unit
    {   //Ranged Unit class, Inherits from the Unit class
        //Variables reflect Unit class
        Random r = new Random();
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
            set { attackRange = 1; }
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

        public MeleeUnit() { }  //Constructor

        public MeleeUnit(int xPos, int yPos, int heath, string faction, int speed, int attack, string symbol, bool attacking)
        {   //Constructor
            this.XPos = xPos;
            this.YPos = yPos;
            this.Health = heath;
            this.Faction = faction;
            this.Speed = speed;
            this.Atk = attack;
            this.AttackRange = 1;
            this.Symbol = symbol;
            this.Attacking = attacking;
        }

        public override string ToString()
        {   //Override of the ToString Funciton in order to return the required string output when needed with ease.
            return "Unit: " + symbol + "\nHealth: " + health + "\nMax Health: " + maxHealth + "\nAttack: " + attack + "\nAttack Range: " + attackRange + "\nSpeed: " + speed
                + "\nPosition: X- " + xPos + "\tY-" + yPos;
        }
        public override void Attack(int atk, int atkRng)
        {
            //Method used to attack a specified Unit            
        }

        public override int Closest(int x, int y)
        {   //Method used to determine the closest unit to a specified unit
            int temp = 0;
            Map map = new Map();

            if (map.grid[x - 1, y - 1])
            {
                temp++;
            }
            if (map.grid[x - 1, y])
            {
                temp++;
            }
            if (map.grid[x - 1, y + 1])
            {
                temp++;
            }
            if (map.grid[x, y])
            {
                temp++;
            }
            if (map.grid[x + 1, y])
            {
                temp++;
            }
            if (map.grid[x + 1, y - 1])
            {
                temp++;
            }
            if (map.grid[x + 1, y + 1])
            {
                temp++;
            }
            if (map.grid[x, y + 1])
            {
                temp++;
            }

            return temp;
        }

        public override void Death()
        {
            //Method used to deal with the death of a unit
            //Must confirm the unit is dead before the method can be implemented
        }

        public override void inRange(int atkRng)
        {
            //Method used to check if a specified unit is within the attack range of a unit. In this case within one square as this is the melee unit class.
        }

        public override void Move(Direction d,int speed)
        {   //Method used to deal with the movement of Units.
            int distance = r.Next(0, 4);
            switch (d)
            {
                case Direction.North:
                    yPos -= distance;
                    break;
                case Direction.South:
                    yPos += distance;
                    break;
                case Direction.East:
                    xPos += distance;
                    break;
                case Direction.West:
                    xPos -= distance;
                    break;
                default:
                    break;
            }
        }
    }
}
