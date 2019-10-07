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
    public partial class frmRTS : Form
    {
        
        public frmRTS()
        {
            InitializeComponent();
        }

        private void FrmRTS_Load(object sender, EventArgs e)
        {
            
            map.GenerateUnits();
            map.Display(gbxMap);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            tmrTrack.Enabled = true;
            Map_Memo map = new Map_Memo(20);
            map.Generate();
            map.Display(gbxMap);
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            tmrTrack.Enabled = false;
        }

        private void TmrTrack_Tick(object sender, EventArgs e)
        {
           map.Update();
           engine.GameLogic(lblRound);
           map.Display(gbxMap);

        }
    }
}
