using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidatingFormProject.Models;
using static BaseDataValidatorLibrary.Helpers.ValidationHelper;

namespace ValidatingFormProject;
public partial class ValidateUserPasswordForm : Form
{
    public ValidateUserPasswordForm()
    {
        InitializeComponent();

    }


    private void ValidatePasswordButton_Click(object sender, EventArgs e)
    {
        User user = new() {Password = PasswordTextBox.Text};
        var (success, container) = IsValidEntity(user);
        if (success)
        {
            Debug.WriteLine("Valid");
        }
        else
        {
            foreach (var errorContainer in container)
            {
                Debug.WriteLine($"{errorContainer.Name,-12}{errorContainer.Description}");
            }
        }

    }
}
