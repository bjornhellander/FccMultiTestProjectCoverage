namespace TestProject2;

[TestClass]
public class UnitTests : TestProject1.UnitTests
{
    protected override bool Flag => false;
}
