using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SETMystify
{
    public partial class frmMain : Form
    {
        private const int maxSpeed = 11;        //max speed constant
        private const int minSpeed = 2;         //min speed constant
        private const int minTailLen = 10;      //minimum tail length
        public static int tailLength = 10;      //number of lines in the tail
        private int tempLen = 0;                //temporary holder for the taillength
        public static int maxWidth = 0;         //width of the panel   
        public static int maxHeight = 0;        //height of the panel
        private bool timerOn = false;           //bool for checking if timer is running
        private bool clearPanel = false;        //bool for checking if the panel is to be cleared
        public static bool fadeLines = false;   //toggle for fading lines
        private Bitmap backImage;               //image that all lines are drawing to
        private Color backColour = Color.Black;

        //list of threads and lines
        private List<threadObj> threadList = new List<threadObj>();
                
        public frmMain()
        {
            InitializeComponent();   
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //set the size based on the panel size
            maxWidth = drawPanel.Size.Width;
            maxHeight = drawPanel.Size.Height;
            //create the image based on the size
            backImage = new Bitmap(maxWidth, maxHeight);
            //disable buttons
            btnCreate.Enabled = false;
            btnClear.Enabled = false;
            btnFade.Enabled = false;
            //set the background color
            drawPanel.BackColor = backColour;
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            //clear the background image
            Graphics G = Graphics.FromImage(backImage);
            G.Clear(backColour);
            G.Dispose();

            //draw all lines to the image
            foreach (threadObj t in threadList)
            {
                t.ThisLine.drawLine();
            }

            //draw the image
            e.Graphics.DrawImage(backImage, 0, 0);
        }

        private void lineTimer_Tick(object sender, EventArgs e)
        {
            
            if (clearPanel)
            {
                //if the panel is to be cleared, lower the tail length until 0
                tailLength--;
                if (tailLength < 0)
                {
                    //when the tail length is 0, stop everything
                    clearPanel = false;
                    tailLength = tempLen;
                    stopMoving();
                    stopThreads();
                }
                else
                {
                    //draw the lines with the new tail length
                    drawPanel.Invalidate();
                }
            }
            else
            {
                //if normal execution, draw all lines
                drawPanel.Invalidate();
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            //upon the window being resized, resize the image
            maxWidth = drawPanel.Size.Width;
            maxHeight = drawPanel.Size.Height;
            backImage = new Bitmap(backImage, maxWidth, maxHeight);
        }

        private void speedBar_Scroll(object sender, EventArgs e)
        {
            //change the min and max speed range of the line
            LINE.maxSpeed = maxSpeed + (speedBar.Value * 2);
            LINE.minSpeed = minSpeed + (speedBar.Value * 2);
        }

        private void tailBar_Scroll(object sender, EventArgs e)
        {
            //increase the tail length
            tailLength = minTailLen + tailBar.Value;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //create a new line
            createNew();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //disallow any further window resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //if there is no threads started yet, start one
            if (threadList.Count == 0)
            {
                createNew();
            }

            if (timerOn)
            {
                //stop the timer if it's on
                stopMoving();
            }
            else
            {
                //start the timer if it's off
                startMoving();
            }
        }

        private void createNew()
        {
            //create a new line and thread for that line
            LINE newLine = new LINE(Graphics.FromImage(backImage));
            threadList.Add(new threadObj(newLine, new Thread(new ThreadStart(newLine.drawLine))));
            //add it to the list
            threadList[threadList.Count - 1].ThisThread.Start();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //save the current tail length
            tempLen = tailLength;
            //set the clearpanel bool
            clearPanel = true;
            //reallow window resizing
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void stopMoving()
        {
            //stop the timer
            lineTimer.Stop();
            //change the timer bool
            timerOn = false;
            //change the button text
            btnStart.Text = "START";
            //disable other buttons
            btnCreate.Enabled = false;
            btnClear.Enabled = false;
            btnFade.Enabled = false;
        }

        private void startMoving()
        {
            //start the timer
            lineTimer.Start();
            //change the timer bool
            timerOn = true;
            //change the button text
            btnStart.Text = "PAUSE";
            //enable other buttons
            btnCreate.Enabled = true;
            btnClear.Enabled = true;
            btnFade.Enabled = true;
        }

        private void stopThreads()
        {
            //stop all threads in the list
            foreach (threadObj th in threadList)
            {
                th.ThisThread.Join();
            }
            //clear the list
            threadList.Clear();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //stop threads if form closing
            stopThreads();
        }

        private void btnFade_Click(object sender, EventArgs e)
        {
            //set fadelines to opposite of itself
            fadeLines = !fadeLines;
        }

    }
}
