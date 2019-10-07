namespace Vieyra18022490_RTS_Game
{
    partial class frmRTS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpMap = new System.Windows.Forms.GroupBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblRound = new System.Windows.Forms.Label();
            this.tmrTrack = new System.Windows.Forms.Timer(this.components);
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // grpMap
            // 
            this.grpMap.Location = new System.Drawing.Point(11, 12);
            this.grpMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMap.Name = "grpMap";
            this.grpMap.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMap.Size = new System.Drawing.Size(1307, 973);
            this.grpMap.TabIndex = 0;
            this.grpMap.TabStop = false;
            this.grpMap.Text = "Map";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(1352, 110);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(408, 69);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1352, 12);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(408, 60);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(1347, 238);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(0, 32);
            this.lblRound.TabIndex = 5;
            // 
            // tmrTrack
            // 
            this.tmrTrack.Interval = 500;
            this.tmrTrack.Tick += new System.EventHandler(this.TmrTrack_Tick);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(1352, 219);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(408, 766);
            this.txtInfo.TabIndex = 6;
            // 
            // frmRTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1805, 1021);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.grpMap);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRTS";
            this.Text = "RTS Game";
            this.Load += new System.EventHandler(this.FrmRTS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMap;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Timer tmrTrack;
        private System.Windows.Forms.TextBox txtInfo;
    }
}

