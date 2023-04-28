using System.ComponentModel.DataAnnotations;

namespace BaseDataValidatorLibrary.CommonRules;

/// <summary>
/// Here we want to validate passwords match
/// </summary>
public class LoginCompare
{

    [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
    [MaxLength(12, ErrorMessage = "The {0} can not have more than {1} characters")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
    [StringLength(12, MinimumLength = 6)]
    public string Password { get; set; }
    [Compare("Password", ErrorMessage = "Passwords do not match, please try again")]
    [StringLength(12, MinimumLength = 6)]
    public string PasswordConfirmation { get; set; }

}

