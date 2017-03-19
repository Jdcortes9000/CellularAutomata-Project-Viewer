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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            //If what the user inputed is less then the current genertion, it won't trigger the RunTo function
            if(((Form1)this.Owner).GetGeneration() < (int)GenUpDown.Value)
            {
                ((Form1)this.Owner).SetGen((int)GenUpDown.Value);
            }
            GenUpDown.Value = GenUpDown.Value;
            this.Close();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
