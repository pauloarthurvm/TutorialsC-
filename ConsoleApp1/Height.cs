using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Height {
        private double[] heightVector;

        public Height(int number) {
            heightVector = new double[number];
        }

        public void addHeight(double height, int position) {
            heightVector[position] = height;
        }

        public double getAverage() {
            double average = 0.0;
            for(int i = 0; i < heightVector.Length; i++) {
                average += heightVector[i];
            }
            return average / heightVector.Length;
        }

        public double heightAt(int position) {
            return heightVector[position];
        }
    }
}
