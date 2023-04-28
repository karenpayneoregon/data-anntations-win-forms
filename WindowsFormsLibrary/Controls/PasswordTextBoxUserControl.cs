namespace WindowsFormsLibrary.Controls;

public partial class PasswordTextBoxUserControl : UserControl
{
    public PasswordTextBoxUserControl()
    {
        InitializeComponent();
    }

    public PasswordTextBox TextBox
    {
        get => PasswordTextBox;
        set => PasswordTextBox = value;
    }

    private void ToggleCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        PasswordTextBox.TextMasked(ToggleCheckBox.Checked);
    }
}