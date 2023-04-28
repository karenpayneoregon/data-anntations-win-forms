using System.ComponentModel.DataAnnotations;

namespace BaseDataValidatorLibrary.CommonRules;

/// <summary>
/// Provides custom rule for phone number rather than using stock [Phone] class
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class CheckPhoneValidationAttribute : ValidationAttribute 
{
    /// <summary>
    ///  Override of <see cref="ValidationAttribute.IsValid(object)" />
    /// </summary>
    public override bool IsValid(object sender)
    {
        // local function
        static bool IsDigitsOnly(string value)
        {
            return value.All(character => character is >= '0' and <= '9');
        }

        if (sender == null)
        {
            return false;
        }

        string convertedValue = sender.ToString();

        return !string.IsNullOrWhiteSpace(convertedValue) && 
               IsDigitsOnly(convertedValue) && 
               convertedValue.Length <= 10;
    }
}