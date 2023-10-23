using Binary7;

namespace Binary7Tests;

public class Tests
{
    [Test]
    public void BasicTest()
    {
        Assert.That(Program.BinaryGenerator(10, 2), Is.EqualTo(new List<int> {3, 5, 6, 9}));
    }
    
    [Test]
    public void BigNumbersTest()
    {
        Assert.That(Program.BinaryGenerator(100000, 16), Is.EqualTo(new List<int> {65535, 98303}));
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