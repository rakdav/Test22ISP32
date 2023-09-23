namespace Lab2TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCircle()
        {
            MyClass myClass = new MyClass();
            Assert.AreEqual(myClass.ToCircle(5,5,5,2,3),true);
            Assert.AreEqual(myClass.ToCircle(5, 5, 5, 10, 15), false);
        }

        [TestMethod]
        public void TestMethodSum()
        {
            MyClass myClass = new MyClass();
            Assert.AreEqual(myClass.Sum(2,2), 4);
            Assert.AreEqual(myClass.Sum(5,8), 13);
        }
    }
}