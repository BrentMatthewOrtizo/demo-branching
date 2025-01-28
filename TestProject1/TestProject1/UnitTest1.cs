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
    {
        // This was stupid
        Assert.False(false);
        Asser.True(!false);
    }
}
