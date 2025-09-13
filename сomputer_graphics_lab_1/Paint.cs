using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сomputer_graphics_lab_1
{
    class Paint
    {
        private Matrix<double> coords;

        private Paint()
        {
            coords = new Matrix<double>(40, 3);
            coords[0, 0] = -1;
            coords[0, 1] = 20;
            coords[0,2] = 1;
            coords[1, 0] = -3;
            coords[1, 1] = 20;
            coords[1, 2] = 1;
            coords[2, 0] = ;
            coords[2, 1] = 20;
            coords[2, 2] = 1;

        }

        private void move()
        {

        }

        private void zoom()
        {

        }
    }
}
