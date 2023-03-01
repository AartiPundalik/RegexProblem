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
}

