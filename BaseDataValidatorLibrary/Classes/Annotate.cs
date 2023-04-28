using System.ComponentModel.DataAnnotations;

namespace BaseDataValidatorLibrary.Classes;

public class Annotate
{
    public static bool ValidEmail(string emailAddress) 
        => new EmailAddressAttribute().IsValid(emailAddress);
}