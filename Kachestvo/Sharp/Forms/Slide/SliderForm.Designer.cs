namespace Kachestvo.Forms.Slide
{
    partial class SliderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SliderForm));
            this.lblNextPrev = new System.Windows.Forms.Label();
            this.timerSlide = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblNextPrev
            // 
            this.lblNextPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNextPrev.AutoSize = true;
            this.lblNextPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNextPrev.ForeColor = System.Drawing.Color.White;
            this.lblNextPrev.Location = new System.Drawing.Point(507, 232);
            this.lblNextPrev.Name = "lblNextPrev";
            this.lblNextPrev.Size = new System.Drawing.Size(40, 42);
            this.lblNextPrev.TabIndex = 0;
            this.lblNextPrev.Text = "0";
            this.lblNextPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerSlide
            // 
            this.timerSlide.Interval = 1000;
            this.timerSlide.Tick += new System.EventHandler(this.timerSlide_Tick);
            // 
            // SliderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1068, 576);
            this.Controls.Add(this.lblNextPrev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SliderForm";
            this.Text = "Slide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNextPrev;
        private System.Windows.Forms.Timer timerSlide;
    }
}