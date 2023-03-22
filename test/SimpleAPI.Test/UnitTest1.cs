using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{
    TestController controller = new TestController();
    [Fact]
    public void GetReturnsName()
    {
        var returnValue = controller.Get(1);
        Assert.Equal("Claude nyongero",returnValue.Value);
    }
    [Fact]
    public void GetResults()
    {
        var returnValue = controller.Get();
        Assert.Collection(returnValue.Value);
    }
    [Fact]
    public void Test1()
    {

    }
}