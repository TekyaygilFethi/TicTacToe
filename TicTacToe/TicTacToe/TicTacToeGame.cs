using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        Button[,] boardButtons;
        public int ProcessCount;

        public enum Piece { Empty = 0, X = 1, O = 2 };

        static int[,] winConditions = new int[8, 3]
        {
        { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, //Horizontal Conditions
        { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, //Vertical Conditions
        { 0, 4, 8 }, { 2, 4, 6 } //Diagonal Conditions
        };

        public Piece[] Grid = new Piece[9]; //this grid will hold the current game status.

        public Piece CurrentTurn = Piece.X;

        int Choice = 0;

        public string DifficultyChoice = null;

        public Piece Computer;
        public Piece Player;

        public TicTacToeGame()
        {
            Player = Piece.X;
            Computer = Piece.O;
         // CurrentTurn = Piece.X;
        }

        public void Reset()
        {
            foreach (var v in boardButtons)
            {
                v.BackgroundImage = null;
            }


            ProcessCount = 0;
            CurrentTurn = Piece.X;
            SetPlayer(Piece.X);
            Grid = new Piece[9];
        }

        public void SetPlayer(Piece Player)
        {
            this.Player = Player;
            this.Computer = switchPiece(Player);
        }

        public void MakeMove(int Move)
        {
            if (CurrentTurn == Player)
            {
                Grid = makeGridMove(Grid, CurrentTurn, Move);
                CurrentTurn = switchPiece(CurrentTurn);
            }
            else if (CurrentTurn == Computer)
            {
                chooseMinimax(DifficultyChoice, Grid, CurrentTurn);
                Grid = makeGridMove(Grid, CurrentTurn, Choice);
                CurrentTurn = switchPiece(CurrentTurn);
            }
        }

        public int minimaxDifficult(Piece[] InputGrid, Piece ComputerPl)
        {
            Piece[] Grid = cloneGrid(InputGrid);

            if (checkScore(Grid, ComputerPl) != 0)
                return checkScore(Grid, Computer);
            else if (checkGameEnd(Grid)) return 0;

            List<int> scores = new List<int>();
            List<int> moves = new List<int>();

            for (int i = 0; i < 9; i++)
            {
                if (Grid[i] == Piece.Empty)
                {
                    scores.Add(minimaxDifficult(makeGridMove(Grid, ComputerPl, i), switchPiece(ComputerPl))); //ComputerPl=Player
                    moves.Add(i);
                }
            }

            if (ComputerPl == Computer)
            {
                int MaxScoreIndex = scores.IndexOf(scores.Max());
                Choice = moves[MaxScoreIndex];
                return scores.Max();
            }

            else
            {
                int MinScoreIndex = scores.IndexOf(scores.Min());
                Choice = moves[MinScoreIndex];
                return scores.Min();
            }
        }

        public int minimaxEasy(Piece[] InputGrid, Piece PlayerPl)
        {
            Piece[] Grid = cloneGrid(InputGrid);

            if (checkScore(Grid, PlayerPl) != 0)
                return checkScore(Grid, Computer);
            else if (checkGameEnd(Grid)) return 0;

            List<int> scores = new List<int>();
            List<int> moves = new List<int>();

            for (int i = 0; i < 9; i++)
            {
                if (Grid[i] == Piece.Empty)
                {
                    scores.Add(minimaxEasy(makeGridMove(Grid, Player, i), switchPiece(Player))); //ComputerPl=Player
                    moves.Add(i);
                }
            }

            if (PlayerPl == Player)//deneme
            {
                int MaxScoreIndex = scores.IndexOf(scores.Max());
                Choice = moves[MaxScoreIndex];
                return scores.Max();
            }
            else
            {
                int MinScoreIndex = scores.IndexOf(scores.Min());
                Choice = moves[MinScoreIndex];
                return scores.Min();
            }
        }

        static int checkScore(Piece[] Grid, Piece Computer)
        {
            if (checkGameWin(Grid, Computer)) return 1;

            else if (checkGameWin(Grid, switchPiece(Computer))) return -1;

            else return 0;
        }

        static bool checkGameWin(Piece[] Grid, Piece Computer) //AI checks if it wins.
        {
            for (int i = 0; i < 8; i++)
            {
                if (Grid[winConditions[i, 0]] == Computer && Grid[winConditions[i, 1]] == Computer && Grid[winConditions[i, 2]] == Computer)
                {
                    return true;
                }
            }
            return false;
        }

        static bool checkGameEnd(Piece[] Grid) //If there are end places in board return false
        {
            foreach (Piece p in Grid) if (p == Piece.Empty) return false;
            return true;
        }

        static Piece switchPiece(Piece Piece)
        {
            if (Piece == Piece.X) return Piece.O;
            else return Piece.X;
        }

        static Piece[] cloneGrid(Piece[] Grid)
        {
            Piece[] Clone = new Piece[9];
            for (int i = 0; i < 9; i++) Clone[i] = Grid[i];

            return Clone;
        }

        static Piece[] makeGridMove(Piece[] Grid, Piece Move, int Position) //Place X or O
        {
            Piece[] newGrid = cloneGrid(Grid);
            newGrid[Position] = Move;
            return newGrid;
        }

        public void writeSigns(Button[,] BoardButtons)
        {
            for (int i = 0; i < Grid.Length; i++)
            {
                if (Grid[i].ToString() == "O")
                {
                    Image SelectedImage = Image.FromFile("O.png");
                    BoardButtons.OfType<Button>().Where(w => w.Name == (i + 1).ToString()).SingleOrDefault().BackgroundImage = SelectedImage;
                    BoardButtons.OfType<Button>().Where(w => w.Name == (i + 1).ToString()).SingleOrDefault().BackgroundImageLayout = ImageLayout.Stretch;
                    BoardButtons.OfType<Button>().Where(w => w.Name == (i + 1).ToString()).SingleOrDefault().Text = "";
                    BoardButtons.OfType<Button>().Where(w => w.Name == (i + 1).ToString()).SingleOrDefault().Enabled = false;
                }

                else if (Grid[i].ToString() == "X")
                {
                    Image SelectedImage = Image.FromFile("X.png");
                    BoardButtons.OfType<Button>().Where(w => w.Name == (i + 1).ToString()).SingleOrDefault().BackgroundImage = SelectedImage;
                    BoardButtons.OfType<Button>().Where(w => w.Name == (i + 1).ToString()).SingleOrDefault().BackgroundImageLayout = ImageLayout.Stretch;
                    BoardButtons.OfType<Button>().Where(w => w.Name == (i + 1).ToString()).SingleOrDefault().Text = "";
                }
                else
                    BoardButtons.OfType<Button>().Where(w => w.Name == (i + 1).ToString()).SingleOrDefault().Text = Grid[i].ToString();
            }
        }

        public void setBoard(Button[,] boardButtons)
        {
            this.boardButtons = boardButtons;
        }

        public void startGame(int buttonPressedCount)
        {
            MakeMove(buttonPressedCount); //For player
            MakeMove(buttonPressedCount); //For AI
            writeSigns(boardButtons);
            DisableOButtons();
            ProcessCount++;
            /*  }
              else
              {
                  MakeMove(buttonPressedCount);
                  MakeMove(buttonPressedCount);
                  writeSigns(boardButtons);
                  DisableOButtons();
                  ProcessCount++;
              }*/
            if (checkGameWin(Grid, Computer))
            {
                MessageBox.Show("Computer Wins");
                disableAllButtons();
            }

            if (checkGameWin(Grid, Player))
            {
                MessageBox.Show("Player Wins!");
                disableAllButtons();
            }

            if (ProcessCount == 5 && !checkGameWin(Grid, Player) && !checkGameWin(Grid, Computer))
            {
                MessageBox.Show("Draw");
                disableAllButtons();
            }

        }

        public void DisableOButtons()
        {
            foreach (var button in boardButtons)
            {
                if (button.Text == "O")
                {
                    button.Enabled = false;
                }
            }
        }

        public void disableAllButtons()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    boardButtons[i, j].Enabled = false;
                }
            }
        }

        public void EnableAllButtons()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    boardButtons[i, j].Enabled = true;
                }
            }
        }

        public int chooseMinimax(string PlayerChoice, Piece[] Grid, Piece CurrentTurn)
        {
            if (PlayerChoice == "Easy")
            {
                return minimaxEasy(cloneGrid(Grid), CurrentTurn);
            }

            else if (PlayerChoice == "Difficult")
            {
                return minimaxDifficult(cloneGrid(Grid), CurrentTurn);
            }
            else
            {
                List<string> choices = new List<string>();
                choices.Add("Easy");
                choices.Add("Difficult");

                Random rand = new Random();

                string randChosen = choices[rand.Next(2)];

                return chooseMinimax(randChosen, Grid, CurrentTurn);
            }



        }
    }
}
