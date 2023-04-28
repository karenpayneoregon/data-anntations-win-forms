namespace WindowsFormsLibrary.Controls;

public class PasswordTextBox : TextBox
{
    public void TextMasked(bool show)
    {
        PasswordChar = show ?
            '\0' :
            '\u25CF';
    }

    public PasswordTextBox()
    {
        TextMasked(false);
    }
}