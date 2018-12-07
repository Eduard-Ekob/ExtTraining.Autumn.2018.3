namespace No1.Solution
{
    public class LessThanSevenValidation : IValidation
    {
        public bool IsValid(string password) => password.Length < 7;
    }
}