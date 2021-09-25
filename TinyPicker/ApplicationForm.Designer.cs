namespace TinyPicker
{
    partial class ApplicationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorSpectrum = new System.Windows.Forms.PictureBox();
            this.rgbText = new System.Windows.Forms.Label();
            this.selectedColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.colorSpectrum)).BeginInit();
            this.SuspendLayout();
            // 
            // colorSpectrum
            // 
            this.colorSpectrum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorSpectrum.Location = new System.Drawing.Point(23, 59);
            this.colorSpectrum.Name = "colorSpectrum";
            this.colorSpectrum.Size = new System.Drawing.Size(270, 187);
            this.colorSpectrum.TabIndex = 0;
            this.colorSpectrum.TabStop = false;
            // 
            // rgbText
            // 
            this.rgbText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rgbText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rgbText.Location = new System.Drawing.Point(23, 249);
            this.rgbText.Name = "rgbText";
            this.rgbText.Size = new System.Drawing.Size(200, 24);
            this.rgbText.TabIndex = 1;
            // 
            // selectedColor
            // 
            this.selectedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectedColor.Location = new System.Drawing.Point(229, 249);
            this.selectedColor.Name = "selectedColor";
            this.selectedColor.Size = new System.Drawing.Size(64, 24);
            this.selectedColor.TabIndex = 2;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 500);
            this.Controls.Add(this.selectedColor);
            this.Controls.Add(this.rgbText);
            this.Controls.Add(this.colorSpectrum);
            this.MaximizeBox = false;
            this.Name = "ApplicationForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Tiny Picker";
            ((System.ComponentModel.ISupportInitialize)(this.colorSpectrum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox colorSpectrum;
        private System.Windows.Forms.Label rgbText;
        private System.Windows.Forms.Label selectedColor;
    }
}

