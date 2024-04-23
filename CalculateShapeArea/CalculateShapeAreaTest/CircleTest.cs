namespace CalculateShapeAreaTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void GetArea_By_Radius()
        {
            double radius = 3;
            double expectedArea = 28.27;

            double[] radiusArray = { radius };

            var circle = new Circle(radiusArray);

            Assert.AreEqual(expectedArea, circle.CalculateArea(), 0.01, "Circle area calculated is incorrect");
        }

        [TestMethod]
        public void Incorrect_array_size()
        {
            double radius1 = 3;
            double radius2 = 8;

            double[] radiusArray = { radius1, radius2 };

            try
            {
                var circle = new Circle(radiusArray);
            }
            catch (Exception ex) 
            {
                StringAssert.Contains(ex.Message, string.Format(ResoucesConstant.ErrorMessages.IndexSideError, "1"));
            }
        }
    }
}
