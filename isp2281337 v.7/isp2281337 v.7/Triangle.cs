﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp2281337_v._7
{
    class Triangle
    {
        private int _sideA;
        private int _sideB;
        private int _sideC;

        public int SideA
        {
            get
            {
                return _sideA;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else _sideA = value;
            }
        }

        public int SideB
        {
            get
            {
                return _sideB;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else _sideB = value;
            }
        }

        public int SideC
        {
            get
            {
                return _sideC;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else _sideC = value;
            }
        }

        public void SetParams(int sideA, int sideB, int sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public int GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        public void DoubleValues()
        {
            if (SideA != 0 && SideB != 0 && SideC != 0)
            {
                SideA *= 2;
                SideB *= 2;
                SideC *= 2;
            }
            else throw new ArgumentNullException();
        }

        public static bool operator true(Triangle triangle)
        {
            if (triangle.SideA > 0 && triangle.SideB > 0 && triangle.SideC > 0)
                return true;
            else return false;
        }

        public static bool operator false(Triangle triangle)
        {
            return triangle.SideA <= 0 && triangle.SideB <= 0 && triangle.SideC <= 0;
        }

        public static Triangle operator ++(Triangle triangle)
        {
            triangle.SideA++;
            triangle.SideB++;
            triangle.SideC++;
            return triangle;
        }

        public static Triangle operator --(Triangle triangle)
        {
            triangle.SideA--;
            triangle.SideB--;
            triangle.SideC--;
            return triangle;
        }

        public int Equilateral(int side)
        {
            return SideA = SideB = SideC = side;
        }

    }
}
