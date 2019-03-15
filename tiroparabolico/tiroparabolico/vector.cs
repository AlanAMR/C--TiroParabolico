using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiroparabolico
{
    public class vector
    {
        float x;
        float y;
        float t;

        public vector(float a, float b, float c){
            x = a;
            y = b;
            t = c;
        }

        public void setx(float a) { x = a; }
        public void sety(float a) { y = a; }
        public void sett(float a) { t = a; }

        public float getx() { return x; }
        public float getY() { return y; }
        public float getr() { return t; }
    }
}
