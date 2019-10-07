﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vieyra18022490_RTS_Game
{
    class RangedUnit : Unit
    {
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
        {
            return "Unit: " + symbol + "\nHealth: " + health + "\nMax Health: " + maxHealth + "\nAttack: " + attack + "\nAttack Range: " + attackRange + "\nSpeed: " + speed
                + "\nPosition: X- " + xPos + "\tY-" + yPos;
        }

        public RangedUnit() { }
        public RangedUnit(int xPos, int yPos, int heath, string faction, int speed, int attack, int attackRange, string symbol, bool attacking)
        {
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

        public override void Attack(int atk, int atkRng)
        {
            
        }

        public override int Closest(int x, int y)
        {
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
           
        }

        public override void inRange(int atkRng)
        {
            
        }

        public override void Move(Direction d,int speed)
        {
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
