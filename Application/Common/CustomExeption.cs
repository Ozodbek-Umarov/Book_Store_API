

using System.ComponentModel.DataAnnotations;

namespace Application.Common;

public class CustomExeption : Exception
{
    public CustomExeption(string message)
        : base(message)
    {
        
    }

    public CustomExeption(ValidationResult result)
        : base(string.Join("\n", result.))
    {
       
    }
}
