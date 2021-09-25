using System.Drawing;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace TinyPicker
{
    public partial class ApplicationForm : MetroForm
    {
        private Bitmap pixel;
        public ApplicationForm()
        {
            InitializeComponent();
            pixel = (Bitmap)colorSpectrum.Image;
        }

        private void ApplicationForm_Load(object sender, System.EventArgs e)
        {
            rgbValues.Enabled = false;
            colorPointer.Enabled = false;
        }

        private void colorSpectrum_MouseMove(object sender, MouseEventArgs e)
        {
            Color color = pixel.GetPixel(e.X, e.Y);
            colorPointer.BackColor = color;
            rgbValues.Text = $"R: {color.R} , G: {color.G} , B: {color.B}";
        }

        private void colorSpectrum_MouseDown(object sender, MouseEventArgs e)
        {
            Color color = pixel.GetPixel(e.X, e.Y);
            redbox.Text = color.R.ToString();
            greenbox.Text = color.G.ToString();
            bluebox.Text = color.B.ToString();
            hexbox.Text = $"#{color.R.ToString("X2")}{color.G.ToString("X2")}{color.B.ToString("X2")}";
            selectedColorPreview.BackColor = color;
        }
    }
}
