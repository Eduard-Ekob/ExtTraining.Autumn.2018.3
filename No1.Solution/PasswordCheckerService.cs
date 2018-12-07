using System.Collections.Generic;

namespace No1.Solution
{
    public class PasswordCheckerService 
    {
        List<IValidation> statements;
        private IRepository repository;
        private string password;
        public PasswordCheckerService(string password, 
            IRepository repository, 
            List<IValidation> statements)
        {

            this.password = password;
            this.repository = repository;
            this.statements = statements;
        }

        public bool VerifyPassword()
        {
            bool validPassword = false;
            foreach (var p in statements)
            {                
                validPassword = p.IsValid(password) == false ? true : false;
                if (!validPassword)
                {
                    break;
                }
            }

            if (validPassword)
            {
                CreateRepository();
            }

            return validPassword;         
        }

        private void CreateRepository()
        {
            repository.Create(password);            
        }
    }
}