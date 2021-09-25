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
            this.SelectedColorPropGroup = new System.Windows.Forms.GroupBox();
            this.selectedColorPreview = new System.Windows.Forms.Panel();
            this.bluebox = new System.Windows.Forms.TextBox();
            this.greenbox = new System.Windows.Forms.TextBox();
            this.redbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rgbValues = new System.Windows.Forms.TextBox();
            this.colorPointer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.colorSpectrum)).BeginInit();
            this.SelectedColorPropGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorSpectrum
            // 
            this.colorSpectrum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorSpectrum.Image = global::TinyPicker.Properties.Resources.Spectrum;
            this.colorSpectrum.Location = new System.Drawing.Point(23, 59);
            this.colorSpectrum.Name = "colorSpectrum";
            this.colorSpectrum.Size = new System.Drawing.Size(228, 158);
            this.colorSpectrum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.colorSpectrum.TabIndex = 0;
            this.colorSpectrum.TabStop = false;
            // 
            // SelectedColorPropGroup
            // 
            this.SelectedColorPropGroup.Controls.Add(this.selectedColorPreview);
            this.SelectedColorPropGroup.Controls.Add(this.bluebox);
            this.SelectedColorPropGroup.Controls.Add(this.greenbox);
            this.SelectedColorPropGroup.Controls.Add(this.redbox);
            this.SelectedColorPropGroup.Controls.Add(this.label3);
            this.SelectedColorPropGroup.Controls.Add(this.label2);
            this.SelectedColorPropGroup.Controls.Add(this.label1);
            this.SelectedColorPropGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectedColorPropGroup.Location = new System.Drawing.Point(23, 251);
            this.SelectedColorPropGroup.Name = "SelectedColorPropGroup";
            this.SelectedColorPropGroup.Size = new System.Drawing.Size(228, 100);
            this.SelectedColorPropGroup.TabIndex = 3;
            this.SelectedColorPropGroup.TabStop = false;
            this.SelectedColorPropGroup.Text = "Selected Color";
            // 
            // selectedColorPreview
            // 
            this.selectedColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedColorPreview.Location = new System.Drawing.Point(148, 18);
            this.selectedColorPreview.Name = "selectedColorPreview";
            this.selectedColorPreview.Size = new System.Drawing.Size(74, 75);
            this.selectedColorPreview.TabIndex = 6;
            // 
            // bluebox
            // 
            this.bluebox.Location = new System.Drawing.Point(55, 70);
            this.bluebox.Name = "bluebox";
            this.bluebox.Size = new System.Drawing.Size(87, 23);
            this.bluebox.TabIndex = 5;
            // 
            // greenbox
            // 
            this.greenbox.Location = new System.Drawing.Point(55, 44);
            this.greenbox.Name = "greenbox";
            this.greenbox.Size = new System.Drawing.Size(87, 23);
            this.greenbox.TabIndex = 4;
            // 
            // redbox
            // 
            this.redbox.Location = new System.Drawing.Point(55, 18);
            this.redbox.Name = "redbox";
            this.redbox.Size = new System.Drawing.Size(87, 23);
            this.redbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red :";
            // 
            // rgbValues
            // 
            this.rgbValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rgbValues.Location = new System.Drawing.Point(23, 223);
            this.rgbValues.Name = "rgbValues";
            this.rgbValues.Size = new System.Drawing.Size(167, 23);
            this.rgbValues.TabIndex = 4;
            // 
            // colorPointer
            // 
            this.colorPointer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPointer.Location = new System.Drawing.Point(196, 223);
            this.colorPointer.Name = "colorPointer";
            this.colorPointer.Size = new System.Drawing.Size(55, 23);
            this.colorPointer.TabIndex = 5;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 370);
            this.Controls.Add(this.colorPointer);
            this.Controls.Add(this.rgbValues);
            this.Controls.Add(this.SelectedColorPropGroup);
            this.Controls.Add(this.colorSpectrum);
            this.MaximizeBox = false;
            this.Name = "ApplicationForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Tiny Picker";
            ((System.ComponentModel.ISupportInitialize)(this.colorSpectrum)).EndInit();
            this.SelectedColorPropGroup.ResumeLayout(false);
            this.SelectedColorPropGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox colorSpectrum;
        private System.Windows.Forms.GroupBox SelectedColorPropGroup;
        private System.Windows.Forms.TextBox rgbValues;
        private System.Windows.Forms.TextBox colorPointer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel selectedColorPreview;
        private System.Windows.Forms.TextBox bluebox;
        private System.Windows.Forms.TextBox greenbox;
        private System.Windows.Forms.TextBox redbox;
    }
}

