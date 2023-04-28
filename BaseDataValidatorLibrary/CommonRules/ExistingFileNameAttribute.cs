using System.ComponentModel.DataAnnotations;

namespace BaseDataValidatorLibrary.CommonRules;

/// <summary>
/// Provides rules for disallowing selection of an existing file along with
/// ensuring a description has been entered for the file.
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class ExistingFileNameAttribute : ValidationAttribute
{
    /// <summary>
    /// Default file not found text
    /// </summary>
    private const string DefaultFileNotFoundMessage =
        "Sorry but there is already an file with this name please rename your file";

    /// <summary>
    /// Default text for description of file
    /// </summary>
    private const string DefaultErrorMessage =
        "Please enter a name for your file name";

    public string FileNotFoundMessage { get; set; }
    /// <summary>
    ///  Override of <see cref="ValidationAttribute.IsValid(object)" />
    /// </summary>
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is not null)
        {
            var result = File.Exists(value.ToString()) ? 
                new ValidationResult(FileNotFoundMessage ?? DefaultFileNotFoundMessage) : 
                ValidationResult.Success;

            return result;
        }
        else
        {
            var result = new ValidationResult(ErrorMessage ?? DefaultErrorMessage);
            return result;
        }
    }
}