﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplimat_labs.Models
{
    public class Vector3
    {
        public float x, y, z;

        public Vector3()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

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
    }
}
