using System.Drawing;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace TinyPicker
{
    public partial class ApplicationForm : MetroForm
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void ApplicationForm_Load(object sender, System.EventArgs e)
        {
            rgbValues.Enabled = false;
            colorPointer.Enabled = false;
        }

        private void colorSpectrum_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixel = (Bitmap) colorSpectrum.Image;
            Color color = pixel.GetPixel(e.X, e.Y);
            colorPointer.BackColor = color;
            rgbValues.Text = $"R: {color.R} , G: {color.G} , B: {color.B}";
        }
    }
}
