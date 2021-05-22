using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRobotSurvival.Moving
{
    public class Position
    {
        private Point point = new Point();
        public const string fileName = @"../../../JsonSaves/Position.json";
        private Moving.Rotate rotate = new Moving.Rotate();
        public Position(Point size)
        {
            point.X = size.X;
            point.Y = size.Y;
        }
        public Position() : this(new Point(0, 0)) { }
        public void Go(int number)
        {
            Moving.RotateFileSave rotateFile = new Moving.RotateFileSave();
            rotate = rotateFile.Load();
            for (int i = 0; i < number; i++)
            {
                if (rotate.isTop)
                {
                    point = new Point(point.X, point.Y - 5);
                }
                else if (rotate.isBack)
                {
                    point = new Point(point.X, point.Y + 5);
                }
                else if (rotate.isLeft)
                {
                    point = new Point(point.X + 5, point.Y);
                }
                else if (rotate.isRight)
                {
                    point = new Point(point.X - 5, point.Y);
                }
                CodeGame.MyForm.SetPlayerPoint(point);
                CodeGame.MyForm.Refresh();
            }
        }
    }
}
