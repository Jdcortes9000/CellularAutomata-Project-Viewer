namespace TheGameOfLife_Project
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.GenUpDown = new System.Windows.Forms.NumericUpDown();
            this.OkButton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GenUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Run to generation";
            // 
            // GenUpDown
            // 
            this.GenUpDown.Location = new System.Drawing.Point(141, 44);
            this.GenUpDown.Name = "GenUpDown";
            this.GenUpDown.Size = new System.Drawing.Size(120, 22);
            this.GenUpDown.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(46, 103);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(67, 26);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(186, 103);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 26);
            this.Cancelbutton.TabIndex = 3;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 141);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.GenUpDown);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Run to Dialog";
            ((System.ComponentModel.ISupportInitialize)(this.GenUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown GenUpDown;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button Cancelbutton;
    }
}