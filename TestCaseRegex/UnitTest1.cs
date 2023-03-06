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
    [TestMethod]
    public void Given_Empty_EMAILID_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
    {
        try
        {
            string result = regexprogram.ValidateEmail("abc.xyz@bl.co.in");
        }
        catch (UserRegistrationException obj)
        {
            Assert.AreEqual("Please do not Enter the Null Input", obj.Message);
        }
    }
    [TestMethod]
    public void Given_Empty_PHONENUMBER_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
    {
        try
        {
            string result = regexprogram.ValidatePhoneNumber("91 8668285117");
        }
        catch (UserRegistrationException obj)
        {
            Assert.AreEqual("Please do not Enter the Null Input", obj.Message);
        }
    }
        [TestMethod]
        public void Given_Empty_PASSWORD_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string result = regexprogram.ValidatePassword("Password");
            }
            catch (UserRegistrationException obj)
            {
                Assert.AreEqual("Please do not Enter the Null Input", obj.Message);
            }
        }
    }
    
    


