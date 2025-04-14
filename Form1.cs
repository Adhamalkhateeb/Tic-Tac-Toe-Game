using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        stGameStatus GameStatus;
        enum enPlayer { Player1 ,Player2 };
        enPlayer PlayerTurn = enPlayer.Player1;

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;

        }

        void EndGame()
        {

            lblPlayer.Text = "Game Over";
            switch (GameStatus.Winner)
            {

                case enWinner.Player1:

                    lblWinner.Text = "Player1";
                    break;

                case enWinner.Player2:

                    lblWinner.Text = "Player2";
                    break;

                default:

                    lblWinner.Text = "Draw";
                    break;

            }

            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {


            if (btn1.Tag.ToString() != "?" && ((btn1.Tag.ToString() == btn2.Tag.ToString()) && (btn1.Tag.ToString() == btn3.Tag.ToString())))
            {

                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }

            }

            GameStatus.GameOver = false;
            return false;


        }
        void CheckWinner()
        {
            if (CheckValues(btnTopLeft, btnTopMiddle, btnTopRight))
                return;

            if (CheckValues(btnTopLeft, btnMiddleLeft, btnBottomLeft))
                return;

            if (CheckValues(btnTopLeft, btnMiddleMiddle, btnBottomRight))
                return;

            if (CheckValues(btnTopMiddle, btnMiddleMiddle, btnBottomMiddle))
                return;

            if (CheckValues(btnTopRight, btnMiddleRight,btnBottomRight))
                return;
            if (CheckValues(btnTopRight, btnMiddleMiddle, btnBottomLeft))
                return;

            if (CheckValues(btnMiddleLeft, btnMiddleMiddle, btnMiddleRight))
                return;

            if (CheckValues(btnBottomLeft, btnBottomMiddle,btnBottomRight))
                return;

        }

       public void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {

                switch(PlayerTurn)
                {
                    case enPlayer.Player1:
                    btn.Image = Resources.X;
                    PlayerTurn= enPlayer.Player2;
                    btn.Tag  = "X";
                    lblPlayer.Text = "Player 2";
                    GameStatus.PlayCount++;
                    CheckWinner();
                    break;
                    case enPlayer.Player2:
                    btn.Image = Resources.O;
                    PlayerTurn= enPlayer.Player1;
                    btn.Tag  = "O";
                    lblPlayer.Text = "Player 1";
                    GameStatus.PlayCount++;
                    CheckWinner();
                    break;
                    
                }
            }
            else

                {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStatus.PlayCount ==9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }

        private void ResetButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
        }

        private void RestartGame()
        {
            ResetButton(btnTopLeft);
            ResetButton(btnTopRight);
            ResetButton(btnTopMiddle);
            ResetButton(btnBottomRight);
            ResetButton(btnBottomMiddle);
            ResetButton(btnBottomLeft);
            ResetButton(btnMiddleLeft);
            ResetButton(btnMiddleRight);
            ResetButton(btnMiddleMiddle);

            PlayerTurn = enPlayer.Player1;
            lblPlayer.Text = "Player 1";
            lblWinner.Text = "In Progress";
            GameStatus.PlayCount = 0;
            GameStatus.Winner = enWinner.GameInProgress;
            GameStatus.GameOver = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.FromArgb(255, 255, 255, 255);
            Pen pen = new Pen(color);
            pen.Width = 15;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 300, 320, 750, 320);
            e.Graphics.DrawLine(pen, 300, 200, 750, 200);
            e.Graphics.DrawLine(pen, 600, 100, 600, 420);
            e.Graphics.DrawLine(pen, 450, 100, 450, 420);
        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }
    }
};
