using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_1._2
{
    public class Icon
    {
        public string name;
        private int iconwidth;
        private int iconheight;
        private Point position;
        private Rectangle icon;

        public Icon(int iconwidth, int iconheight, string imagepath)
        { 
            this.iconwidth = iconwidth;
            this.iconheight = iconheight;
            name = imagepath;
        }
        /*
        public string Name() {  return name; }
        public double X() {  return ; }
        public double Y() {  return name; }
        public int IconWidth() {  return name; }
        public int IconHeight() {  return name; }
        public Rectangle GetIcon() {  return name; }
        public void SetPosition(Point newPos) { position = newPos; }
        //public bool IsMouseOver(Point MousePos) {  return name; }
        //public Rectangle CloneIcon() {  return name; }*/
    }
}
