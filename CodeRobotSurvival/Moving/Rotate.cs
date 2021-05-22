using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CodeRobotSurvival.Moving
{
    public class Rotate
    {
        public const string fileName = @"../../../JsonSaves/Rotate.json";
        public bool isTop { get; private set; }
        public bool isBack { get; private set; }
        public bool isLeft { get; private set; }
        public bool isRight { get; private set; }
        public Rotate(bool isTop, bool isLeft, bool isRight, bool isBack)
        {
            this.isTop = isTop;
            this.isLeft = isLeft;
            this.isRight = isRight;
            this.isBack = isBack;
            Update();
        }
        public Rotate()
        {
            Update();
        }
        public Rotate(Rotate rotate)
        {
            this.isTop = rotate.isTop;
            this.isLeft = rotate.isLeft;
            this.isRight = rotate.isRight;
            this.isBack = rotate.isBack;
            Update();
        }
        public void Update()
        {
            if (isTop)
            {
                RotateTop();
            }
            else if (isLeft)
            {
                RotateLeft();
            }
            else if (isRight)
            {
                RotateRight();
            }
            else if (isBack)
            {
                RotateDown();
            }
        }
        public void RotateTop()
        {
            isTop = true;
            isBack = false;
            isLeft = false;
            isRight = false;

            CodeGame.MyForm.ChangePlayerState(new Bitmap(Image.FromFile(@"../../../Images/cube.png")));
        }
        public void RotateDown()
        {
            isTop = false;
            isBack = true;
            isLeft = false;
            isRight = false;

            CodeGame.MyForm.ChangePlayerState(new Bitmap(Image.FromFile(@"../../../Images/cube_3.png")));
        }

        public void RotateLeft()
        {
            isTop = false;
            isBack = false;
            isLeft = true;
            isRight = false;

            CodeGame.MyForm.ChangePlayerState(new Bitmap(Image.FromFile(@"../../../Images/cube_1.png")));
        }
        public void RotateRight()
        {
            isTop = false;
            isBack = false;
            isLeft = false;
            isRight = true;

            CodeGame.MyForm.ChangePlayerState(new Bitmap(Image.FromFile(@"../../../Images/cube_2.png")));
        }
    }
}
