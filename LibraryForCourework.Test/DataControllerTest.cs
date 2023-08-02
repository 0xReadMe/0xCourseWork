using LibraryForCoursework;

namespace LibraryForCourework.Test
{
    public class DataControllerTest
    {
        readonly DataController controller = new();
        [Fact]
        public void Sort_array321_returnedArray123()
        {
            //ARRANGE
            double[] testArray = { 3, 2, 1 };
            double[] expected = { 1, 2, 3 };

            //ACT
            double[] act = controller.Sort(testArray);

            //ASSERT
            Assert.Equal(expected, act);
        }
    }
}