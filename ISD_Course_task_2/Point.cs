using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_2
{
    class Point
    {
        private int x;
        private int y;
        private string name;
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public string Name { get { return name; } }
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }

    class Figure
    {
        private List<Point> FigurePointList;
        public Figure(Point pt1, Point pt2, Point pt3)
        {
            FigurePointList = new List<Point>();
            FigurePointList.Add(pt1);
            FigurePointList.Add(pt2);
            FigurePointList.Add(pt3);
        }
        public Figure(Point pt1, Point pt2, Point pt3, Point pt4)
            : this(pt2, pt3, pt4)
        {
            FigurePointList = new List<Point>();
            FigurePointList.Add(pt1);
        }
        public Figure(Point pt1, Point pt2, Point pt3, Point pt4, Point pt5)
            : this(pt2, pt3, pt4, pt5)
        {
            FigurePointList = new List<Point>();
            FigurePointList.Add(pt1);
        }
        public string GetName()
        {
            string FigeureName = "";
            foreach(Point CurPoint in FigurePointList)
            {
                FigeureName += CurPoint.Name;
            }
            return FigeureName;
        }
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
        }
        public void PerimeterCalculator()
        {
            double perimetr = 0;
            for(int i = 0; i < FigurePointList.Count - 1; i++)
            {
                perimetr += LengthSide(FigurePointList[i], FigurePointList[i + 1]);
            }
            perimetr += LengthSide(FigurePointList[0], FigurePointList[FigurePointList.Count - 1]);
            Console.WriteLine("Perimetr = {0}", perimetr);
        }
    }
}
