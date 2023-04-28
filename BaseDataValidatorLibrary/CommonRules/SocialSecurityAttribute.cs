using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace BaseDataValidatorLibrary.CommonRules;

/// <summary>
/// Basic SSN validation, see also
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class SocialSecurityAttribute : ValidationAttribute
{
        
    /// <summary>
    ///  Override of <see cref="ValidationAttribute.IsValid(object)" />
    /// </summary>
    public override bool IsValid(object ssn)
    {
        if (ssn is null)
        {
            return false;
        }

        string value = ssn.ToString();
        if (value!.Length == 9)
        {
            value = value.Insert(5, "-").Insert(3, "-");
        }

        return !string.IsNullOrWhiteSpace(value) && new Regex(
                @"^(?!\b(\d)\1+-(\d)\1+-(\d)\1+\b)(?!123-45-6789|219-09-9999|078-05-1120)(?!666|000|9\d{2})\d{3}-(?!00)\d{2}-(?!0{4})\d{4}$")
            .IsMatch(value);

    }
}