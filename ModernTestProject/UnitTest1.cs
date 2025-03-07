using ClassLibrary1;

namespace ModernTestProject;

public class Tests
{

    private readonly Class1 _class1 = new Class1();

    [Test]
    public void Test1()
    {
        var result = _class1.TupleMethod();
        Assert.That(result, Is.Not.Null);
    }
}
