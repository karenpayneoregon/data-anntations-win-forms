using System.ComponentModel.DataAnnotations;

namespace BaseDataValidatorLibrary.CommonRules;

/// <summary>
/// Provides rule to ensure property value is not less than <see cref="Minimum"/>
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class GreaterThanAttribute : ValidationAttribute
{
    /// <summary>
    /// Assert a value is greater than <see cref="Minimum"/>
    /// </summary>
    /// <param name="minimum">value to validate</param>
    public GreaterThanAttribute(int minimum)
    {
        Minimum = minimum;
    }
    public int Minimum { get; set; }
    public override string FormatErrorMessage(string name)
    {
        if (ErrorMessage is null && ErrorMessageResourceName is null)
        {
            ErrorMessage = "is unacceptable";
        }

        return $"{name} must be greater than {Minimum}";

    }

    public override bool IsValid(object sender)
    {
        if (sender is not null)
        {
            return sender is int value && value > Minimum;
        }

        return false;
    }
}