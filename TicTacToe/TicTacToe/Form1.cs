using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        TicTacToeGame game;
        Button[,] boardButtons;
        int[] ClickCounts = new int[9];

        public Form1(TicTacToeGame game)
        {
            this.game = game; 
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createBoard();
        }
        
        private void createBoard()
        {
            int TextCounter = 1;
            boardButtons = new Button[3, 3];
            int width = panel1.Width, height = panel1.Height;//We get Width and Height of the Chess Panel.
            int xSize = (int)((double)width / (double)3);//X dimesion Size of the Button
            int ySize = (int)((double)height / (double)3);//Y dimension size of the Button
            
            boardButtons[0, 0] = button1;
            boardButtons[0, 1] = button2;
            boardButtons[0, 2] = button3;
            boardButtons[1, 0] = button4;
            boardButtons[1, 1] = button5;
            boardButtons[1, 2] = button6;
            boardButtons[2, 0] = button7;
            boardButtons[2, 1] = button8;
            boardButtons[2, 2] = button9;
            
            for (int row = 0; row < boardButtons.GetLength(0); row++)
            {
                for (int column = 0; column < boardButtons.GetLength(1); column++)
                {
                   boardButtons[row, column].Name = TextCounter.ToString();

                   boardButtons[row, column].FlatStyle = FlatStyle.Popup; // set every picture box's border.(Otherwise picture boxes will have no border and graphical interface will be insufficient.

                    boardButtons[row, column].Location = new Point(column * xSize, row * ySize);//place pictureboxes side by side(new picture box will be shift to right by the size of the picture box)

                    boardButtons[row, column].Size = new Size(xSize, ySize);//make every picturebox's size is equal and fit to panel as expected.

                    boardButtons[row, column].Parent = panel1;
                    TextCounter++;
                }
            }
            
            game.setBoard(boardButtons);

            game.writeSigns(boardButtons);
        }
        
        #region CLICK EVENTS

        private void button1_Click(object sender, EventArgs e)
        {
            game.startGame(int.Parse(boardButtons[0, 0].Name) - 1);
            button1.Enabled=false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.startGame(int.Parse(boardButtons[0, 1].Name) - 1);
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            game.startGame(int.Parse(boardButtons[0, 2].Name) - 1);
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            game.startGame(int.Parse(boardButtons[1, 0].Name) - 1);
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            game.startGame(int.Parse(boardButtons[1, 1].Name) - 1);
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            game.startGame(int.Parse(boardButtons[1, 2].Name) - 1);
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            game.startGame(int.Parse(boardButtons[2, 0].Name) - 1);
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            game.startGame(int.Parse(boardButtons[2, 1].Name) - 1);
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            game.startGame(int.Parse(boardButtons[2, 2].Name) - 1);
            button9.Enabled = false;
        }
        #endregion

        private void button10_Click(object sender, EventArgs e)
        {
            game.Reset();
            game.EnableAllButtons();
            game.writeSigns(boardButtons);
            chooseDifficulty();
            this.Close();
        }
        
        private void chooseDifficulty()
        {
            DifficultyForm df = new DifficultyForm();
            df.Show();
        }
    }
}
