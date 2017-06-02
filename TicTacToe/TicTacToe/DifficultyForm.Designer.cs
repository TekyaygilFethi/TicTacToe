namespace TicTacToe
{
    partial class DifficultyForm
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
            this.easyButton = new DevExpress.XtraEditors.SimpleButton();
            this.DifficultButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.RandomButton = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // easyButton
            // 
            this.easyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.easyButton.Location = new System.Drawing.Point(124, 120);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(99, 41);
            this.easyButton.TabIndex = 0;
            this.easyButton.Text = "EASY";
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            this.easyButton.MouseEnter += new System.EventHandler(this.simpleButton1_MouseEnter);
            this.easyButton.MouseLeave += new System.EventHandler(this.simpleButton1_MouseLeave);
            // 
            // DifficultButton
            // 
            this.DifficultButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DifficultButton.Location = new System.Drawing.Point(457, 120);
            this.DifficultButton.Name = "DifficultButton";
            this.DifficultButton.Size = new System.Drawing.Size(100, 41);
            this.DifficultButton.TabIndex = 1;
            this.DifficultButton.Text = "DIFFICULT";
            this.DifficultButton.Click += new System.EventHandler(this.DifficultButton_Click);
            this.DifficultButton.MouseEnter += new System.EventHandler(this.simpleButton2_MouseEnter);
            this.DifficultButton.MouseLeave += new System.EventHandler(this.simpleButton2_MouseLeave);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(12, 500);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(69, 21);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = " TURN BACK";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(353, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(360, 25);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Please enter the difficulty of the game";
            // 
            // RandomButton
            // 
            this.RandomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomButton.Location = new System.Drawing.Point(779, 120);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(100, 41);
            this.RandomButton.TabIndex = 8;
            this.RandomButton.Text = "RANDOM";
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            this.RandomButton.MouseEnter += new System.EventHandler(this.RandomButton_MouseEnter);
            this.RandomButton.MouseLeave += new System.EventHandler(this.RandomButton_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TicTacToe.Properties.Resources.article_0_0F5A043100000578_643_468x531;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(724, 167);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(187, 172);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TicTacToe.Properties.Resources.google_deepmind_artificial_intelligence;
            this.pictureBox2.Location = new System.Drawing.Point(411, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 172);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicTacToe.Properties.Resources.brain_jpg_adapt_945_1;
            this.pictureBox1.Location = new System.Drawing.Point(81, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // DifficultyForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 542);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.DifficultButton);
            this.Controls.Add(this.easyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DifficultyForm";
            this.Text = "DifficultyForm";
            this.Load += new System.EventHandler(this.DifficultyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton easyButton;
        private DevExpress.XtraEditors.SimpleButton DifficultButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.SimpleButton RandomButton;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}