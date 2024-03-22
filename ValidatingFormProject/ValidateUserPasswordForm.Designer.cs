namespace ValidatingFormProject;

partial class ValidateUserPasswordForm
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
        PasswordTextBox = new TextBox();
        ValidatePasswordButton = new Button();
        SuspendLayout();
        // 
        // PasswordTextBox
        // 
        PasswordTextBox.Location = new Point(12, 27);
        PasswordTextBox.Name = "PasswordTextBox";
        PasswordTextBox.Size = new Size(186, 27);
        PasswordTextBox.TabIndex = 0;
        PasswordTextBox.Text = "@SlowWine2024";
        // 
        // ValidatePasswordButton
        // 
        ValidatePasswordButton.Location = new Point(204, 27);
        ValidatePasswordButton.Name = "ValidatePasswordButton";
        ValidatePasswordButton.Size = new Size(94, 29);
        ValidatePasswordButton.TabIndex = 1;
        ValidatePasswordButton.Text = "button1";
        ValidatePasswordButton.UseVisualStyleBackColor = true;
        ValidatePasswordButton.Click += ValidatePasswordButton_Click;
        // 
        // ValidateUserPasswordForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(544, 188);
        Controls.Add(ValidatePasswordButton);
        Controls.Add(PasswordTextBox);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "ValidateUserPasswordForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Validate User Password";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox PasswordTextBox;
    private Button ValidatePasswordButton;
}