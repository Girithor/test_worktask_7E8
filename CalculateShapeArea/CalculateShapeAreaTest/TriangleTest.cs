namespace CalculateShapeAreaTest
{
    
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void GetArea_By_3_Side()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedArea = 6;

            double[] sideArray = { sideA, sideB, sideC };

            var triangle = new Triangle(sideArray);

            Assert.AreEqual(expectedArea, triangle.CalculateArea(), 0.01, "Triangle area calculated is incorrect");
        }

        [TestMethod]
        public void GetArea_Right_Triangle()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 0;
            double expectedArea = 6;

            double[] sideArray = { sideA, sideB, sideC };

            var triangle = new Triangle(sideArray);

            Assert.AreEqual(expectedArea, triangle.CalculateArea(), 0.01, "Rigth triangle area calculated is incorrect");
        }

        [TestMethod]
        public void GetArea_Right_Triangle_By_Add_Method()
        {
            double sideA = 6;
            double sideB = 8;
            double sideC = 0;
            double expectedArea = 24;

            double[] sideArray = { sideA, sideB, sideC };

            var triangle = new Triangle(sideArray);

            Assert.AreEqual(expectedArea, triangle.GetAreaRightTriangleBy2Side(), 0.01, "Rigth triangle area calculated is incorrect");
        }

        [TestMethod]
        public void Incorrect_array_size()
        {
            double sideA = 15;
            double sideB = 24;

            double[] sideArray = { sideA, sideB };

            try
            {
                var circle = new Triangle(sideArray);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, string.Format(ResoucesConstant.ErrorMessages.IndexSideError, "3"));
            }
        }
    }
}