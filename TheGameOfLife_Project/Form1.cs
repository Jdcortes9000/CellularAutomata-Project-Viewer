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
using System.IO;

namespace TheGameOfLife_Project
{
    public partial class Form1 : Form
    {
        //Variables used throughout the program.
        int sizeX = 100;
        int sizeY = 100;
        int timeinterval = 20;
        int Alive = 0;
        bool Finite = false;
        bool Torodial = true;
        bool start = false;
        bool next = false;
        bool To = false;
        bool[,] universe;
        bool[,] Scrathpad;
        bool[,] count;
        System.Windows.Forms.Timer time;
        int generations = 0;
        int tempGen = 0;
        int totalcount;
        Color wall = Properties.Settings.Default.Background;
        SolidBrush cellcolor = new SolidBrush(Properties.Settings.Default.Cells);
        Pen lines = new Pen(Properties.Settings.Default.Grid);
        public Form1()
        {
            //Assigments or Initializations of some variables.
            InitializeComponent();
            universe = new bool[sizeX, sizeY];
            Scrathpad = new bool[sizeX, sizeY];
            count = new bool[sizeX, sizeY];
            time = new System.Windows.Forms.Timer();
            time.Interval = timeinterval;
            time.Enabled = true;
            time.Tick += Time_Tick;
            graphicsPanel1.BackColor = wall;
            
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            //The logic that sums the generation by one for each turn. There is one for when you press start or when you click next.
            if(start == true)
            {
                time.Start();
                generations++;
            }
            if (next == true)
            {
                time.Start();
                generations++;
                
            }
            GenerationLabel.Text = "Generations = " + generations.ToString();
            TimeIntervalLabel.Text = "Interval = " + timeinterval.ToString();
            graphicsPanel1.Invalidate();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            //Gets the width and height that would be used to draw rectangles.
            float width = ((float)graphicsPanel1.ClientSize.Width) / ((float)universe.GetLength(0));
            float height = ((float)graphicsPanel1.ClientSize.Height) / ((float)universe.GetLength(1));
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    //PointF px1 = new PointF(0, height * x);
                    //PointF px2 = new PointF(graphicsPanel1.ClientSize.Width, height * x);
                    //PointF py1 = new PointF(width * y, 0);
                    //PointF py2 = new PointF(width * y,graphicsPanel1.ClientSize.Height);
                    ////e.Graphics.DrawLine(Pens.Black, p1, p2);
                    //e.Graphics.DrawLine(Pens.Black, px1,px2);
                    //e.Graphics.DrawLine(Pens.Black, py1,py2);
                    
                    //Draws the grid and the living or dead cells
                    RectangleF rect =  RectangleF.Empty;
                    rect.X = x * width;
                    rect.Y = y * height;
                    rect.Width = width;
                    rect.Height = height;
                    if (universe[x, y] == true)
                    {
                        //The count bool multy array is used to check if the universe cell that count is checking has already been acounted for.
                        //This is used to prevent the alive count be summed up more than once for the same cell.
                        //Same logic is used if universe is false to prevent substracting more than once for the same cell.
                        //Besides that, this is where the living or cells array are drawn plus the alive count.
                        if(count[x,y] != universe[x,y])
                        {
                            Alive++;
                            count[x, y] = universe[x, y];
                        }
                       
                        e.Graphics.FillRectangle(cellcolor, rect);
                        AliveCountLabel.Text = "Alive: " + Alive.ToString();
                    }
                    else
                    {
                        if (count[x, y] != universe[x, y])
                        {
                            Alive--;
                            count[x, y] = universe[x, y];
                        }
                        e.Graphics.DrawRectangle(lines, rect.X, rect.Y, rect.Width, rect.Height);
                        AliveCountLabel.Text = "Alive: " + Alive.ToString();
                    }             
                }
            }
            //This is the code that will count the neighbours and apply the rules for the next generations. The same code is used twice. 
            //One for start and one for next. The only difference is that next is set to false in the end if next in order to run this code once per click.
            //One is used for Finite and another is used for Torodial.
            if(Finite == true)
            {
                if (To == true)
                {
                    CheckTo();
                }
                if (start == true)
                {
                    for (int y = 0; y < universe.GetLength(1); y++)
                    {
                        for (int x = 0; x < universe.GetLength(0); x++)
                        {
                            CountNeighbors(x, y);
                            if (totalcount < 2)
                            {
                                Scrathpad[x, y] = false;
                            }
                            if (totalcount > 3)
                            {
                                Scrathpad[x, y] = false;
                            }
                            if (totalcount > 1 && totalcount < 4 && universe[x, y] == true)
                            {
                                Scrathpad[x, y] = true;
                            }
                            if (totalcount == 3 && universe[x, y] == false)
                            {
                                Scrathpad[x, y] = true;
                            }
                        }
                    }
                    bool[,] temp = new bool[sizeX, sizeY];
                    universe = Scrathpad;
                    Scrathpad = temp;
                }
                if (next == true)
                {
                    for (int y = 0; y < universe.GetLength(1); y++)
                    {
                        for (int x = 0; x < universe.GetLength(0); x++)
                        {
                            CountNeighbors(x, y);
                            if (totalcount < 2)
                            {
                                Scrathpad[x, y] = false;
                            }
                            if (totalcount > 3)
                            {
                                Scrathpad[x, y] = false;
                            }
                            if (totalcount > 1 && totalcount < 4 && universe[x, y] == true)
                            {
                                Scrathpad[x, y] = true;
                            }
                            if (totalcount == 3 && universe[x, y] == false)
                            {
                                Scrathpad[x, y] = true;
                            }
                        }
                    }
                    bool[,] temp = new bool[sizeX, sizeY];
                    universe = Scrathpad;
                    Scrathpad = temp;
                    next = false;
                }
                Thread.Sleep(10);
            }
           else if (Torodial == true)
            {
                if (To == true)
                {
                    CheckTo();
                }
                if (start == true)
                {
                    for (int y = 0; y < universe.GetLength(1); y++)
                    {
                        for (int x = 0; x < universe.GetLength(0); x++)
                        {
                            CountNeighborsT(x, y);
                            if (totalcount < 2)
                            {
                                Scrathpad[x, y] = false;
                            }
                            if (totalcount > 3)
                            {
                                Scrathpad[x, y] = false;
                            }
                            if (totalcount > 1 && totalcount < 4 && universe[x, y] == true)
                            {
                                Scrathpad[x, y] = true;
                            }
                            if (totalcount == 3 && universe[x, y] == false)
                            {
                                Scrathpad[x, y] = true;
                            }
                        }
                    }
                    bool[,] temp = new bool[sizeX, sizeY];
                    universe = Scrathpad;
                    Scrathpad = temp;
                }
                if (next == true)
                {
                    for (int y = 0; y < universe.GetLength(1); y++)
                    {
                        for (int x = 0; x < universe.GetLength(0); x++)
                        {
                            CountNeighborsT(x, y);
                            if (totalcount < 2)
                            {
                                Scrathpad[x, y] = false;
                            }
                            if (totalcount > 3)
                            {
                                Scrathpad[x, y] = false;
                            }
                            if (totalcount > 1 && totalcount < 4 && universe[x, y] == true)
                            {
                                Scrathpad[x, y] = true;
                            }
                            if (totalcount == 3 && universe[x, y] == false)
                            {
                                Scrathpad[x, y] = true;
                            }
                        }
                    }
                    bool[,] temp = new bool[sizeX, sizeY];
                    universe = Scrathpad;
                    Scrathpad = temp;
                    next = false;
                }
                Thread.Sleep(10);
            }

        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            //Sets the cell alive or dead depending on where it was clicked and what state it was before being clicked.
            if (e.Button == MouseButtons.Left)
            {
                float width = ((float)graphicsPanel1.ClientSize.Width) / ((float)universe.GetLength(0));
                float height = ((float)graphicsPanel1.ClientSize.Height) / ((float)universe.GetLength(1));
                float x = e.X / width;
                float y = e.Y / height;

                universe[(int)x, (int)y] = !universe[(int)x, (int)y];
                graphicsPanel1.Invalidate();
            }
        }
        //This is the private functions that counts how many cells are around the cell that is checking.
        private void CountNeighbors(int x, int y)
        {
            int count = 0;
            if(x <universe.GetLength(0) -1)
            {
                //right
                if (universe[x + 1, y] == true)
                {
                    count++;
                }
            }
            //left
            if(x>0)
            if (universe[x -1, y] == true)
            {
                count++;
            }
            //down
            if(y< universe.GetLength(1)-1)
            if (universe[x, y + 1] == true)
            {
                count++;
            }
            //up
            if(y>0)
            if (universe[x, y - 1] == true)
            {
                count++;
            }
            //down right 
            if(x< universe.GetLength(0)-1 && y< universe.GetLength(1)-1)
            if (universe[x + 1, y + 1] == true)
            {
                count++;
            }
            //up right
            if(x< universe.GetLength(0) -1 && y>0)
            if (universe[x + 1, y -1] == true)
            {
                count++;
            }
            //down left
            if(x>0 && y < universe.GetLength(1) - 1)
            if (universe[x - 1, y+1] == true)
            {
                count++;
            }
            //up left
            if(x>0 && y>0)
            if (universe[x - 1, y - 1] == true)
            {
                count++;
            }
            totalcount = count;
        }
        private void CountNeighborsT(int x, int y)
        {
            int count = 0;
            if (universe[(x - 1 + universe.GetLength(0)) % universe.GetLength(0),(y - 1 + universe.GetLength(1)) % universe.GetLength(1)] == true) { count++; }
            if (universe[(x - 1 + universe.GetLength(0)) % universe.GetLength(0),y] == true) {count++; }
            if (universe[(x - 1 + universe.GetLength(0)) % universe.GetLength(0),(y + 1) % universe.GetLength(1)] == true) { count++; }
            if (universe[x,(y - 1 + universe.GetLength(1)) % universe.GetLength(1)] == true) { count++; }
            if (universe[x,(y + 1) % universe.GetLength(1)] == true) { count++; }
            if (universe[(x + 1) % universe.GetLength(0),(y - 1 + universe.GetLength(1)) % universe.GetLength(1)] == true) { count++; }
            if (universe[(x + 1) % universe.GetLength(0),y] == true) { count++; }
            if (universe[(x + 1) % universe.GetLength(0),(y + 1) % universe.GetLength(1)] == true) { count++; }
            // //right
            // if (x > universe.GetLength(0) - 1)
            // {
            //     if (universe[0, y] == true)
            //     {
            //         count++;
            //     }
            // }
            //else if (x < universe.GetLength(0) - 1)
            // {

            //     if (universe[x + 1, y] == true)
            //     {
            //         count++;
            //     }
            // }
            // //left
            // if(x < 0)
            // {
            //     if (universe[universe.GetLength(0), y] == true)
            //     {
            //         count++;
            //     }
            // }
            //else if (x > 0)
            //     if (universe[x - 1, y] == true)
            //     {
            //         count++;
            //     }
            // //down
            // if (y >= universe.GetLength(1))
            // {
            //     if (universe[x, 0] == true)
            //     {
            //         count++;
            //     }
            // }
            //else if (y < universe.GetLength(1) - 1)
            //     if (universe[x, y + 1] == true)
            //     {
            //         count++;
            //     }
            // //up
            // if (y < 0)
            // {
            //     if (universe[x, universe.GetLength(1)] == true)
            //     {
            //         count++;
            //     }
            // }
            // else if (y > 0)
            //     if (universe[x, y - 1] == true)
            //     {
            //         count++;
            //     }
            // //down right 
            // if (x >= universe.GetLength(0) && y >= universe.GetLength(1))
            // {
            //     if (universe[0, 0] == true)
            //     {
            //         count++;
            //     }
            // }
            //else if (x < universe.GetLength(0) - 1 && y < universe.GetLength(1) - 1)
            //     if (universe[x + 1, y + 1] == true)
            //     {
            //         count++;
            //     }
            // //up right
            // if (x >= universe.GetLength(0) && y < 0)
            // {
            //     if (universe[0, universe.GetLength(1)] == true)
            //     {
            //         count++;
            //     }
            // }
            //else if (x < universe.GetLength(0) - 1 && y > 0)
            //     if (universe[x + 1, y - 1] == true)
            //     {
            //         count++;
            //     }
            // //down left
            // if (x < 0 && y >= universe.GetLength(1))
            // {
            //     if (universe[universe.GetLength(0), 0] == true)
            //     {
            //         count++;
            //     }
            // }
            //else if (x > 0 && y < universe.GetLength(1) - 1)
            //     if (universe[x - 1, y + 1] == true)
            //     {
            //         count++;
            //     }
            // //up left
            // if (x < 0 && y < 0)
            // {
            //     if (universe[universe.GetLength(0), universe.GetLength(1)] == true)
            //     {
            //         count++;
            //     }
            // }
            //else if (x > 0 && y > 0)
            //     if (universe[x - 1, y - 1] == true)
            //     {
            //         count++;
            //     }
            totalcount = count;
        }
        //Clears everything and resets additional variables to its default values.
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                    count[x, y] = false;
                }
            }
            generations = 0;
            GenerationLabel.Text = "Generations: " + generations;
            start = false;
            Alive = 0;
            AliveCountLabel.Text = "Alive: " + Alive;
            graphicsPanel1.Invalidate();
        }
        //runs the simulator
        private void PlayButton_Click(object sender, EventArgs e)
        {
            start = true;
        }
        //stops the simulator
        private void PauseButton_Click(object sender, EventArgs e)
        {
            start = false;
        }
        //runs the next function instead of the start function
        private void NextButton_Click(object sender, EventArgs e)
        {
            start = false;
            next = true;
        }

        //Opens the second form and gets all the information from it throught different public functions
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Opt = new Form2();
            Opt.Owner = this;
            //Gets the width and height from the numeric up down and sets it to the variables used to size the multi array booleans.
            Opt.SetX = sizeX;
            Opt.SetY = sizeY;
            //Gets the up down from form 2 of time and sets it to the variable that assigns the value of the time interval
            Opt.SetTime = timeinterval;
            if (Opt.ShowDialog() == DialogResult.OK)
            {
                //Sets colors to what was stored in settings
                wall = Properties.Settings.Default.Background;
                graphicsPanel1.BackColor = wall;
                cellcolor = new SolidBrush(Properties.Settings.Default.Cells);
                lines = new Pen(Properties.Settings.Default.Grid);
                graphicsPanel1.Invalidate();
            }

        }
       // public function that gets the information of resize from the second form and applies them to its respective variables
        public void GatherSize(int _x,int _y)
        {
            universe = new bool[_x, _y];
            Scrathpad = new bool[_x, _y];
            count = new bool[_x, _y];
            sizeX = _x;
            sizeY = _y;
            Alive = 0;
            graphicsPanel1.Invalidate();
        }
        // public function that gets the information of time from the second form and applies them to its respective variables
        public void GatherInterval(int _t)
        {
            time.Interval = _t;
            timeinterval = _t;
        }
        // This is used to Set the numeric up down for width to whatever sizeX currently has
        public int GetX()
        {
            return sizeX;
        }
        // This is used to Set the numeric up down for height to whatever sizeX currently has
        public int GetY()
        {
            return sizeY;
        }
        //Sets Finite to true if it was checked
        public void SetFinite()
        {
            Finite = true;
            Torodial = false;
        }
        //Sets torodial to true if it was checked
        public void SetTorodial()
        {
            Finite = false;
            Torodial = true;
        }
        //Randomizes the universe with a 50% chance of being alive or dead
        private void randomizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num;
            Random rand = new Random();
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    
                    num = rand.Next();
                    if (num%2 == 1)
                    {
                        universe[x, y] = true;
                    }
                    else if(num%2 == 0)
                    {
                        universe[x, y] = false;
                    }
                }
            }
        }
        //Save function
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "shape|*.*|Cells|*.cells";
            save.FilterIndex = 2; save.DefaultExt = "cells";

            if(DialogResult.OK == save.ShowDialog())
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    string SelecetedRow = string.Empty;
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        if(universe[x,y] == true)
                        {
                            SelecetedRow += 'O';
                        }
                       else if (universe[x, y] == false)
                        {
                            SelecetedRow += '.';
                        }
                    }
                    writer.WriteLine(SelecetedRow);
                }
                writer.Close(); 
            }
        }
        //Open function
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "shape|*.*|Cells|*.cells";
            open.FilterIndex = 2;
            open.DefaultExt = "cells";

            if(DialogResult.OK == open.ShowDialog())
            {
                StreamReader reader = new StreamReader(open.FileName);
                int rw = 0;
                int rh = 0;
                while(!reader.EndOfStream)
                {
                    string row = reader.ReadLine();
                    if (row.Contains('O') || row.Contains('.'))
                    {
                        rh++;
                        rw = row.Length;
                    }   
                }

                universe = new bool[rw, rh];
                Scrathpad = new bool[rw, rh];
                count = new bool[rw, rh];
                sizeX = rw;
                sizeY = rh;
                reader.BaseStream.Seek(0, SeekOrigin.Begin);
                int py = 0;
                while(!reader.EndOfStream)
                {
                    string row = reader.ReadLine();
                   if(row.Contains('O') || row.Contains('.'))
                    {
                        for (int px = 0; px < row.Length; px++)
                        {
                            if (row[px] == 'O')
                            {
                                universe[px, py] = true;
                            }
                            else if (row[px] == '.')
                            {
                                universe[px, py] = false;
                            }
                        }
                        py++;
                    }
                }
                reader.Close();
                graphicsPanel1.Invalidate();
            }
        }
        //Destroys the window
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 RunTo = new Form3();
            RunTo.Owner = this;
            RunTo.ShowDialog();
            
        }
        public void SetGen(int _g)
        {
            tempGen = _g;
            To = true;
            start = true;
        }
        //This is used to check if generations is equal to the number that the user inputed in the RunTo.
        //If its equal, the program will pause
        public void CheckTo()
        {
            if(generations >= tempGen)
            {
                start = false;
                To = false;
            }
        }
        //This is information that will be sent to form3, 
        //it will be used to check if what the user inputed in RunTo is less than the current generation.
        public int GetGeneration()
        {
            return generations;
        }
    }
}
