using System.ComponentModel.DataAnnotations;

namespace BaseDataValidatorLibrary.CommonRules;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class LesserThanAttribute : ValidationAttribute
{
    /// <summary>
    /// Assert a value is greater than <see cref="Maximum"/>
    /// </summary>
    /// <param name="maximum">value to validate</param>
    public LesserThanAttribute(int maximum)
    {
        Maximum = maximum;
    }
    /// <summary>
    /// Max value
    /// </summary>
    public int Maximum { get; set; }
    public override string FormatErrorMessage(string name)
    {
        if (ErrorMessage == null && ErrorMessageResourceName == null)
        {
            ErrorMessage = "is unacceptable";
        }

        return $"{name} must be less than {Maximum}";

    }

    public override bool IsValid(object sender)
    {
        if (sender is not null)
        {
            return sender is int value && value < Maximum;
        }
        else
        {
            return false;
        }
    }
}