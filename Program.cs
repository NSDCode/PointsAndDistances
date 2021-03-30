using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double t_dist = 0;
            int k = 10;
            Random r = new Random(Guid.NewGuid().GetHashCode());
            Point[] Points = new Point[k];
            double[] Distances = new double[k];
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i] = new Point(r.Next(0, 100), r.Next(0, 100));
                if (i < 2)
                    continue;
                double dist = Math.Sqrt(Math.Pow(Points[i].X - Points[i - 1].X, 2) + Math.Pow(Points[i].Y - Points[i - 1].Y, 2));
                t_dist += dist;
                Console.Write($"P{i} ({Points[i].X},{Points[i].Y}) P{i - 1} ({Points[i - 1].X},{Points[i - 1].Y})\n");
                Console.Write($"Distance between P{i} and P{i - 1} is: {Math.Round(dist, 2)}\n");
                Distances[i] = dist;

            }
            Array.Sort(Distances);
            Console.Write($"The shortest distance between two points is: {Math.Round(Distances[2], 2)}\n");
            Console.Write($"The total distance is: {Math.Round(t_dist, 2)}");
            Console.ReadLine();
        }

    }
}
