using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aplimat_labs.Utilities;

namespace aplimat_labs.Models
{
    public class Vector3
    {
        public float x, y, z;
        private double v1;
        private Randomizer rng;
        private int v2;

        public Vector3()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

      /*  public Vector3(double v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }*/

        public Vector3(float x, float y , float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3 operator + (Vector3 left,Vector3 right)
        {
            return new Vector3(left.x + right.x,
                left.y + right.y,
                left.z + right.z);
        }

        public static Vector3 operator -(Vector3 left, Vector3 right)
        {
            return new Vector3(left.x - right.x,
               left.y - right.y,
               left.z - right.z);
        }

        public Vector3(double x , double y, double z)
        {
            this.x = (float)x;
            this.y = (float)y;
            this.z = (float)z;
        }

        public Vector3(double v1, Randomizer rng, int v2)
        {
            this.v1 = v1;
            this.rng = rng;
            this.v2 = v2;
        }
    }
}
