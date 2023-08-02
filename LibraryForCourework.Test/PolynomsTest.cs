using LibraryForCoursework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForCourework.Test
{
    public class PolynomsTest
    {
        [Fact]
        public void FindNewtonPolynom_arrayXarrayYarrayA_and_x05F_returnedMinus9dot5268()
        {
            //ARRANGE
            Polynoms polynom = new Polynoms();
            Matrix matrix = new Matrix();
            double[] massX = { -1, 1.5, 3, 5 };
            double x = 0.5;
            double[] massY = { 4, -7, 1, -8 };
            double[] massA = matrix.MatrixDisaddiction(massX, massY);
            double excepted = -9.5268;

            //ACT
            double poly = polynom.FindNewtonPolynom(massX, massY, massA, x);

            //ASSERT
            Assert.Equal(excepted, Math.Round(poly, 4));
        }
    }
}
