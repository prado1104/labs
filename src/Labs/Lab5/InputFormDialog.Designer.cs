using System.ComponentModel;

namespace Lab5
{
    partial class InputFormDialog
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtnLowerCase = new System.Windows.Forms.RadioButton();
            this.radioDbtUpperCase = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(13, 36);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(118, 20);
            this.txtInput.TabIndex = 0;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(13, 62);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(118, 27);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBtnLowerCase);
            this.panel1.Controls.Add(this.radioDbtUpperCase);
            this.panel1.Location = new System.Drawing.Point(148, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 73);
            this.panel1.TabIndex = 2;
            // 
            // radioBtnLowerCase
            // 
            this.radioBtnLowerCase.Location = new System.Drawing.Point(3, 38);
            this.radioBtnLowerCase.Name = "radioBtnLowerCase";
            this.radioBtnLowerCase.Size = new System.Drawing.Size(81, 19);
            this.radioBtnLowerCase.TabIndex = 1;
            this.radioBtnLowerCase.TabStop = true;
            this.radioBtnLowerCase.Text = "Lower case";
            this.radioBtnLowerCase.UseVisualStyleBackColor = true;
            // 
            // radioDbtUpperCase
            // 
            this.radioDbtUpperCase.Location = new System.Drawing.Point(3, 14);
            this.radioDbtUpperCase.Name = "radioDbtUpperCase";
            this.radioDbtUpperCase.Size = new System.Drawing.Size(85, 18);
            this.radioDbtUpperCase.TabIndex = 0;
            this.radioDbtUpperCase.TabStop = true;
            this.radioDbtUpperCase.Text = "Upper case";
            this.radioDbtUpperCase.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input word";
            // 
            // InputFormDialog
            // 
            this.AcceptButton = this.btnInput;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 109);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputFormDialog";
            this.Text = "InputFormDialog";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.RadioButton radioDbtUpperCase;
        private System.Windows.Forms.RadioButton radioBtnLowerCase;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}