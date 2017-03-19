namespace TheGameOfLife_Project
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControll = new System.Windows.Forms.TabControl();
            this.GeneralPage = new System.Windows.Forms.TabPage();
            this.UniversalHeightUpDown = new System.Windows.Forms.NumericUpDown();
            this.UniversalWidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.TimeIntervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewPage = new System.Windows.Forms.TabPage();
            this.CellsColorButton = new System.Windows.Forms.Button();
            this.BackgroundButtonColor = new System.Windows.Forms.Button();
            this.GridColorButton = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AdvancedPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InfiniteRadioButton = new System.Windows.Forms.RadioButton();
            this.FiniteradioButton = new System.Windows.Forms.RadioButton();
            this.TorodialradioButton = new System.Windows.Forms.RadioButton();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TabControll.SuspendLayout();
            this.GeneralPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UniversalHeightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UniversalWidthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeIntervalUpDown)).BeginInit();
            this.ViewPage.SuspendLayout();
            this.AdvancedPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControll
            // 
            this.TabControll.Controls.Add(this.GeneralPage);
            this.TabControll.Controls.Add(this.ViewPage);
            this.TabControll.Controls.Add(this.AdvancedPage);
            this.TabControll.Location = new System.Drawing.Point(0, -1);
            this.TabControll.Name = "TabControll";
            this.TabControll.SelectedIndex = 0;
            this.TabControll.Size = new System.Drawing.Size(496, 291);
            this.TabControll.TabIndex = 0;
            // 
            // GeneralPage
            // 
            this.GeneralPage.Controls.Add(this.UniversalHeightUpDown);
            this.GeneralPage.Controls.Add(this.UniversalWidthUpDown);
            this.GeneralPage.Controls.Add(this.TimeIntervalUpDown);
            this.GeneralPage.Controls.Add(this.label3);
            this.GeneralPage.Controls.Add(this.label2);
            this.GeneralPage.Controls.Add(this.label1);
            this.GeneralPage.Location = new System.Drawing.Point(4, 25);
            this.GeneralPage.Name = "GeneralPage";
            this.GeneralPage.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralPage.Size = new System.Drawing.Size(488, 262);
            this.GeneralPage.TabIndex = 0;
            this.GeneralPage.Text = "General";
            this.GeneralPage.UseVisualStyleBackColor = true;
            // 
            // UniversalHeightUpDown
            // 
            this.UniversalHeightUpDown.Location = new System.Drawing.Point(206, 150);
            this.UniversalHeightUpDown.Name = "UniversalHeightUpDown";
            this.UniversalHeightUpDown.Size = new System.Drawing.Size(120, 22);
            this.UniversalHeightUpDown.TabIndex = 5;
            this.UniversalHeightUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // UniversalWidthUpDown
            // 
            this.UniversalWidthUpDown.Location = new System.Drawing.Point(206, 95);
            this.UniversalWidthUpDown.Name = "UniversalWidthUpDown";
            this.UniversalWidthUpDown.Size = new System.Drawing.Size(120, 22);
            this.UniversalWidthUpDown.TabIndex = 4;
            this.UniversalWidthUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // TimeIntervalUpDown
            // 
            this.TimeIntervalUpDown.Location = new System.Drawing.Point(206, 37);
            this.TimeIntervalUpDown.Name = "TimeIntervalUpDown";
            this.TimeIntervalUpDown.Size = new System.Drawing.Size(120, 22);
            this.TimeIntervalUpDown.TabIndex = 3;
            this.TimeIntervalUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height of universe in cells";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width of universe in cells";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time interval in seconds";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ViewPage
            // 
            this.ViewPage.Controls.Add(this.CellsColorButton);
            this.ViewPage.Controls.Add(this.BackgroundButtonColor);
            this.ViewPage.Controls.Add(this.GridColorButton);
            this.ViewPage.Controls.Add(this.Resetbutton);
            this.ViewPage.Controls.Add(this.label6);
            this.ViewPage.Controls.Add(this.label5);
            this.ViewPage.Controls.Add(this.label4);
            this.ViewPage.Location = new System.Drawing.Point(4, 25);
            this.ViewPage.Name = "ViewPage";
            this.ViewPage.Padding = new System.Windows.Forms.Padding(3);
            this.ViewPage.Size = new System.Drawing.Size(488, 262);
            this.ViewPage.TabIndex = 1;
            this.ViewPage.Text = "View";
            this.ViewPage.UseVisualStyleBackColor = true;
            // 
            // CellsColorButton
            // 
            this.CellsColorButton.BackColor = System.Drawing.Color.Black;
            this.CellsColorButton.Location = new System.Drawing.Point(24, 157);
            this.CellsColorButton.Name = "CellsColorButton";
            this.CellsColorButton.Size = new System.Drawing.Size(75, 23);
            this.CellsColorButton.TabIndex = 6;
            this.CellsColorButton.UseVisualStyleBackColor = false;
            this.CellsColorButton.Click += new System.EventHandler(this.CellsColorButton_Click);
            // 
            // BackgroundButtonColor
            // 
            this.BackgroundButtonColor.BackColor = System.Drawing.Color.White;
            this.BackgroundButtonColor.Location = new System.Drawing.Point(24, 116);
            this.BackgroundButtonColor.Name = "BackgroundButtonColor";
            this.BackgroundButtonColor.Size = new System.Drawing.Size(75, 23);
            this.BackgroundButtonColor.TabIndex = 5;
            this.BackgroundButtonColor.UseVisualStyleBackColor = false;
            this.BackgroundButtonColor.Click += new System.EventHandler(this.BackgroundButtonColor_Click);
            // 
            // GridColorButton
            // 
            this.GridColorButton.BackColor = System.Drawing.Color.Gray;
            this.GridColorButton.Location = new System.Drawing.Point(24, 75);
            this.GridColorButton.Name = "GridColorButton";
            this.GridColorButton.Size = new System.Drawing.Size(75, 23);
            this.GridColorButton.TabIndex = 4;
            this.GridColorButton.UseVisualStyleBackColor = false;
            this.GridColorButton.Click += new System.EventHandler(this.GridColorButton_Click);
            // 
            // Resetbutton
            // 
            this.Resetbutton.Location = new System.Drawing.Point(58, 210);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(75, 23);
            this.Resetbutton.TabIndex = 3;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Living cells Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Background Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Grid Color";
            // 
            // AdvancedPage
            // 
            this.AdvancedPage.Controls.Add(this.groupBox1);
            this.AdvancedPage.Location = new System.Drawing.Point(4, 25);
            this.AdvancedPage.Name = "AdvancedPage";
            this.AdvancedPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdvancedPage.Size = new System.Drawing.Size(488, 262);
            this.AdvancedPage.TabIndex = 2;
            this.AdvancedPage.Text = "Advanced";
            this.AdvancedPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InfiniteRadioButton);
            this.groupBox1.Controls.Add(this.FiniteradioButton);
            this.groupBox1.Controls.Add(this.TorodialradioButton);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boundary type";
            // 
            // InfiniteRadioButton
            // 
            this.InfiniteRadioButton.AutoSize = true;
            this.InfiniteRadioButton.Enabled = false;
            this.InfiniteRadioButton.Location = new System.Drawing.Point(6, 97);
            this.InfiniteRadioButton.Name = "InfiniteRadioButton";
            this.InfiniteRadioButton.Size = new System.Drawing.Size(73, 21);
            this.InfiniteRadioButton.TabIndex = 2;
            this.InfiniteRadioButton.Text = "Inifinite";
            this.InfiniteRadioButton.UseVisualStyleBackColor = true;
            // 
            // FiniteradioButton
            // 
            this.FiniteradioButton.AutoSize = true;
            this.FiniteradioButton.Location = new System.Drawing.Point(6, 70);
            this.FiniteradioButton.Name = "FiniteradioButton";
            this.FiniteradioButton.Size = new System.Drawing.Size(63, 21);
            this.FiniteradioButton.TabIndex = 1;
            this.FiniteradioButton.Text = "Finite";
            this.FiniteradioButton.UseVisualStyleBackColor = true;
            // 
            // TorodialradioButton
            // 
            this.TorodialradioButton.AutoSize = true;
            this.TorodialradioButton.Location = new System.Drawing.Point(6, 43);
            this.TorodialradioButton.Name = "TorodialradioButton";
            this.TorodialradioButton.Size = new System.Drawing.Size(81, 21);
            this.TorodialradioButton.TabIndex = 0;
            this.TorodialradioButton.Text = "Torodial";
            this.TorodialradioButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(12, 307);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(109, 307);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 342);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.TabControll);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Options Dialog";
            this.TabControll.ResumeLayout(false);
            this.GeneralPage.ResumeLayout(false);
            this.GeneralPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UniversalHeightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UniversalWidthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeIntervalUpDown)).EndInit();
            this.ViewPage.ResumeLayout(false);
            this.ViewPage.PerformLayout();
            this.AdvancedPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControll;
        private System.Windows.Forms.TabPage GeneralPage;
        private System.Windows.Forms.TabPage ViewPage;
        private System.Windows.Forms.TabPage AdvancedPage;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown UniversalHeightUpDown;
        private System.Windows.Forms.NumericUpDown UniversalWidthUpDown;
        private System.Windows.Forms.NumericUpDown TimeIntervalUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton InfiniteRadioButton;
        private System.Windows.Forms.RadioButton FiniteradioButton;
        private System.Windows.Forms.RadioButton TorodialradioButton;
        private System.Windows.Forms.Button CellsColorButton;
        private System.Windows.Forms.Button BackgroundButtonColor;
        private System.Windows.Forms.Button GridColorButton;
    }
}