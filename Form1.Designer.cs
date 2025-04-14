namespace Tic_Tac_Toe_Game
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblWi = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBottomRight = new System.Windows.Forms.Button();
            this.btnBottomMiddle = new System.Windows.Forms.Button();
            this.btnBottomLeft = new System.Windows.Forms.Button();
            this.btnMiddleRight = new System.Windows.Forms.Button();
            this.btnMiddleMiddle = new System.Windows.Forms.Button();
            this.btnMiddleLeft = new System.Windows.Forms.Button();
            this.btnTopRight = new System.Windows.Forms.Button();
            this.btnTopMiddle = new System.Windows.Forms.Button();
            this.btnTopLeft = new System.Windows.Forms.Button();
            this.Pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.Yellow;
            this.lblTurn.Location = new System.Drawing.Point(103, 173);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(99, 46);
            this.lblTurn.TabIndex = 1;
            this.lblTurn.Text = "Turn";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Britannic Bold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayer.Location = new System.Drawing.Point(76, 219);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(150, 37);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.Tag = "Game Over";
            this.lblPlayer.Text = "Player 1";
            // 
            // lblWi
            // 
            this.lblWi.AutoSize = true;
            this.lblWi.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWi.ForeColor = System.Drawing.Color.Yellow;
            this.lblWi.Location = new System.Drawing.Point(84, 258);
            this.lblWi.Name = "lblWi";
            this.lblWi.Size = new System.Drawing.Size(142, 46);
            this.lblWi.TabIndex = 3;
            this.lblWi.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Britannic Bold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblWinner.Location = new System.Drawing.Point(40, 315);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWinner.Size = new System.Drawing.Size(203, 37);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "In Progress";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestart.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRestart.Location = new System.Drawing.Point(47, 372);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(196, 49);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 40F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(210, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 72);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adham Game";
            // 
            // btnBottomRight
            // 
            this.btnBottomRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBottomRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottomRight.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btnBottomRight.Location = new System.Drawing.Point(628, 337);
            this.btnBottomRight.Name = "btnBottomRight";
            this.btnBottomRight.Size = new System.Drawing.Size(89, 93);
            this.btnBottomRight.TabIndex = 29;
            this.btnBottomRight.Tag = "?";
            this.btnBottomRight.UseVisualStyleBackColor = true;
            this.btnBottomRight.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnBottomMiddle
            // 
            this.btnBottomMiddle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBottomMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottomMiddle.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btnBottomMiddle.Location = new System.Drawing.Point(476, 337);
            this.btnBottomMiddle.Name = "btnBottomMiddle";
            this.btnBottomMiddle.Size = new System.Drawing.Size(89, 93);
            this.btnBottomMiddle.TabIndex = 28;
            this.btnBottomMiddle.Tag = "?";
            this.btnBottomMiddle.UseVisualStyleBackColor = true;
            this.btnBottomMiddle.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnBottomLeft
            // 
            this.btnBottomLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBottomLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottomLeft.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btnBottomLeft.Location = new System.Drawing.Point(331, 337);
            this.btnBottomLeft.Name = "btnBottomLeft";
            this.btnBottomLeft.Size = new System.Drawing.Size(89, 93);
            this.btnBottomLeft.TabIndex = 27;
            this.btnBottomLeft.Tag = "?";
            this.btnBottomLeft.UseVisualStyleBackColor = true;
            this.btnBottomLeft.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMiddleRight
            // 
            this.btnMiddleRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiddleRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiddleRight.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btnMiddleRight.Location = new System.Drawing.Point(628, 211);
            this.btnMiddleRight.Name = "btnMiddleRight";
            this.btnMiddleRight.Size = new System.Drawing.Size(89, 93);
            this.btnMiddleRight.TabIndex = 26;
            this.btnMiddleRight.Tag = "?";
            this.btnMiddleRight.UseVisualStyleBackColor = true;
            this.btnMiddleRight.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMiddleMiddle
            // 
            this.btnMiddleMiddle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiddleMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiddleMiddle.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btnMiddleMiddle.Location = new System.Drawing.Point(476, 211);
            this.btnMiddleMiddle.Name = "btnMiddleMiddle";
            this.btnMiddleMiddle.Size = new System.Drawing.Size(89, 93);
            this.btnMiddleMiddle.TabIndex = 25;
            this.btnMiddleMiddle.Tag = "?";
            this.btnMiddleMiddle.UseVisualStyleBackColor = true;
            this.btnMiddleMiddle.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMiddleLeft
            // 
            this.btnMiddleLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiddleLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiddleLeft.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btnMiddleLeft.Location = new System.Drawing.Point(331, 211);
            this.btnMiddleLeft.Name = "btnMiddleLeft";
            this.btnMiddleLeft.Size = new System.Drawing.Size(89, 93);
            this.btnMiddleLeft.TabIndex = 19;
            this.btnMiddleLeft.Tag = "?";
            this.btnMiddleLeft.UseVisualStyleBackColor = true;
            this.btnMiddleLeft.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnTopRight
            // 
            this.btnTopRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopRight.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btnTopRight.Location = new System.Drawing.Point(628, 85);
            this.btnTopRight.Name = "btnTopRight";
            this.btnTopRight.Size = new System.Drawing.Size(89, 93);
            this.btnTopRight.TabIndex = 18;
            this.btnTopRight.Tag = "?";
            this.btnTopRight.UseVisualStyleBackColor = true;
            this.btnTopRight.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnTopMiddle
            // 
            this.btnTopMiddle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopMiddle.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btnTopMiddle.Location = new System.Drawing.Point(476, 85);
            this.btnTopMiddle.Name = "btnTopMiddle";
            this.btnTopMiddle.Size = new System.Drawing.Size(89, 93);
            this.btnTopMiddle.TabIndex = 17;
            this.btnTopMiddle.Tag = "?";
            this.btnTopMiddle.UseVisualStyleBackColor = true;
            this.btnTopMiddle.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnTopLeft
            // 
            this.btnTopLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopLeft.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btnTopLeft.Location = new System.Drawing.Point(331, 85);
            this.btnTopLeft.Name = "btnTopLeft";
            this.btnTopLeft.Size = new System.Drawing.Size(89, 93);
            this.btnTopLeft.TabIndex = 16;
            this.btnTopLeft.Tag = "?";
            this.btnTopLeft.UseVisualStyleBackColor = true;
            this.btnTopLeft.Click += new System.EventHandler(this.btn_Click);
            // 
            // Pb1
            // 
            this.Pb1.BackColor = System.Drawing.Color.Transparent;
            this.Pb1.Image = ((System.Drawing.Image)(resources.GetObject("Pb1.Image")));
            this.Pb1.Location = new System.Drawing.Point(61, 62);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(173, 108);
            this.Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb1.TabIndex = 0;
            this.Pb1.TabStop = false;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBottomRight);
            this.Controls.Add(this.btnBottomMiddle);
            this.Controls.Add(this.btnBottomLeft);
            this.Controls.Add(this.btnMiddleRight);
            this.Controls.Add(this.btnMiddleMiddle);
            this.Controls.Add(this.btnMiddleLeft);
            this.Controls.Add(this.btnTopRight);
            this.Controls.Add(this.btnTopMiddle);
            this.Controls.Add(this.btnTopLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblWi);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.Pb1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicTacToe";
            this.Text = "Tic Tac Toe game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb1;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblWi;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTopLeft;
        private System.Windows.Forms.Button btnTopMiddle;
        private System.Windows.Forms.Button btnTopRight;
        private System.Windows.Forms.Button btnMiddleLeft;
        private System.Windows.Forms.Button btnMiddleMiddle;
        private System.Windows.Forms.Button btnMiddleRight;
        private System.Windows.Forms.Button btnBottomLeft;
        private System.Windows.Forms.Button btnBottomMiddle;
        private System.Windows.Forms.Button btnBottomRight;
    }
}

