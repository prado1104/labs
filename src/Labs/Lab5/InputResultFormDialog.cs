using System.Windows.Forms;

namespace Lab5
{
    public partial class InputResultFormDialog : Form
    {
        public InputResultFormDialog(string text)
        {
            InitializeComponent();
            lblInputResult.Text = text;
        }
    }
}