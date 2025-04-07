using TKNS;



namespace TkTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGrade()
        {
            int[] points1 = { 15, 30, 2 };

            Programm.Appraiser appraiser = new Programm.Appraiser();

            Assert.AreEqual(appraiser.Grade(points1), 4);
        }

        [TestMethod]
        public void Negative1Test()
        {
            int[] points1 = { 15, 30, 2 };

            Programm.Appraiser appraiser = new Programm.Appraiser();

            Assert.AreEqual(appraiser.Grade(points1), 3);
        }

        [TestMethod]
        public void Negative2Test()
        {
            int[] points2 = { 30, 30, 30 };

            Programm.Appraiser appraiser = new Programm.Appraiser();

            Assert.AreEqual(appraiser.Grade(points2), 5);
        }

        [TestMethod]
        public void Negative3Test()
        {
            int[] points3 = { 30, 30, -3 };

            Programm.Appraiser appraiser = new Programm.Appraiser();

            Assert.AreEqual(appraiser.Grade(points3), 5);
        }

        [TestMethod]
        public void Negative4Test()
        {
            int[] points4 = { 30, -3 };

            Programm.Appraiser appraiser = new Programm.Appraiser();

            Assert.AreEqual(appraiser.Grade(points4), 5);
        }

        [TestMethod]
        public void Negative5Test()
        {
            int[] points5 = { };

            Programm.Appraiser appraiser = new Programm.Appraiser();

            Assert.AreEqual(appraiser.Grade(points5), 5);
        }

        [TestMethod]
        public void Negative6Test()
        {
            int[] points5 = { 1, 1 };

            Programm.Appraiser appraiser = new Programm.Appraiser();

            Assert.AreEqual(appraiser.Grade(points5), 5);
        }
    }
}