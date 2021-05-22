using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Microsoft.CSharp;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace CodeRobotSurvival
{
    public partial class CodeGame : Form
    {
        private GenerateBackground.GenerateBackground background = new GenerateBackground.GenerateBackground();
        public static CodeGame MyForm { get; private set; }
        private Point lastPos;
        public CodeGame()
        {
            InitializeComponent();

            Moving.RotateFileSave rotatef = new Moving.RotateFileSave();
            Moving.Rotate rotate = new Moving.Rotate();
            rotate = rotatef.Load();
            label1.Text = $"Top : {rotate.isTop}\nLeft : {rotate.isLeft}\nRight : {rotate.isRight}\nDown : {rotate.isBack}";



            lastPos = new Point();
            MyForm = this;
            GeneratePlayerPosition generatePlayerPosition = new GeneratePlayerPosition();
            generatePlayerPosition.GenerateRandomPosition();
        }
        private void panelGame_Paint(object sender, PaintEventArgs e)
        {
            // Draw player moves
            Graphics graphics = e.Graphics;
            if (pbPlayer.Location.X < 0 || pbPlayer.Location.X > 962)
            {
                pbPlayer.Location = new Point(0, 0);
            }
            if (pbPlayer.Location.Y < 0 || pbPlayer.Location.Y > 565)
            {
                pbPlayer.Location = new Point(0, 0);
            }
            var playerRectangle = new Rectangle(pbPlayer.Location.X, pbPlayer.Location.Y, 100, 100);
            playerRectangle.Width = 50;
            playerRectangle.Height = 50;
            graphics.DrawImage(pbPlayer.Image, playerRectangle);
        }
        public void ChangePlayerState(Bitmap bitmap)
        {
            pbPlayer.Image = bitmap;
            pbPlayer.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public void SetPlayerPoint(Point point)
        {
            lastPos = pbPlayer.Location;
            pbPlayer.Location = point;
        }
        public Point GetPlayerPoint()
        {
            return pbPlayer.Location;
        }
        private void CodeGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Moving.Position position = new Moving.Position(pbPlayer.Location);
            Moving.PosSaveFile posSaveFile = new Moving.PosSaveFile();
            posSaveFile.Save(position);
            Moving.RotateFileSave rotateSave = new Moving.RotateFileSave();
            rotateSave.Save(rotateSave.Load());
            Launcher.MyForm.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Checking.Load load = new Checking.Load();
            load.Check();
        }      
    }
}
