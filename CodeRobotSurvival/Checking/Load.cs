using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRobotSurvival.Checking
{
    public class Load
    {
        private Moving.Position move = new Moving.Position();
        private Moving.Rotate rotate = new Moving.Rotate();
        private string tmp = null;
        private bool isMove = false;
        private int number = 0;
        public Load()
        {
            Moving.RotateFileSave rotateSave = new Moving.RotateFileSave();
            rotate = rotateSave.Load();
            Moving.PosSaveFile posSaveFile = new Moving.PosSaveFile();
            move = posSaveFile.Load();
        }
        public void Check()
        {
            foreach (char item in CodeGame.MyForm.tbCode.Text)
            {
                if (!isMove)
                {
                    tmp += item;
                }
                if (tmp == "move.Go(")
                {
                    isMove = true;
                    if (item == ';')
                    {
                        move.Go(number);
                        tmp = null;
                        isMove = false;
                    }
                    if (Char.IsDigit(item))
                    {
                        number *= 10;
                        number += Int32.Parse(Convert.ToString(item));
                    }
                }
                if (tmp == "rotate.RotateTop(")
                {
                    isMove = true;
                    if (item == ';')
                    {
                        rotate.RotateTop();
                        Moving.RotateFileSave rotateSave = new Moving.RotateFileSave();
                        rotateSave.Save(rotate);
                        tmp = null;
                        isMove = false;
                    }
                }
                if (tmp == "rotate.RotateDown(")
                {
                    isMove = true;
                    if (item == ';')
                    {
                        rotate.RotateDown();
                        Moving.RotateFileSave rotateSave = new Moving.RotateFileSave();
                        rotateSave.Save(rotate);
                        tmp = null;
                        isMove = false;
                    }
                }
                if (tmp == "rotate.RotateLeft(")
                {
                    isMove = true;
                    if (item == ';')
                    {
                        rotate.RotateLeft();
                        Moving.RotateFileSave rotateSave = new Moving.RotateFileSave();
                        rotateSave.Save(rotate);
                        tmp = null;
                        isMove = false;
                    }
                }
                if (tmp == "rotate.RotateRight(")
                {
                    isMove = true;
                    if (item == ';')
                    {
                        rotate.RotateRight();
                        Moving.RotateFileSave rotateSave = new Moving.RotateFileSave();
                        rotateSave.Save(rotate);
                        tmp = null;
                        isMove = false;
                    }
                }
            }
        }
    }
}
