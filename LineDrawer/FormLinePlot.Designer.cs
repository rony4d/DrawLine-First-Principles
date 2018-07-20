namespace LineDrawer
{
    partial class FormLinePlot
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
            this.PointButton = new System.Windows.Forms.Button();
            this.DrawingCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // PointButton
            // 
            this.PointButton.Location = new System.Drawing.Point(258, 356);
            this.PointButton.Name = "PointButton";
            this.PointButton.Size = new System.Drawing.Size(118, 23);
            this.PointButton.TabIndex = 0;
            this.PointButton.Text = "Make a point";
            this.PointButton.UseVisualStyleBackColor = true;
            this.PointButton.Click += new System.EventHandler(this.PointButton_Click);
            // 
            // DrawingCanvas
            // 
            this.DrawingCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingCanvas.Location = new System.Drawing.Point(45, 21);
            this.DrawingCanvas.Name = "DrawingCanvas";
            this.DrawingCanvas.Size = new System.Drawing.Size(603, 306);
            this.DrawingCanvas.TabIndex = 1;
            this.DrawingCanvas.TabStop = false;
            this.DrawingCanvas.Click += new System.EventHandler(this.DrawingCanvas_Click);
            this.DrawingCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingCanvas_Paint);
            this.DrawingCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawingCanvas_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DrawingCanvas);
            this.Controls.Add(this.PointButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DrawingCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PointButton;
        private System.Windows.Forms.PictureBox DrawingCanvas;
    }
}

