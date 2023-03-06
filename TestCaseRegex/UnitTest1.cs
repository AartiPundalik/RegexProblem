using RegexProblem;

namespace TestCaseRegex;

[TestClass]
public class UnitTest1
{
    RegexProgram regexprogram = new RegexProgram(null);

    [TestMethod]
    public void Given_Empty_FirstName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
    {
        try
        {
            string result = regexprogram.ValidateFirstName("Aarti");
        }
        catch (UserRegistrationException obj)
        {
            Assert.AreEqual("Please do not Enter the Null Input", obj.Message);
        }
    }
        [TestMethod]
        public void Given_Empty_LastName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string result = regexprogram.ValidateLastName("Pundalik");
            }
            catch (UserRegistrationException obj)
            {
                Assert.AreEqual("Please do not Enter the Null Input", obj.Message);
            }
        }
}

