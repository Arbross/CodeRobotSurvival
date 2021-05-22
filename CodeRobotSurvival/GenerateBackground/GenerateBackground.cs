using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeRobotSurvival.GenerateBackground
{
    public class GenerateBackground
    {
        private Random random = new Random();
        private Point point = new Point();
        private Rectangle rectangle = new Rectangle();
        public bool isPainted { get; set; }
        public Rectangle GetRectangle()
        {
            rectangle.Width = 30;
            rectangle.Height = 30;
            point.X += 30;
            rectangle.Location = point; 
            return rectangle;
        }

    }
}
