using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CodeRobotSurvival
{
    public class GeneratePlayerPosition
    {
        private Point startPoint = new Point();
        private Random random = new Random();
        public void GenerateRandomPosition()
        {
            startPoint = new Point(random.Next(0, 800), random.Next(500));
            CodeGame.MyForm.SetPlayerPoint(startPoint);
        }
    }
}
