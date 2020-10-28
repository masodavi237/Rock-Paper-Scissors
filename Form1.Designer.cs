namespace WindowsFormsApp1
{
    partial class RockPaperScissors
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblComputerPlayer = new System.Windows.Forms.Label();
            this.pbxPlayer = new System.Windows.Forms.PictureBox();
            this.pbxComputer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbPlayerRock = new System.Windows.Forms.RadioButton();
            this.rdbPlayerScissors = new System.Windows.Forms.RadioButton();
            this.rdbPlayerPaper = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblComputerMove = new System.Windows.Forms.Label();
            this.lblCompMoveDisp = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblPlayerScoreDisplay = new System.Windows.Forms.Label();
            this.lblTies = new System.Windows.Forms.Label();
            this.lblComputerScoreDisplay = new System.Windows.Forms.Label();
            this.lblTiesDisplay = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComputer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(119, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(546, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Rock, Paper, Scissors!";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Wide Latin", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(46, 96);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(107, 19);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.Text = "Player";
            // 
            // lblComputerPlayer
            // 
            this.lblComputerPlayer.AutoSize = true;
            this.lblComputerPlayer.Font = new System.Drawing.Font("Wide Latin", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerPlayer.Location = new System.Drawing.Point(586, 96);
            this.lblComputerPlayer.Name = "lblComputerPlayer";
            this.lblComputerPlayer.Size = new System.Drawing.Size(153, 19);
            this.lblComputerPlayer.TabIndex = 3;
            this.lblComputerPlayer.Text = "Computer";
            // 
            // pbxPlayer
            // 
            this.pbxPlayer.Location = new System.Drawing.Point(50, 138);
            this.pbxPlayer.Name = "pbxPlayer";
            this.pbxPlayer.Size = new System.Drawing.Size(190, 152);
            this.pbxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPlayer.TabIndex = 4;
            this.pbxPlayer.TabStop = false;
            // 
            // pbxComputer
            // 
            this.pbxComputer.Location = new System.Drawing.Point(549, 138);
            this.pbxComputer.Name = "pbxComputer";
            this.pbxComputer.Size = new System.Drawing.Size(190, 152);
            this.pbxComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxComputer.TabIndex = 5;
            this.pbxComputer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(374, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vs.";
            // 
            // rdbPlayerRock
            // 
            this.rdbPlayerRock.AutoSize = true;
            this.rdbPlayerRock.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPlayerRock.Location = new System.Drawing.Point(50, 306);
            this.rdbPlayerRock.Name = "rdbPlayerRock";
            this.rdbPlayerRock.Size = new System.Drawing.Size(80, 29);
            this.rdbPlayerRock.TabIndex = 8;
            this.rdbPlayerRock.TabStop = true;
            this.rdbPlayerRock.Text = "Rock";
            this.rdbPlayerRock.UseVisualStyleBackColor = true;
            this.rdbPlayerRock.CheckedChanged += new System.EventHandler(this.rdbPlayerRock_Checked);
            // 
            // rdbPlayerScissors
            // 
            this.rdbPlayerScissors.AutoSize = true;
            this.rdbPlayerScissors.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPlayerScissors.Location = new System.Drawing.Point(50, 372);
            this.rdbPlayerScissors.Name = "rdbPlayerScissors";
            this.rdbPlayerScissors.Size = new System.Drawing.Size(107, 29);
            this.rdbPlayerScissors.TabIndex = 11;
            this.rdbPlayerScissors.TabStop = true;
            this.rdbPlayerScissors.Text = "Scissors";
            this.rdbPlayerScissors.UseVisualStyleBackColor = true;
            this.rdbPlayerScissors.CheckedChanged += new System.EventHandler(this.rdbPlayerScissors_CheckedChanged);
            // 
            // rdbPlayerPaper
            // 
            this.rdbPlayerPaper.AutoSize = true;
            this.rdbPlayerPaper.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPlayerPaper.Location = new System.Drawing.Point(50, 339);
            this.rdbPlayerPaper.Name = "rdbPlayerPaper";
            this.rdbPlayerPaper.Size = new System.Drawing.Size(88, 29);
            this.rdbPlayerPaper.TabIndex = 12;
            this.rdbPlayerPaper.TabStop = true;
            this.rdbPlayerPaper.Text = "Paper";
            this.rdbPlayerPaper.UseVisualStyleBackColor = true;
            this.rdbPlayerPaper.CheckedChanged += new System.EventHandler(this.rdbPlayerPaper_CheckedChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSize = true;
            this.btnPlay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlay.Location = new System.Drawing.Point(323, 388);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(175, 31);
            this.btnPlay.TabIndex = 13;
            this.btnPlay.Text = "Play Move";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblComputerMove
            // 
            this.lblComputerMove.AutoSize = true;
            this.lblComputerMove.Font = new System.Drawing.Font("Wide Latin", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerMove.Location = new System.Drawing.Point(532, 312);
            this.lblComputerMove.Name = "lblComputerMove";
            this.lblComputerMove.Size = new System.Drawing.Size(237, 19);
            this.lblComputerMove.TabIndex = 14;
            this.lblComputerMove.Text = "Computer Move";
            // 
            // lblCompMoveDisp
            // 
            this.lblCompMoveDisp.AutoSize = true;
            this.lblCompMoveDisp.Font = new System.Drawing.Font("Magneto", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompMoveDisp.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCompMoveDisp.Location = new System.Drawing.Point(584, 367);
            this.lblCompMoveDisp.Name = "lblCompMoveDisp";
            this.lblCompMoveDisp.Size = new System.Drawing.Size(0, 35);
            this.lblCompMoveDisp.TabIndex = 15;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(320, 428);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 16;
            // 
            // lblPlayerScoreDisplay
            // 
            this.lblPlayerScoreDisplay.AutoSize = true;
            this.lblPlayerScoreDisplay.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScoreDisplay.Location = new System.Drawing.Point(246, 138);
            this.lblPlayerScoreDisplay.Name = "lblPlayerScoreDisplay";
            this.lblPlayerScoreDisplay.Size = new System.Drawing.Size(124, 14);
            this.lblPlayerScoreDisplay.TabIndex = 17;
            this.lblPlayerScoreDisplay.Text = "Player Wins";
            // 
            // lblTies
            // 
            this.lblTies.AutoSize = true;
            this.lblTies.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTies.Location = new System.Drawing.Point(377, 222);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(47, 14);
            this.lblTies.TabIndex = 18;
            this.lblTies.Text = "Ties";
            // 
            // lblComputerScoreDisplay
            // 
            this.lblComputerScoreDisplay.AutoSize = true;
            this.lblComputerScoreDisplay.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScoreDisplay.Location = new System.Drawing.Point(398, 138);
            this.lblComputerScoreDisplay.Name = "lblComputerScoreDisplay";
            this.lblComputerScoreDisplay.Size = new System.Drawing.Size(154, 14);
            this.lblComputerScoreDisplay.TabIndex = 19;
            this.lblComputerScoreDisplay.Text = "Computer Wins";
            // 
            // lblTiesDisplay
            // 
            this.lblTiesDisplay.AutoSize = true;
            this.lblTiesDisplay.Font = new System.Drawing.Font("Magneto", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiesDisplay.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTiesDisplay.Location = new System.Drawing.Point(374, 296);
            this.lblTiesDisplay.Name = "lblTiesDisplay";
            this.lblTiesDisplay.Size = new System.Drawing.Size(0, 35);
            this.lblTiesDisplay.TabIndex = 20;
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Font = new System.Drawing.Font("Magneto", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScore.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblComputerScore.Location = new System.Drawing.Point(458, 169);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(0, 35);
            this.lblComputerScore.TabIndex = 21;
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Magneto", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPlayerScore.Location = new System.Drawing.Point(273, 178);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(0, 35);
            this.lblPlayerScore.TabIndex = 22;
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.lblTiesDisplay);
            this.Controls.Add(this.lblComputerScoreDisplay);
            this.Controls.Add(this.lblTies);
            this.Controls.Add(this.lblPlayerScoreDisplay);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblCompMoveDisp);
            this.Controls.Add(this.lblComputerMove);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.rdbPlayerPaper);
            this.Controls.Add(this.rdbPlayerScissors);
            this.Controls.Add(this.rdbPlayerRock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxComputer);
            this.Controls.Add(this.pbxPlayer);
            this.Controls.Add(this.lblComputerPlayer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblTitle);
            this.Name = "RockPaperScissors";
            this.Text = "Rock Papaer Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComputer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblComputerPlayer;
        private System.Windows.Forms.PictureBox pbxPlayer;
        private System.Windows.Forms.PictureBox pbxComputer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbPlayerRock;
        private System.Windows.Forms.RadioButton rdbPlayerScissors;
        private System.Windows.Forms.RadioButton rdbPlayerPaper;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblComputerMove;
        private System.Windows.Forms.Label lblCompMoveDisp;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblPlayerScoreDisplay;
        private System.Windows.Forms.Label lblTies;
        private System.Windows.Forms.Label lblComputerScoreDisplay;
        private System.Windows.Forms.Label lblTiesDisplay;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Label lblPlayerScore;
    }
}

