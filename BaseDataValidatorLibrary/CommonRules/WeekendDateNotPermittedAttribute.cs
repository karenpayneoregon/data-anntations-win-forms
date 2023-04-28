using System.ComponentModel.DataAnnotations;

namespace BaseDataValidatorLibrary.CommonRules;

/// <summary>
/// Disallow date to be a weekend date
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class WeekendDateNotPermittedAttribute : ValidationAttribute
{
    /// <summary>
    ///  Override of <see cref="ValidationAttribute.IsValid(object)" />
    /// </summary>
    public override bool IsValid(object senderDate)
    {
        DateTime date = Convert.ToDateTime(senderDate);
        return date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
    }
}