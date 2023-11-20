using Binary7;

namespace Binary7Tests;

public class Tests
{
    [Test]
    public void BasicTest1()
    {
        Assert.That(Program.BinaryGenerator(10, 2), Is.EqualTo(new List<int> {3, 5, 6, 9}));
    }
    
    [Test]
    public void BasicTest2()
    {
        Assert.That(Program.BinaryGenerator(3600, 11), Is.EqualTo(new List<int> {2047, 3071, 3583}));
    }
    
    [Test]
    public void BigNumbersTest()
    {
        Assert.That(Program.BinaryGenerator(1000000000, 29), Is.EqualTo(new List<int> {536870911, 805306367, 939524095}));
    }
    
    [Test]
    public void InvalidFirstArgumentTest()
    {
        Assert.That(Program.BinaryGenerator(-32, 10), Is.EqualTo(new List<int>()));
    }
    
    [Test]
    public void InvalidSecondArgumentTest()
    {
        Assert.That(Program.BinaryGenerator(10, -1), Is.EqualTo(new List<int>()));
    }
}