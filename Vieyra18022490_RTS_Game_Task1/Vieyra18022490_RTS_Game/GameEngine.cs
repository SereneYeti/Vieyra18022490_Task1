using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vieyra18022490_RTS_Game
{
    class GameEngine
    {
        public int numRounds = 0;        
        MeleeUnit melee = new MeleeUnit();
        RangedUnit ranged = new RangedUnit();
        Map map = new Map();
        Random r = new Random();

        public void GameLogic(Label label)
        {
            label.Text = "Round: " + numRounds;    
            int unit1PosX = -1;
            int unit1PosY = -1;
            int unit2PosX = -1;
            int unit2PosY = -1;
            
            for (int i = 0; i < 20; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    if((unit1PosX == -1) && (unit1PosY == -1) && (map.grid[i,j] == true))   //Find Closest
                    {
                        unit1PosX = i;
                        unit1PosY = j;
                        
                    }
                    if((unit1PosX != -1) && (unit1PosY != -1) && (map.grid[i, j] == true))  //Find Closest
                    {
                        unit2PosX = i;
                        unit2PosY = j;
                    }
                    foreach(RangedUnit R in map.rangedUnits)    //Run Away
                    {
                        if(R.Health < 2)
                        {
                            ranged.Move((Direction)r.Next(0, 5), 1);
                        }

                    }
                    foreach (MeleeUnit m in map.meleeUnits)//Run Away
                    {
                        if (m.Health < 2)
                        {
                            ranged.Move((Direction)r.Next(0, 5), 1);
                        }
                        
                    }
                                        
                }
            }

            numRounds++;
        }

        
    }
}
