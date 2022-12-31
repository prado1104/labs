using System.ComponentModel;

namespace Lab5
{
    partial class InputResultFormDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lblInputResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInputResult
            // 
            this.lblInputResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInputResult.AutoSize = true;
            this.lblInputResult.Location = new System.Drawing.Point(12, 44);
            this.lblInputResult.Name = "lblInputResult";
            this.lblInputResult.Size = new System.Drawing.Size(35, 13);
            this.lblInputResult.TabIndex = 0;
            this.lblInputResult.Text = "label1";
            // 
            // InputResultFormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 107);
            this.Controls.Add(this.lblInputResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputResultFormDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InputResultFormDialog";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblInputResult;

        #endregion
    }
}