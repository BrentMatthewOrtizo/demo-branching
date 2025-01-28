namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }

    [Fact]
    public void FalseIsFalse()
    
    public void FalseIsFalseAndStringIsEmpty()
    {
        // This was stupid
        Assert.False(false);
        Asser.True(!false);
        Assert.False(!true);
        Assert.Empty("");
    }
}
