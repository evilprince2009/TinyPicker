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
    }
}
