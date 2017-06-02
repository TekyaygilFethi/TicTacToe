using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TicTacToe
{
    public partial class DifficultyForm : DevExpress.XtraEditors.XtraForm
    {
        TicTacToeGame game;
        Form1 frm1;
        Image pb1ColorPic;
        Image pb2ColorPic;
        Image pb3ColorPic;

        public DifficultyForm()
        {
            InitializeComponent();
        }

        private void DifficultyForm_Load(object sender, EventArgs e)
        {
            pb1ColorPic = pictureBox1.Image;
            pb2ColorPic = pictureBox2.Image;
            pb3ColorPic = pictureBox3.BackgroundImage;

            pictureBox1.Image = GrayScaleFilter((Bitmap)pictureBox1.Image);
            pictureBox2.Image = GrayScaleFilter((Bitmap)pictureBox2.Image);
            pictureBox3.BackgroundImage = GrayScaleFilter((Bitmap)pictureBox3.BackgroundImage);

        }

        public Bitmap GrayScaleFilter(Bitmap image)
        {
            Bitmap grayScale = new Bitmap(image.Width, image.Height);

            for (Int32 y = 0; y < grayScale.Height; y++)
                for (Int32 x = 0; x < grayScale.Width; x++)
                {
                    Color c = image.GetPixel(x, y);

                    Int32 gs = (Int32)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);

                    grayScale.SetPixel(x, y, Color.FromArgb(gs, gs, gs));
                }
            return grayScale;
        }

        private void simpleButton1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = pb1ColorPic;
        }

        private void simpleButton2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = pb2ColorPic;
        }

        private void simpleButton1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = GrayScaleFilter((Bitmap)pictureBox1.Image);
        }

        private void simpleButton2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = GrayScaleFilter((Bitmap)pictureBox2.Image);
        }

        private void RandomButton_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = pb3ColorPic;
        }

        private void RandomButton_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = GrayScaleFilter((Bitmap)pictureBox3.BackgroundImage);
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            game = new TicTacToeGame();
            game.DifficultyChoice = "Easy";
            frm1 = new Form1(game);
            frm1.Show();
            this.Hide();
        }

        private void DifficultButton_Click(object sender, EventArgs e)
        {
            game = new TicTacToeGame();
            game.DifficultyChoice = "Difficult";
            frm1 = new Form1(game);
            frm1.Show();
            this.Hide();

        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            game = new TicTacToeGame();
            game.DifficultyChoice = "Random";
            frm1 = new Form1(game);
            frm1.Show();
            this.Hide();

        }

        
    }
}