using System.Linq;

namespace No1.Solution
{
    public class LeastAlphabeticalValidation : IValidation
    {
        public bool IsValid(string password) => (!password.Any(char.IsLetter));
    }
}