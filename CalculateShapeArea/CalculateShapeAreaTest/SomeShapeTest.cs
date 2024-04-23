namespace CalculateShapeAreaTest
{
    [TestClass]
    public class SomeShapeTest
    {
        [TestMethod]
        public void Test_Is_Cirlce_Shape()
        {
            double radius = 3;
            double expectedArea = 28.27;

            double[] radiusArray = { radius };

            var area = SomeShape.GetArea(radiusArray);

            Assert.AreEqual(expectedArea, area, 0.01, "Circle area calculated is incorrect");
        }

        [TestMethod]
        public void Test_Is_Triangle_Shape()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedArea = 6;

            double[] sideArray = { sideA, sideB, sideC };

            var area = SomeShape.GetArea(sideArray);

            Assert.AreEqual(expectedArea, area, 0.01, "Triangle area calculated is incorrect");
        }

        [TestMethod]
        public void Test_Is_Right_Triangle_Shape()
        {
            double sideA = 3;
            double sideB = 4;

            double expectedArea = 6;

            double[] sideArray = { sideA, sideB };

            var area = SomeShape.GetArea(sideArray);

            Assert.AreEqual(expectedArea, area, 0.01, "Rigth triangle area calculated is incorrect");
        }

        [TestMethod]
        public void Test_Incorrect_Array()
        {

            double[] sideArray = new double[0];
            double area = 0;

            try
            {
                area = SomeShape.GetArea(sideArray);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, new NullReferenceException().Message);
            }
        }

        [TestMethod]
        public void Test_Unexpected_Shape()
        {
            double[] sideArray = new double[20];
            double expectedArea = 0;

            var area = SomeShape.GetArea(sideArray);

            Assert.AreEqual(expectedArea, area, 0.1, "Shape expected but incorrect calculated");
        }
    }
}
