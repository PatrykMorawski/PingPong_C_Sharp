namespace PingPong
{
    partial class Form1
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
            this.playground = new System.Windows.Forms.Panel();
            this.lblNajScore = new System.Windows.Forms.Label();
            this.HightScore_lbl = new System.Windows.Forms.Label();
            this.M_lbl = new System.Windows.Forms.Label();
            this.GameOver_lbl = new System.Windows.Forms.Label();
            this.scorelbl = new System.Windows.Forms.Label();
            this.Score_lbl = new System.Windows.Forms.Label();
            this.pbBall = new System.Windows.Forms.PictureBox();
            this.pbRocket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRocket)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.lblNajScore);
            this.playground.Controls.Add(this.HightScore_lbl);
            this.playground.Controls.Add(this.M_lbl);
            this.playground.Controls.Add(this.GameOver_lbl);
            this.playground.Controls.Add(this.scorelbl);
            this.playground.Controls.Add(this.Score_lbl);
            this.playground.Controls.Add(this.pbBall);
            this.playground.Controls.Add(this.pbRocket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(749, 379);
            this.playground.TabIndex = 0;
            // 
            // lblNajScore
            // 
            this.lblNajScore.AutoSize = true;
            this.lblNajScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNajScore.Location = new System.Drawing.Point(457, 9);
            this.lblNajScore.Name = "lblNajScore";
            this.lblNajScore.Size = new System.Drawing.Size(35, 37);
            this.lblNajScore.TabIndex = 7;
            this.lblNajScore.Text = "0";
            // 
            // HightScore_lbl
            // 
            this.HightScore_lbl.AutoSize = true;
            this.HightScore_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HightScore_lbl.Location = new System.Drawing.Point(225, 9);
            this.HightScore_lbl.Name = "HightScore_lbl";
            this.HightScore_lbl.Size = new System.Drawing.Size(226, 37);
            this.HightScore_lbl.TabIndex = 6;
            this.HightScore_lbl.Text = "Highest Score:";
            // 
            // M_lbl
            // 
            this.M_lbl.AutoSize = true;
            this.M_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_lbl.Location = new System.Drawing.Point(595, 9);
            this.M_lbl.Name = "M_lbl";
            this.M_lbl.Size = new System.Drawing.Size(514, 39);
            this.M_lbl.TabIndex = 5;
            this.M_lbl.Text = "Press M - to turn ON/OFF Music";
            this.M_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GameOver_lbl
            // 
            this.GameOver_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameOver_lbl.AutoSize = true;
            this.GameOver_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOver_lbl.Location = new System.Drawing.Point(243, 70);
            this.GameOver_lbl.Name = "GameOver_lbl";
            this.GameOver_lbl.Size = new System.Drawing.Size(277, 220);
            this.GameOver_lbl.TabIndex = 4;
            this.GameOver_lbl.Text = "Game Over\r\n\r\nF1 - Restart\r\nEsc - Exit";
            this.GameOver_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelbl.Location = new System.Drawing.Point(153, 0);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(51, 55);
            this.scorelbl.TabIndex = 3;
            this.scorelbl.Text = "0";
            // 
            // Score_lbl
            // 
            this.Score_lbl.AutoSize = true;
            this.Score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_lbl.Location = new System.Drawing.Point(3, 0);
            this.Score_lbl.Name = "Score_lbl";
            this.Score_lbl.Size = new System.Drawing.Size(163, 55);
            this.Score_lbl.TabIndex = 2;
            this.Score_lbl.Text = "Score:";
            // 
            // pbBall
            // 
            this.pbBall.BackColor = System.Drawing.Color.Red;
            this.pbBall.Location = new System.Drawing.Point(253, 124);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(20, 20);
            this.pbBall.TabIndex = 1;
            this.pbBall.TabStop = false;
            // 
            // pbRocket
            // 
            this.pbRocket.BackColor = System.Drawing.Color.Black;
            this.pbRocket.Location = new System.Drawing.Point(292, 337);
            this.pbRocket.Name = "pbRocket";
            this.pbRocket.Size = new System.Drawing.Size(200, 20);
            this.pbRocket.TabIndex = 0;
            this.pbRocket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 379);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRocket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox pbBall;
        private System.Windows.Forms.PictureBox pbRocket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label Score_lbl;
        private System.Windows.Forms.Label GameOver_lbl;
        private System.Windows.Forms.Label M_lbl;
        private System.Windows.Forms.Label HightScore_lbl;
        private System.Windows.Forms.Label lblNajScore;
    }
}

