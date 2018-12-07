using System.Linq;

namespace No1.Solution
{
    public class NumberContainsValidation : IValidation
    {
        public bool IsValid(string password) => (!password.Any(char.IsNumber));
    }
}