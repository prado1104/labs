using System;
using System.Windows.Forms;

namespace Lab5
{
    public partial class InputFormDialog : Form
    {
        public InputFormDialog()
        {
            InitializeComponent();
        }
        
        public string InputText => txtInput.Text;

        public bool RdbToUpperChecked => radioDbtUpperCase.Checked;

        public bool RdbToLowerChecked => radioBtnLowerCase.Checked;

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
            {
                MessageBox.Show("Пожалуйста, введите текст");
                return;
            }
            
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}