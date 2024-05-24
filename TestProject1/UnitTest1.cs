using Problems;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Arrange
        [DataRow(153)]
        [DataRow(370)]
        public void TestArmstrong(int x)
        {
            //Assert
            Assert.IsTrue(Program.Armstrong(x));
        }
        [TestMethod]
        //Arrange
        [DataRow(5,120)]
        [DataRow(4,24)]
        public void TestFactorial(int Num,long Expected)
        {
            //Action
            long Actual = Program.Factorial(Num);
            //Assert
            Assert.AreEqual(Expected,Actual);
        }

        [TestMethod]
        //Arrange
        [DataRow(3,true)]
        [DataRow(10,false)]
        [DataRow(7,true)]
        public void TestPrimeNumber(int number,bool expected)
        {
            //Action
            bool actual = Program.Prime(number);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        //Arrange
        [DataRow("apple","All Present")]
        [DataRow("Men", "One or More - Present")]
        [DataRow("Chiru", "None Present")]
        public void TestCharacterCheckMethod(string str,string expected)
        {
            //Action
            string Actual = Program.CharacterCheckMethod(str);
            //Assert
            Assert.AreEqual(expected,Actual);
        }
        [TestMethod]
        public void TestEvenNumberOnly()
        {
            //Arrange
            int[] nums = { 1, 2, 3, 4, 5, 5, 6 };
            List<int> expected = nums.Select(x => x).Where(x => x%2==0).ToList();
            //Action
            List<int> actual = Program.EvenNumberOnly(nums);
            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}