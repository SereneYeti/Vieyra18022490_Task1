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
        {   //Generates and instantiates the game and Units
            GameEngine engine = new GameEngine(20, txtInfo, grpMap);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {   //Startsthe round timer in order to keep track of the game and keep it moving forward.
            tmrTrack.Enabled = true;
           
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {   //Pauses the round timer
            tmrTrack.Enabled = false;
        }

        private void TmrTrack_Tick(object sender, EventArgs e)
        {
            //Occurs whenever the timer 'tick's i.e. increases by one
            GameEngine engine = new GameEngine();
            lblRound.Text = "Round: " + engine.Round.ToString();
            engine.Update();

        }
    }
}
