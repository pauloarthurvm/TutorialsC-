using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Sphere {

        public static double circumference(double radius) {
            return 2.0 * Math.PI * radius;
        }

        public static double volume(double radius) {
            return (4.00 * Math.PI * Math.Pow(radius, 3.00)) / 3.00;
        }
    }
}
