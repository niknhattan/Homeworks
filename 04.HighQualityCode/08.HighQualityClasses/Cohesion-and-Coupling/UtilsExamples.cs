﻿using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(Utils.GetFileExtension("example"));
            Console.WriteLine(Utils.GetFileExtension("example.pdf"));
            Console.WriteLine(Utils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(Utils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(Utils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(Utils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                Utils.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                Utils.CalcDistance3D(5, 2, -1, 3, -6, 4));

            double height = 4;
            double width = 3;
            double depth = 5;
            Console.WriteLine("Volume = {0:f2}", Utils.CalcVolume(height, width, depth));
            Console.WriteLine("Diagonal XYZ = {0:f2}", Utils.CalcDiagonalXYZ(height, width, depth));
            Console.WriteLine("Diagonal XY = {0:f2}", Utils.CalcDiagonalXY(height, width));
            Console.WriteLine("Diagonal XZ = {0:f2}", Utils.CalcDiagonalXZ(width, depth));
            Console.WriteLine("Diagonal YZ = {0:f2}", Utils.CalcDiagonalYZ(height, depth));
        }
    }
}
