using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;



namespace SETMystify
{
    class LINE
    {
        public static int maxSpeed = 11;        //max speed of line
        public static int minSpeed = 2;         //min speed of line
        private const int positiveDir = 0;      //positive direction
        private const int negativeDir = 1;      //negative direction
        private Color lineColour;               //colour of this line
        private Point p1 = new Point(0, 0);     //one of the points the line is drawn between
        private Point p2 = new Point(0, 0);     //the other point
        private Random rand = new Random();     //random seed
        private int speedX1 = 0;                //speed of x for p1
        private int speedX2 = 0;                //speed of x for p2
        private int directionX1 = 0;            //direction of x for p1
        private int directionX2 = 0;            //direction of x for p2
        private int speedY1 = 0;                //speed of y for p1
        private int speedY2 = 0;                //speed of y for p2
        private int directionY1 = 0;            //direction of y for p1
        private int directionY2 = 0;            //direction of y for p2

        //list of all points in the line
        private List<Point[]> tail = new List<Point[]>();

        //image graphics
        private Graphics drawGraphics;          

        public LINE(Graphics G)
        {
            //set intial x and y values for both points to random positions on the panel
            p1.X = rand.Next(1, frmMain.maxWidth - 1);
            p1.Y = rand.Next(1, frmMain.maxHeight - 1);
            p2.X = rand.Next(1, frmMain.maxWidth - 1);
            p2.Y = rand.Next(1, frmMain.maxHeight - 1);

            //set initial x and y speeds for both points to random speeds
            speedX1 = rand.Next(minSpeed, maxSpeed);
            speedX2 = rand.Next(minSpeed, maxSpeed);
            speedY1 = rand.Next(minSpeed, maxSpeed);
            speedY2 = rand.Next(minSpeed, maxSpeed);

            //randomly set intial x and y directions for both points
            directionX1 = rand.Next(0, 2);
            directionX2 = rand.Next(0, 2);
            directionY1 = rand.Next(0, 2);
            directionY2 = rand.Next(0, 2);

            //set the graphics
            drawGraphics = G;

            //randomly generate a colour for the line
            int randR = rand.Next(20, 255);
            int randG = rand.Next(20, 255);
            int randB = rand.Next(20, 255);
            lineColour = Color.FromArgb(randR, randG, randB);
        }


        public void getPoints()
        {
            //change the x value of p1 based on direction and speed
            if (directionX1 == positiveDir)
            {
                p1.X += speedX1;
            }
            else
            {
                p1.X -= speedX1;
            }

            //change the y value of p1 based on direction and speed
            if (directionY1 == positiveDir)
            {
                p1.Y += speedY1;
            }
            else
            {
                p1.Y -= speedY1;
            }

            //change the x value of p2 based on direction and speed
            if (directionX2 == positiveDir)
            {
                p2.X += speedX2;
            }
            else
            {
                p2.X -= speedX2;
            }

            //change the y value of p2 based on direction and speed
            if (directionY2 == positiveDir)
            {
                p2.Y += speedY2;
            }
            else
            {
                p2.Y -= speedY2;
            }

            //change the direction for the x value of p1 if a boundary is hit
            if (p1.X > frmMain.maxWidth || p1.X < 0)
            {
                speedX1 = rand.Next(minSpeed, maxSpeed);
                if (p1.X < 0)
                {
                    p1.X = 0;
                    directionX1 = positiveDir;
                }
                else
                {
                    directionX1 = negativeDir;
                }

            }
            //change the direction for the y value of p1 if a boundary is hit
            else if (p1.Y > frmMain.maxHeight || p1.Y < 0)
            {
                speedY1 = rand.Next(minSpeed, maxSpeed);
                if (p1.Y < 0)
                {
                    p1.Y = 0;
                    directionY1 = positiveDir;
                }
                else
                {
                    directionY1 = negativeDir;
                }

            }

            //change the direction for the x value of p2 if a boundary is hit
            if (p2.X > frmMain.maxWidth || p2.X < 0)
            {
                speedX2 = rand.Next(minSpeed, maxSpeed);
                if (p2.X < 0)
                {
                    p2.X = 0;
                    directionX2 = positiveDir;
                }
                else
                {
                    directionX2 = negativeDir;
                }

            }
            //change the direction for the y value of p2 if a boundary is hit
            else if (p2.Y > frmMain.maxHeight || p2.Y < 0)
            {
                speedY2 = rand.Next(minSpeed, maxSpeed);
                if (p2.Y < 0)
                {
                    p2.Y = 0;
                    directionY2 = positiveDir;
                }
                else
                {
                    directionY2 = negativeDir;
                }
                
            }
            
            //insert the new line at the front of the list of points
            tail.Insert(0, new Point[] { p1, p2 });
            if (tail.Count > 21)
            {
                //remove the last line
                tail.RemoveAt(21);
            }

        }

        public void drawLine()
        {
            bool draw = true;                   //bool for drawing
            int i = tail.Count - 1;             //index for the tail
            Color tempColour = lineColour;      //colour to use
            
            //reset to 0 if less than 0 for some reason
            if (i < 0)
            {
                i = 0;
            }
            //set index to taillength if the tail count is larger
            else if (i > frmMain.tailLength)
            {
                i = frmMain.tailLength;
            }

            //temp colours for fade
            int tempR = 0;
            int tempG = 0;
            int tempB = 0;
            //increase amount for fade
            int increaseR = 0;
            int increaseG = 0;
            int increaseB = 0;
            //set increase amount
            if (frmMain.tailLength > 0)
            {
                increaseR = lineColour.R / frmMain.tailLength;
                increaseG = lineColour.G / frmMain.tailLength;
                increaseB = lineColour.B / frmMain.tailLength;
            }

            //get the points for the new line
            getPoints();

            //if the taillength is 0, dont draw it            
            if (frmMain.tailLength <= 0)
            {
                draw = false;
            }

            //draw while there are lines to draw
            while(draw)
            {
                //set the colour if the fadelines is on
                if (frmMain.fadeLines)
                {
                    tempColour = Color.FromArgb(tempR, tempG, tempB);
                }
                else
                {
                    tempColour = lineColour;
                }
                
                
                //draw a line
                drawGraphics.DrawLines(new Pen(tempColour, 2), tail[i]);

                //increase the rgb if fadelines is on
                if (frmMain.fadeLines)
                {
                    tempR += increaseR;
                    tempG += increaseG;
                    tempB += increaseB;
                }
                
                //increase the index
                i--;

                //stop drawing if the index is larger than the current set taillength
                if (i == -1)
                {
                    draw = false;
                }
                
            }
        }



    }
}
