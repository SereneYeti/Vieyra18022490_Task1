﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vieyra18022490_RTS_Game
{
    public enum Direction
    {
        North,
        South,
        East,
        West
    }
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
        protected string faction { get; set; }
        protected bool attacking { get; set; }

        public abstract void Move(Direction d,int speed);

        public abstract void Attack(int atk, int atkRng);

        public abstract void inRange(int atkRng);

        public abstract int Closest(int x, int y);

        public abstract void Death();

        public abstract override string ToString();
        
    }
}
