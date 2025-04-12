namespace TestProject1;

using ClassLibrary;

[TestClass]
public class UnitTests
{
    protected virtual bool Flag => true;

    [TestMethod]
    public void TestMethod1()
    {
        Class1.Method1(Flag);
    }
}
