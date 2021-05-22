using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MarathonSprint4
{
    interface IShape
    {
       double Area() => 0;
    }
    class Rectangle : IShape
    {
        public  double Length { get; set; } = 1;
        public  double Width { get; set; } = 2;
        public double Area() => Length * Width;
    }
    class Trapezoid : IShape
    {
        public  double Length1 { get; set; } = 1;
        public double Length2 { get; set; } = 5;
        public double Width { get; set; } = 1;
        public double Area() => 0.5 * (Length1 + Length2) * Width;
    }
    class Room<T> : ICloneable, IComparable where T : IShape
    {
        private  double Height { get; set; }
        public T Floor { get; set; }

        public object Clone()
        {
            return new Room<T>()
            {
                Height = this.Height,
                Floor = this.Floor
            };
        }

        public int CompareTo(object obj)
           => this.Floor.Area().CompareTo((obj as Room<T>).Floor.Area());

        public double Volume() => Height * Floor.Area();
    }
    class RoomComparerByVolume<T> : IComparer<T> where T :IShape
    {
        public int Compare([AllowNull] T x, [AllowNull] T y)
        {
            if ((x as Room<T>).Volume() > (y as Room<T>).Volume())
                return 1;
            else if ((x as Room<T>).Volume() > (y as Room<T>).Volume())
                return -1;
            else
                return 0;            
        }
    }

}
