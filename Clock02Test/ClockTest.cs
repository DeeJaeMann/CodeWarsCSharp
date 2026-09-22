
namespace Clock02Test;

public class ClockTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.That(Clock.Past(0, 1, 1), Is.EqualTo(61000));
    }
}