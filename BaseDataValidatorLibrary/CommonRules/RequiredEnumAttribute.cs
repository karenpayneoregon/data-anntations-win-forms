using System.ComponentModel.DataAnnotations;

namespace BaseDataValidatorLibrary.CommonRules;

/// <summary>
/// Validates a property of type Enum is assigned.
/// For this to work number the elements from 1 to x,
/// do not assign 0 to an element.
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class RequiredEnumAttribute : RequiredAttribute
{
    /// <summary>
    ///  Override of <see cref="ValidationAttribute.IsValid(object)" />
    /// </summary>
    public override bool IsValid(object sender)
    {
        if (sender == null)
        {
            return false;
        }

        var type = sender.GetType();
        return type.IsEnum && Enum.IsDefined(type, sender); ;
    }
}