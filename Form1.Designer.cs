
namespace rockpaperscissor
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissor = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtCountdown = new System.Windows.Forms.Label();
            this.txtRounds = new System.Windows.Forms.Label();
            this.picComp = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.CountdownTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRock.Location = new System.Drawing.Point(129, 111);
            this.btnRock.Margin = new System.Windows.Forms.Padding(4);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(147, 47);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPaper.Location = new System.Drawing.Point(129, 195);
            this.btnPaper.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(147, 47);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissor
            // 
            this.btnScissor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnScissor.Location = new System.Drawing.Point(129, 285);
            this.btnScissor.Margin = new System.Windows.Forms.Padding(4);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(147, 47);
            this.btnScissor.TabIndex = 2;
            this.btnScissor.Text = "Scissor";
            this.btnScissor.UseVisualStyleBackColor = false;
            this.btnScissor.Click += new System.EventHandler(this.btnScissor_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRestart.Location = new System.Drawing.Point(925, 397);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(112, 28);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(399, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(899, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Computer";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtScore.Location = new System.Drawing.Point(566, 87);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(214, 25);
            this.txtScore.TabIndex = 8;
            this.txtScore.Text = "Player:  0 /Comp: 0";
            // 
            // txtCountdown
            // 
            this.txtCountdown.AutoSize = true;
            this.txtCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountdown.ForeColor = System.Drawing.Color.Crimson;
            this.txtCountdown.Location = new System.Drawing.Point(662, 213);
            this.txtCountdown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCountdown.Name = "txtCountdown";
            this.txtCountdown.Size = new System.Drawing.Size(99, 108);
            this.txtCountdown.TabIndex = 9;
            this.txtCountdown.Text = "5";
            // 
            // txtRounds
            // 
            this.txtRounds.AutoSize = true;
            this.txtRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRounds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtRounds.Location = new System.Drawing.Point(635, 378);
            this.txtRounds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRounds.Name = "txtRounds";
            this.txtRounds.Size = new System.Drawing.Size(145, 37);
            this.txtRounds.TabIndex = 10;
            this.txtRounds.Text = "Round 3";
            // 
            // picComp
            // 
            this.picComp.Image = global::rockpaperscissor.Properties.Resources.download;
            this.picComp.Location = new System.Drawing.Point(826, 130);
            this.picComp.Margin = new System.Windows.Forms.Padding(4);
            this.picComp.Name = "picComp";
            this.picComp.Size = new System.Drawing.Size(231, 215);
            this.picComp.TabIndex = 5;
            this.picComp.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::rockpaperscissor.Properties.Resources.download;
            this.picPlayer.Location = new System.Drawing.Point(312, 130);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(229, 215);
            this.picPlayer.TabIndex = 11;
            this.picPlayer.TabStop = false;
            // 
            // CountdownTimer
            // 
            this.CountdownTimer.Interval = 1000;
            this.CountdownTimer.Tick += new System.EventHandler(this.countDownTimerEvent);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(79, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 221);
            this.button1.TabIndex = 12;
            this.button1.Text = "MAKE   A    CHOICE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.txtRounds);
            this.Controls.Add(this.txtCountdown);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picComp);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnScissor);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissor;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox picComp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtCountdown;
        private System.Windows.Forms.Label txtRounds;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Timer CountdownTimer;
        private System.Windows.Forms.Button button1;
    }
}

