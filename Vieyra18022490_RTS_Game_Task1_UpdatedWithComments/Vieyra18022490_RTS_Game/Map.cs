using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vieyra18022490_RTS_Game
{
    class Map
    {   //Class that deals witht the game map and the generation of units
        public List<MeleeUnit> meleeUnits = new List<MeleeUnit>();
        public List<RangedUnit> rangedUnits = new List<RangedUnit>();
        public bool[,] grid = new bool[20, 20];
        public Random r = new Random();
        string meleeSymbol = "****|-";
        string rangedSymbol = "--|";
        int numRangedUnits;
        int numMeleeUnits;

        public Map(int numRu, int numMu)
        {   //Constructor
            this.numMeleeUnits = numMu;
            this.numRangedUnits = numRu;
        }

        public Map() { } //Constructor

        public void GenerateUnits()
        {   //Method used to generate and store untis
            int tempX;
            int tempY;
            for(int i = 0; i < numMeleeUnits; i++)//Humans
            {
                tempX = r.Next(1,20);
                tempY = r.Next(1, 20);
                MeleeUnit m = new MeleeUnit(tempX, tempY, 6, "Humans", 2, 2, meleeSymbol, false);
                meleeUnits.Add(m);
            }
            
            
            for (int i = 0; i < numRangedUnits; i++)//Humans
            {
                tempX = r.Next(1, 20);
                tempY = r.Next(1, 20);
                RangedUnit R = new RangedUnit(tempX, tempY, 6, "Humans", 2, 2, r.Next(0, 5), rangedSymbol, false);
                rangedUnits.Add(R);
            }

            for (int i = 0; i < numMeleeUnits; i++)//Orcs
            {
                tempX = r.Next(1, 20);
                tempY = r.Next(1, 20);
                MeleeUnit m = new MeleeUnit(tempX, tempY, 6, "Orcs", 2, 2, meleeSymbol, false);
                meleeUnits.Add(m);
            }


            for (int i = 0; i < numRangedUnits; i++)//Orcs
            {
                tempX = r.Next(1, 20);
                tempY = r.Next(1, 20);
                RangedUnit R = new RangedUnit(tempX, tempY, 6, "Orcs", 2, 2, r.Next(0, 5), rangedSymbol, false);
                rangedUnits.Add(R);
            }

            for(int x =0;x < 20;x++)
            {
                for(int y = 0; y < 20;y++)
                {
                    foreach(MeleeUnit m in meleeUnits)
                    {
                        if ((x != m.XPos)&&(y != m.YPos))
                        {
                            grid[x, y] = false;
                        }
                        else
                        {
                            grid[x, y] = true;
                        }
                    }
                    
                    
                }
            }
        }

        public void Display(GroupBox groupBox)
        {   //Method used to display units
            groupBox.Controls.Clear();
            foreach (MeleeUnit m in meleeUnits)
            {
                Label display = new Label();
                display.Width = 30;
                display.Height = 20;
                display.Location = new Point(m.XPos * 20, m.YPos * 20);
                display.Text = m.Symbol;
                if(m.Faction == "Humans") { display.ForeColor = Color.Blue; }
                if (m.Faction == "Orcs") { display.ForeColor = Color.Red; }
                groupBox.Controls.Add(display);
            }

            foreach (RangedUnit R in rangedUnits)
            {
                Label display = new Label();
                display.Width = 20;
                display.Height = 20;
                display.Location = new Point(R.XPos * 20, R.YPos * 20);
                display.Text = R.Symbol;
                if (R.Faction == "Orcs") { display.ForeColor = Color.Red; }
                if (R.Faction == "Humans") { display.ForeColor = Color.Blue; }
                groupBox.Controls.Add(display);
            }
        }

        public void Update()
        {   //Method used to update the display after every round.
            foreach (MeleeUnit m in meleeUnits)
            {
                m.XPos = r.Next(1, 20);
                m.YPos = r.Next(1, 20);
            }

            foreach (RangedUnit R in rangedUnits)
            {
                R.XPos = r.Next(1, 20);
                R.YPos = r.Next(1, 20);
            }
        }
    }
}
