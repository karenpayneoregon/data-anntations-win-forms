

using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace BaseDataValidatorLibrary.CommonRules;
public partial class CustomPasswordAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value == null) return false;

        var password = value.ToString();

        if (password!.Length < 10) return false;

        // Check for uppercase, lowercase, numbers and special characters
        return UpperCaseRegex().IsMatch(password) && LowerCaseRegex().IsMatch(password) &&
               NumbersRegex().IsMatch(password) && SpecialCharactersRegex().IsMatch(password);
    }

    [GeneratedRegex(@"[A-Z]")]
    private static partial Regex UpperCaseRegex();

    [GeneratedRegex(@"[a-z]")]
    private static partial Regex LowerCaseRegex();

    [GeneratedRegex(@"[0-9]")]
    private static partial Regex NumbersRegex();
    [GeneratedRegex(@"[@$!%*?&#]")]
    private static partial Regex SpecialCharactersRegex();
}
