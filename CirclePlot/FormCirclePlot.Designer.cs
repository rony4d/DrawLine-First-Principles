namespace CirclePlot
{
    partial class FormCirclePlot
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
            this.CirclePlotCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePlotCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // CirclePlotCanvas
            // 
            this.CirclePlotCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CirclePlotCanvas.Location = new System.Drawing.Point(58, 29);
            this.CirclePlotCanvas.Name = "CirclePlotCanvas";
            this.CirclePlotCanvas.Size = new System.Drawing.Size(642, 389);
            this.CirclePlotCanvas.TabIndex = 0;
            this.CirclePlotCanvas.TabStop = false;
            this.CirclePlotCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.CircleDrawingCanvasPaint);
            this.CirclePlotCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawingCanvas_MouseClick);
            // 
            // FormCirclePlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CirclePlotCanvas);
            this.Name = "FormCirclePlot";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CirclePlotCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CirclePlotCanvas;
    }
}

