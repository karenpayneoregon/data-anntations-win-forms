
namespace WindowsFormsLibrary.Controls
{
    partial class PasswordTextBoxUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PasswordTextBox = new WindowsFormsLibrary.Controls.PasswordTextBox();
            this.ToggleCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox.Location = new System.Drawing.Point(5, 5);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.Size = new System.Drawing.Size(116, 23);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // ToggleCheckBox
            // 
            this.ToggleCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToggleCheckBox.AutoSize = true;
            this.ToggleCheckBox.Location = new System.Drawing.Point(127, 9);
            this.ToggleCheckBox.Name = "ToggleCheckBox";
            this.ToggleCheckBox.Size = new System.Drawing.Size(15, 14);
            this.ToggleCheckBox.TabIndex = 3;
            this.ToggleCheckBox.UseVisualStyleBackColor = true;
            this.ToggleCheckBox.CheckedChanged += new System.EventHandler(this.ToggleCheckBox_CheckedChanged);
            // 
            // PasswordTextBoxUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ToggleCheckBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Name = "PasswordTextBoxUserControl";
            this.Size = new System.Drawing.Size(152, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public PasswordTextBox PasswordTextBox;
        public System.Windows.Forms.CheckBox ToggleCheckBox;
    }
}
