using UnitTestConsole;

namespace TestKey
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethodGetSalaryTest1()
        {
            Researcher researcher = new Researcher();
            researcher.Factor = 4;
            researcher.NumOfPaper = 2;
            researcher.PaperRank = 3;

            Assert.AreEqual(13.2324, researcher.GetSalary());
        }
        

      


  


    }
}