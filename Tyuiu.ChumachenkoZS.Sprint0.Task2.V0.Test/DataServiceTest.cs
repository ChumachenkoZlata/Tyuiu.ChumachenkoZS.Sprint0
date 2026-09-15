using Tyuiu.ChumachenkoZS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ChumachenkoZS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Злата";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Злата", res);
        }
    }
}
