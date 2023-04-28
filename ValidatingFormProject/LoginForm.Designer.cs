namespace ValidatingFormProject;

partial class LoginForm
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordConfirmTextBox = new System.Windows.Forms.TextBox();
            this.ValidateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(23, 32);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(161, 27);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.Text = "Jane1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(23, 97);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(161, 27);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Text = "@Password1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password - confirm";
            // 
            // PasswordConfirmTextBox
            // 
            this.PasswordConfirmTextBox.Location = new System.Drawing.Point(23, 162);
            this.PasswordConfirmTextBox.Name = "PasswordConfirmTextBox";
            this.PasswordConfirmTextBox.Size = new System.Drawing.Size(161, 27);
            this.PasswordConfirmTextBox.TabIndex = 5;
            this.PasswordConfirmTextBox.Text = "@password1";
            // 
            // ValidateButton
            // 
            this.ValidateButton.AccessibleDescription = "Perform validation";
            this.ValidateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ValidateButton.Image = global::ValidatingFormProject.Properties.Resources.ValidationRule_16x;
            this.ValidateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ValidateButton.Location = new System.Drawing.Point(258, 141);
            this.ValidateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ValidateButton.Name = "ValidateButton";
            this.ValidateButton.Size = new System.Drawing.Size(83, 48);
            this.ValidateButton.TabIndex = 6;
            this.ValidateButton.Text = "Validate";
            this.ValidateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ValidateButton.UseVisualStyleBackColor = true;
            this.ValidateButton.Click += new System.EventHandler(this.ValidateButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 202);
            this.Controls.Add(this.ValidateButton);
            this.Controls.Add(this.PasswordConfirmTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private TextBox NameTextBox;
    private Label label2;
    private TextBox PasswordTextBox;
    private Label label3;
    private TextBox PasswordConfirmTextBox;
    private Button ValidateButton;
}