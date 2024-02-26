using JenkinsDemo;

namespace FirstTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_sayJenkins_1()
        {
            TestMe obj1 = new TestMe();
            string result = obj1.sayJenkins(2);
            Assert.AreEqual("JenkinsJenkins", result);
        }

        [Test]
        public void Test_sayJenkins_2()
        {
            TestMe obj1 = new TestMe();
            string result = obj1.sayJenkins(1);
            Assert.AreEqual("Jenkins", result);
        }
    }
}