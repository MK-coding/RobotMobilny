using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.IO;
using System.Timers;
using System.Diagnostics;
using System.Windows.Forms;

namespace RobotMobilny
{
    class Robot
    {

        public int x;
        public int y;
        private int angle = 0; // TOP = 0 , BOTTOM = 180, LEFT = 270, RIGHT = 90
        private bool isDriving;
        private Direction direction;
        private int power;
      
        public void drive()
        {
            if (!isDriving)
            {
                return;
            }
            var step = power + 1;

            if (direction.Equals(Direction.FORWARD))
            {

                switch(angle)
                {
                    case 0:
                        y -= (int)step;
                        break;
                    case 90:
                        x += (int)step;
                        break;
                    case 180:
                        y += (int)step;
                        break;
                    case 270:
                        x -= (int)step;
                        break;
                }
            } 
            else if (direction.Equals(Direction.BACKWARD))
            {
                switch (angle)
                {
                    case 0:
                        y += (int)step;
                        break;
                    case 90:
                        x -= (int)step;
                        break;
                    case 180:
                        y -= (int)step;
                        break;
                    case 270:
                        x += (int)step;
                        break;
                }
            }
        }

        public void rideForward(int power)
        {
            isDriving = true;
            direction = Direction.FORWARD;
            this.power = power;
        }

        public void stop()
        {
            isDriving = false;
        }

        public void rideBackward(int power)
        {
            isDriving = true;
            direction = Direction.BACKWARD;
            this.power = power;
        }

        public void changeAngle(ChangeAngle angleChange)
        {
            if (angleChange.Equals(ChangeAngle.RIGHT))
            {
                switch (angle)
                {
                    case (int)Angle.RIGHT: this.angle = (int)Angle.BOTTOM; break;
                    case (int)Angle.TOP: this.angle = (int)Angle.RIGHT; break;
                    case (int)Angle.BOTTOM: this.angle = (int)Angle.LEFT; break;
                    case (int)Angle.LEFT: this.angle = (int)Angle.TOP; break;
                }
            } else if (angleChange.Equals(ChangeAngle.LEFT))
            {
                switch (angle)
                {
                    case (int)Angle.RIGHT: this.angle = (int)Angle.TOP; break;
                    case (int)Angle.TOP: this.angle = (int)Angle.LEFT; break;
                    case (int)Angle.BOTTOM: this.angle = (int)Angle.RIGHT; break;
                    case (int)Angle.LEFT: this.angle = (int)Angle.BOTTOM; break;
                }
            }
        }

        public RepaintPosition getPosition()
        {
            return new RepaintPosition(angle, x, y);
        }
    }

    class Board
    {

        public void repaint(PaintEventArgs cursorToForm, RepaintPosition position)
        {
            var robotImage = new Bitmap("polulu.png");
            switch(position.angle)
            {
                case (int) Angle.TOP:
                    robotImage.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                    break;
                case (int) Angle.BOTTOM:
                    robotImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
                case (int) Angle.LEFT:
                    robotImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                case (int) Angle.RIGHT:
                    robotImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
            }
            cursorToForm.Graphics.TranslateTransform(0, 0);
            //cursorToForm.Graphics.RotateTransform(position.angle);
            cursorToForm.Graphics.DrawImage(robotImage, position.x, position.y, 30, 30);
        }
        
    }

    class RepaintPosition
    {
        public int angle;
        public int x;
        public int y;

        public RepaintPosition(int angle, int x, int y)
        {
            this.angle = angle;
            this.x = x;
            this.y = y;
        }

    }

    enum ChangeAngle: int
    {
        RIGHT = 90, LEFT = -90
    }

    enum Angle
    {
        TOP = 0, BOTTOM = 180, LEFT = 270, RIGHT = 90
    }

    enum Direction
    {
        FORWARD, BACKWARD
    }
}
