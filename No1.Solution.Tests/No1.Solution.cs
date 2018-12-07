using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class Test_Password_Checker
    {
        [Test]
        public void TestpasswordInOrderOfStatements()
        {
            List<IValidation> listValidations = new List<IValidation>();

            listValidations.Add(new LessThanSevenValidation());
            listValidations.Add(new GreaterOrEqFifteenValidation());
            listValidations.Add(new LeastAlphabeticalValidation());
            listValidations.Add(new NumberContainsValidation());

            var sqlRepository = new SqlRepository();
            string password = "114E8941f782";
            bool passwordIsValid;
            var passwordCheckerService = 
                new PasswordCheckerService(password, sqlRepository, listValidations);
            
            passwordIsValid = passwordCheckerService.VerifyPassword();
            Assert.IsTrue(passwordIsValid);
                        
            password = "184";
            passwordCheckerService =
                new PasswordCheckerService(password, sqlRepository, listValidations);

            passwordIsValid = passwordCheckerService.VerifyPassword();
            Assert.IsFalse(passwordIsValid);

            password = "184123548921";
            passwordCheckerService =
                new PasswordCheckerService(password, sqlRepository, listValidations);

            passwordIsValid = passwordCheckerService.VerifyPassword();
            Assert.IsFalse(passwordIsValid);

            password = "18412354Ed8921111111111";
            passwordCheckerService =
                new PasswordCheckerService(password, sqlRepository, listValidations);

            passwordIsValid = passwordCheckerService.VerifyPassword();
            Assert.IsFalse(passwordIsValid);
        }
    }
}
