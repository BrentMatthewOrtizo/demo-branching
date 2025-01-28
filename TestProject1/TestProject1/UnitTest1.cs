namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
    
    public void FalseIsFalseAndStringIsEmpty()
    {
        Assert.False(!true);
        Assert.Empty("");
    }
}