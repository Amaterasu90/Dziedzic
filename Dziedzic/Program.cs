using System.Text;
using System.IO;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System;

namespace Dziedzic
{
    class Program
    {
        private static string _fName, _symbol;
        private static int _nx, _ny, _nz;
        private static double _a;
        static void Main(string[] args)
        {
            List<Vector3> d = new List<Vector3>()
            {
                new Vector3(0.0f,0.0f,0.0f),
                new Vector3(0.5f,0.0f,0.5f),
                new Vector3(0.5f,0.5f,0.0f),
                new Vector3(0.0f,0.5f,0.5f)
            };
            _a = Double.Parse(args[0]);
            _nx = Int32.Parse(args[1]);
            _ny = Int32.Parse(args[2]);
            _nz = Int32.Parse(args[3]);
            _symbol = args[4];
            _fName = args[5];
            using (StreamWriter f = new StreamWriter(_fName))
            {
                f.WriteLine(_nx * _ny * _nz * d.Count);
                f.WriteLine("sraj sie");
                for (int x = 0; x < _nx; ++x)
                {
                    for (int y = 0; y < _ny; ++y)
                    {
                        for (int z = 0; z < _nz; ++z)
                        {
                            for (int i = 0; i < d.Count;i++ )
                            {
                                double d_x = x * _a + d[i].X;
                                double d_y = y * _a + d[i].Y;
                                double d_z = z * _a + d[i].Z;
                                f.WriteLine("{0} {1} {2} {3}", _symbol, d_x, d_y, d_z);
                            }
                        }
                    }
                }
            }
        }
    }
}
