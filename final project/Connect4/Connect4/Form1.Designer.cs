namespace Connect4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTurn = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblScoreHeading = new System.Windows.Forms.Label();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.lblDrawScore = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(129, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 601);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.ForeColor = System.Drawing.Color.Red;
            this.lblTurn.Location = new System.Drawing.Point(25, 65);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(77, 13);
            this.lblTurn.TabIndex = 2;
            this.lblTurn.Text = "Player 1\'s Turn";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(28, 108);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnReset_MouseClick);
            // 
            // lblScoreHeading
            // 
            this.lblScoreHeading.AutoSize = true;
            this.lblScoreHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblScoreHeading.Location = new System.Drawing.Point(25, 155);
            this.lblScoreHeading.Name = "lblScoreHeading";
            this.lblScoreHeading.Size = new System.Drawing.Size(80, 13);
            this.lblScoreHeading.TabIndex = 4;
            this.lblScoreHeading.Text = "Score";
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.ForeColor = System.Drawing.Color.Red;
            this.lblPlayer1Score.Location = new System.Drawing.Point(25, 180);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(80, 13);
            this.lblPlayer1Score.TabIndex = 5;
            this.lblPlayer1Score.Text = "Player 1: 0";
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.ForeColor = System.Drawing.Color.Black;
            this.lblPlayer2Score.Location = new System.Drawing.Point(25, 200);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(80, 13);
            this.lblPlayer2Score.TabIndex = 6;
            this.lblPlayer2Score.Text = "Player 2: 0";
            // 
            // lblDrawScore
            // 
            this.lblDrawScore.AutoSize = true;
            this.lblDrawScore.ForeColor = System.Drawing.Color.DimGray;
            this.lblDrawScore.Location = new System.Drawing.Point(25, 220);
            this.lblDrawScore.Name = "lblDrawScore";
            this.lblDrawScore.Size = new System.Drawing.Size(80, 13);
            this.lblDrawScore.TabIndex = 7;
            this.lblDrawScore.Text = "Draws:   0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 623);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblScoreHeading);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.lblPlayer2Score);
            this.Controls.Add(this.lblDrawScore);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Connect 4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblScoreHeading;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Label lblDrawScore;


    }
}

