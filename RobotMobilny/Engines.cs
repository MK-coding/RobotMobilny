using System.Collections.Generic;

namespace RobotMobilny
{
    class Engines
    {
        
        private int valueLeft=0 , valueRight=0;
        private bool isRunning;
        private Change change;
        private int power;
        public void startEngine()
        {
            if (!isRunning)
            {
                return;
            }
         
            if (change.Equals(Change.INCREASE)){
                switch(power)
                {
                    case 0:
                        valueLeft = 30;
                        valueRight = 30;
                        break;
                    case 1:
                        valueLeft = 60;
                        valueRight = 60;
                        break;
                    case 2:
                        valueLeft = 80;
                        valueRight = 80;
                        break;
                    case 3:
                        valueLeft = 100;
                        valueRight = 100;
                        break;

                }
            }
            if (change.Equals(Change.DECREASE))
            {
                switch (power)
                {
                    case 0:
                        valueLeft = -30;
                        valueRight = -30;
                        break;
                    case 1:
                        valueLeft = -60;
                        valueRight = -60;
                        break;
                    case 2:
                        valueLeft = -80;
                        valueRight = -80;
                        break;
                    case 3:
                        valueLeft = -100;
                        valueRight = -100;
                        break;

                }
            }
            if (change.Equals(Change.TURNLEFT))
            {
                

                switch (power)
                {
                    case 0:
                        valueLeft = -15;
                        valueRight = 15;
                        break;
                    case 1:
                        valueLeft = -30;
                        valueRight = 30;
                        break;
                    case 2:
                        valueLeft = -40;
                        valueRight = 40;
                        break;
                    case 3:
                        valueLeft = -50;
                        valueRight = 50;
                        break;
                }
            }
            if (change.Equals(Change.TURNRIGHT))
            {
                switch (power)
                {
                    case 0:
                        valueLeft = 15;
                        valueRight = -15;
                        break;
                    case 1:
                        valueLeft = 30;
                        valueRight = -30;
                        break;
                    case 2:
                        valueLeft = 40;
                        valueRight = -40;
                        break;
                    case 3:
                        valueLeft = 50;
                        valueRight = -50;
                        break;
                }
            }
            if (change.Equals(Change.STAY))
            {
                valueLeft = 0;
                valueRight = 0;
            }

        }
       
        public void workForward(int power)
         {
            isRunning = true;
            this.power = power;
            change = Change.INCREASE;
            
         }
        public void workBackward(int power)
        {
            isRunning = true;
            this.power = power;
            change = Change.DECREASE;
        }
        public void workLeft(int power)
        {
            isRunning = true;
            this.power = power;
            change = Change.TURNLEFT;
           
        }
        public void workRight(int power)
        {
            isRunning = true;
            this.power = power;
            change = Change.TURNRIGHT;
        }
        public void noPower()
        {
            isRunning = true;
            change = Change.STAY;
        }

        public int getLeftValue()
        {
            return valueLeft;
        }
        public int getRightValue()
        {
            return valueRight;
        }
        

    }
        enum Change
        {
            INCREASE, DECREASE , STAY , TURNLEFT , TURNRIGHT 
        }

}
