using RegexProblem;

namespace TestCaseRegex;

[TestClass]
public class UnitTest1
{
    RegexProgram regexprogram = new RegexProgram();
    
    [TestMethod]
    public void Test1()
    {
        string firstname = regexprogram.ValidateFirstName("Aarti");
        Assert.AreEqual(firstname, "Aarti");
    }
    [TestMethod]
    public void Test2()
    {       
        string lastname = regexprogram.ValidateLastName("Pundalik");
        Assert.AreEqual(lastname, "Pundalik");
    }
    [TestMethod]
    public void Test3()
    {
        string email_id = regexprogram.ValidateEmail("abc.xyz@bl.co.in");
        Assert.AreEqual(email_id, "abc.xyz@bl.co.in");
    }
    [TestMethod]
    public void Test4()
    {
        string PhoneNumber = regexprogram.ValidatePhoneNumber("91 8668285117");
        Assert.AreEqual(PhoneNumber, "91 8668285117");
    }
    [TestMethod]
    public void Test5()
    {
        string Password = regexprogram.ValidatePassword("Password");
        Assert.AreEqual(Password, "Password");
    }
    [TestMethod]
    public void Test6()
    {
        string stringPassword = regexprogram.ValidateStringPassword("Aarti123");
        Assert.AreEqual(stringPassword, "Aarti123");
    }
    [TestMethod]
    public void Test7()
    {
        string NumericPassword = regexprogram.ValidateNumericPassword("Aarti689");
        Assert.AreEqual(NumericPassword, "Aarti689");
    }
   
}


