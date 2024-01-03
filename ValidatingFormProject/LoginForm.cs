using BaseDataValidatorLibrary.CommonRules;
using static BaseDataValidatorLibrary.Helpers.ValidationHelper;

namespace ValidatingFormProject;
public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void ValidateButton_Click(object sender, EventArgs e)
    {

        LoginModel loginCompare = new()
        {
            Name = NameTextBox.Text,
            Password = PasswordTextBox.Text,
            PasswordConfirmation = PasswordConfirmTextBox.Text,
        };
        var (success, container) = IsValidEntity(loginCompare);


        MessageBox.Show(success ? "Ok" : "Invalid");
    }
}

