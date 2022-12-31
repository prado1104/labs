using System;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        private string _inputText;
        public Form1()
        {
            InitializeComponent();
        }

        private void beginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogForm = new InputFormDialog();
            if (dialogForm.ShowDialog() == DialogResult.OK)
            {
                _inputText = dialogForm.RdbToUpperChecked
                        ? dialogForm.InputText.ToUpper()
                        : dialogForm.RdbToLowerChecked
                            ? dialogForm.InputText.ToLower()
                            : dialogForm.InputText;
            }
        }

        private void workToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultDialogForm = new InputResultFormDialog(_inputText);
            resultDialogForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutDialogForm = new AboutFormDialog();
            aboutDialogForm.ShowDialog();
        }
    }
}