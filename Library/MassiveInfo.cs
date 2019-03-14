using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMassive
{
    public class MassiveInfo
    {
        private int[] massive_1;
        private int[,] massive_2;

        public MassiveInfo(int x, int y)
        {
            this.x = x;
            this.y = y;
            massive_1 = new int[x, y];

        }
    }
}
