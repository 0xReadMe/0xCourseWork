using LibraryForCoursework;

namespace LibraryForCourework.Test
{
    public class MatrixTest
    {
        readonly Matrix matrix = new();

        [Fact]
        public void Multiplication_matrix333andMatrix445_returnedMultiplicatedMatrix()
        {
            //ARRANGE
            double[,] A = new double[,] 
            {
                {3}, 
                {3}, 
                {3} 
            };
            double[,] B = new double[,] 
            { 
                {4, 4, 5}
            };
            double[,] C = new double[3, 3];
            double[,] excepted = new double[,] 
            {
                {12, 12, 15}, 
                {12, 12, 15}, 
                {12, 12, 15}
            };

            //ACT
            C = matrix.Multiplication(A, B);

            //ASSERT
            Assert.Equal(excepted, C);
        }


        [Fact]
        public void Marina()
        {
            //ARRANGE
            double[,] B = new double[,]
            {
                {1},
                {2},
                {3}, 
                {4},
                {5}
            };
            double[,] A = new double[,]
            {
                {2, 6, 3, 2, 1},
                {3, 4, 5, 5, 1},
                {2, 6, 3, 2, 1},
                {3, 4, 5, 5, 1},
                {1, 2, 3, 4, 5}
        };
            double[,] C = new double[3, 3];
            double[,] excepted = new double[,]
            {
               { 31,58,57,58,35 } 
            };

            //ACT
            C = matrix.Multiplication(A, B);

            //ASSERT
            Assert.Equal(excepted, C);
        }

        [Fact]
        public void MatrixDisaddiction_()
        {
            //ARRANGE

            //ACT

            //ASSERT

        }
    }
}