namespace GameMemory
{
    partial class SaltarGame
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
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxtuboArriba = new System.Windows.Forms.PictureBox();
            this.pictureBoxTuboAbajo = new System.Windows.Forms.PictureBox();
            this.pictureBoxPiso = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.labelPointSaltar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtuboArriba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTuboAbajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPiso)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Image = global::GameMemory.Properties.Resources.angry_bird_red_icon;
            this.pictureBoxPlayer.Location = new System.Drawing.Point(371, 284);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(108, 102);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer.TabIndex = 0;
            this.pictureBoxPlayer.TabStop = false;
            this.pictureBoxPlayer.Click += new System.EventHandler(this.pictureBoxPlayer_Click);
            // 
            // pictureBoxtuboArriba
            // 
            this.pictureBoxtuboArriba.Image = global::GameMemory.Properties.Resources.tuboArriba;
            this.pictureBoxtuboArriba.Location = new System.Drawing.Point(640, -91);
            this.pictureBoxtuboArriba.Name = "pictureBoxtuboArriba";
            this.pictureBoxtuboArriba.Size = new System.Drawing.Size(143, 357);
            this.pictureBoxtuboArriba.TabIndex = 1;
            this.pictureBoxtuboArriba.TabStop = false;
            // 
            // pictureBoxTuboAbajo
            // 
            this.pictureBoxTuboAbajo.Image = global::GameMemory.Properties.Resources.tubo;
            this.pictureBoxTuboAbajo.Location = new System.Drawing.Point(640, 408);
            this.pictureBoxTuboAbajo.Name = "pictureBoxTuboAbajo";
            this.pictureBoxTuboAbajo.Size = new System.Drawing.Size(143, 385);
            this.pictureBoxTuboAbajo.TabIndex = 2;
            this.pictureBoxTuboAbajo.TabStop = false;
            // 
            // pictureBoxPiso
            // 
            this.pictureBoxPiso.Image = global::GameMemory.Properties.Resources.paisaje;
            this.pictureBoxPiso.Location = new System.Drawing.Point(-2, 612);
            this.pictureBoxPiso.Name = "pictureBoxPiso";
            this.pictureBoxPiso.Size = new System.Drawing.Size(1173, 50);
            this.pictureBoxPiso.TabIndex = 3;
            this.pictureBoxPiso.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            // 
            // labelPointSaltar
            // 
            this.labelPointSaltar.AutoSize = true;
            this.labelPointSaltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointSaltar.Location = new System.Drawing.Point(417, 260);
            this.labelPointSaltar.Name = "labelPointSaltar";
            this.labelPointSaltar.Size = new System.Drawing.Size(21, 24);
            this.labelPointSaltar.TabIndex = 4;
            this.labelPointSaltar.Text = "0";
            // 
            // SaltarGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameMemory.Properties.Resources.paisaje;
            this.ClientSize = new System.Drawing.Size(1162, 662);
            this.Controls.Add(this.labelPointSaltar);
            this.Controls.Add(this.pictureBoxPiso);
            this.Controls.Add(this.pictureBoxTuboAbajo);
            this.Controls.Add(this.pictureBoxtuboArriba);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Name = "SaltarGame";
            this.Text = "SaltarGame";
            this.Load += new System.EventHandler(this.SaltarGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtuboArriba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTuboAbajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPiso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.PictureBox pictureBoxtuboArriba;
        private System.Windows.Forms.PictureBox pictureBoxTuboAbajo;
        private System.Windows.Forms.PictureBox pictureBoxPiso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label labelPointSaltar;
    }
}