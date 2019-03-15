using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiroparabolico
{
    class tiroParabolico
    {
        List<vector> vectores;
        float velocidad;
        float angulo;
        float aceleracion;

        //Math.Cos(angulo*(Math.PI/180)) recordatorio, convertir de grados a radianes


        public tiroParabolico(float vel, float ang, float ace) {
            vectores = new List<vector>();
            velocidad = vel;
            aceleracion = ace;
            angulo = ang;
            calularVectores();
        }

        public List<vector> getListVector() {
            return vectores;
        }

        public void calularVectores() {
            float tiempo = tiempoVuelo();

            for (float i = 0; i < tiempo; i += (float)0.1) {
                float x = (float)(i * velocidad * Math.Cos(angulo * (Math.PI / 180)));
                float y = (float)( (velocidad*Math.Sin(angulo * (Math.PI /180) ) * i ) - (0.5*aceleracion*i*i));
                vector aux = new vector(x,y,i);
                vectores.Add(aux);
            }
        }

        public float alturaMaxima() {

            double val = (velocidad * velocidad) * (Math.Sin(angulo * (Math.PI / 180)) * Math.Sin(angulo * (Math.PI / 180))) / (2 * aceleracion);
            return (float)val;
        }

        public float alcance() {
            double val = ((velocidad * velocidad) * Math.Sin((2 * angulo) * (Math.PI / 180))) / aceleracion;
            return (float)val;
        }

        public float tiempoVuelo() {
            double val = (2 * velocidad * Math.Sin(angulo * (Math.PI / 180))) / aceleracion;
            return (float)val;
        }

        public static float getAlturaMaxima(float vel, float ang, float ace) {
            double val = (vel * vel) * (Math.Sin(ang* (Math.PI / 180)) * Math.Sin(ang* (Math.PI / 180))) / (2 * ace);
            return (float)val;
        }

        public static float getAlcance(float vel, float ang, float ace) {
            double val = ((vel * vel) * Math.Sin((2 * ang) * (Math.PI / 180))) / ace;
            return (float)val;
        }
    }
}
