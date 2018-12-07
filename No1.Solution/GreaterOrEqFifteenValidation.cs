namespace No1.Solution
{
    public class GreaterOrEqFifteenValidation : IValidation
    {
        public bool IsValid(string password) => password.Length >= 15;
    }
}