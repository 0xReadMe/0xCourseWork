using LibraryForCoursework;

namespace LibraryForCourework.Test
{
    public class InfiniteSeriesTest
    {
        readonly InfiniteSeries infiniteSeries = new();

        [Fact]
        public void Recurse_1and0and09F_returned0148F()
        {
            //ARRANGE
            double x = -0.8;
            double[,] ArrayA = new double[1, 1];
            double excepted = 11.176;

            //ACT
            ArrayA[0, 0] = infiniteSeries.Recurse(x);

            //ASSERT
            Assert.Equal(excepted, Math.Round(ArrayA[0, 0], 3));
        }

        [Fact]
        public void ControlSummand_09F_returned0148F()
        {
            //ARRANGE
            double x = -0.8;
            double[,] ArrayAControl = new double[1, 1];
            double excepted = 11.18;

            //ACT
            ArrayAControl[0, 0] = infiniteSeries.ControlSummand(x);

            //ASSERT
            Assert.Equal(excepted, Math.Round(ArrayAControl[0, 0], 3));
        }
    }
}