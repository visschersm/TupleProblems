using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProject
{
    [TestClass]
    public sealed class Test1
    {
        private readonly Class1 _class1 = new Class1();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _class1.TupleMethod();
        }
    }
}