using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGameOfLife_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            //Sets the backcolor of the color buttons to the value of its properties
            InitializeComponent();
            GridColorButton.BackColor = Properties.Settings.Default.Grid;
            BackgroundButtonColor.BackColor = Properties.Settings.Default.Background;
            CellsColorButton.BackColor = Properties.Settings.Default.Cells;
            //FiniteradioButton.Checked = true;
        }
        //Nothing
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            //Checks if the values entered for width and height are changed or not. This is to prevent that the screen is cleared even if the size wasnt changed.
            //If the check is true then it will take the values of width and height from the numeric updowns. 
            if(((Form1)this.Owner).GetX() != (int)UniversalWidthUpDown.Value && ((Form1)this.Owner).GetY() != (int)UniversalHeightUpDown.Value)
            ((Form1)this.Owner).GatherSize((int)UniversalWidthUpDown.Value,(int)UniversalHeightUpDown.Value);
            //Gets the values from the numeric up down for time.
            ((Form1)this.Owner).GatherInterval((int)TimeIntervalUpDown.Value);
            //This will check what was clicked on the radio buttons, 
            //if it was Torodial, then it will call the setTorodial function that sets it to true
            //if it was Finite, then same thing but with Finite
            if(TorodialradioButton.Checked == true )
            {
                ((Form1)this.Owner).SetTorodial();
                FiniteradioButton.Checked = false;
                //TorodialradioButton.Checked = true;
            }
            else if (FiniteradioButton.Checked == true)
            {
                ((Form1)this.Owner).SetFinite();
                TorodialradioButton.Checked = false;
                //FiniteradioButton.Checked = true;
            }
            this.Close();
        }
        //Will be used to set the width to its respective variable in form1
        public int SetX
        {
            set { UniversalWidthUpDown.Value = value; }
        }
        //Will be used to set the width to its respective variable in form1
        public int SetY
        {
            set { UniversalHeightUpDown.Value = value; }
        }
        //Will be used to set the width to its respective variable in form1
        public int SetTime
        {
            set { TimeIntervalUpDown.Value = value; }
        }
        //No values will change if close was triggered.
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Sets the color of the grid to whatever was chosen. Plus it saves it on properties.
        private void GridColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.Color = GridColorButton.BackColor;
            if(DialogResult.OK == c.ShowDialog())
            {
                GridColorButton.BackColor = c.Color;
                Properties.Settings.Default.Grid = GridColorButton.BackColor;
                Properties.Settings.Default.Save();
            }
        }
        //Sets the color of the background to whatever was chosen. Plus it saves it on properties.
        private void BackgroundButtonColor_Click(object sender, EventArgs e)
        {
            ColorDialog c1 = new ColorDialog();
            c1.Color = BackgroundButtonColor.BackColor;
            if (DialogResult.OK == c1.ShowDialog())
            {
                BackgroundButtonColor.BackColor = c1.Color;
                Properties.Settings.Default.Background = BackgroundButtonColor.BackColor;
                Properties.Settings.Default.Save();
            }
        }
        //Sets the color of the Cells to whatever was chosen. Plus it saves it on properties.
        private void CellsColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog c2 = new ColorDialog();
            c2.Color = CellsColorButton.BackColor;
            if (DialogResult.OK == c2.ShowDialog())
            {
                CellsColorButton.BackColor = c2.Color;
                Properties.Settings.Default.Cells = CellsColorButton.BackColor;
                Properties.Settings.Default.Save();
            }
        }
    }
}
