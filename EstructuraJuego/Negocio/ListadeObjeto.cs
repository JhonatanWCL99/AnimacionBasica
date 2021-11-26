using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace EstructuraJuego
{
    class ListadeObjeto
    {
        public List<Objeto> Partes = new List<Objeto>();

        public void dibujarPartes()
        {
            foreach (Objeto Obj in Partes)
            {
                Obj.dibujar();
            }
        }
        public void eliminarPartes()
        {
            foreach (Objeto Obj in Partes)
            {
                Obj.delete();
            }
        }

        public void TrasladarPartes(Vector3 traslacion)
        {
            foreach (Objeto Obj in Partes)
            {
                Obj.Trasladar(traslacion);
            }
        }
        public void EscalarPartes(float fov)
        {
            foreach (Objeto Obj in Partes)
            {
                Obj.Escalar(fov);
            }
        }
        public void setMatricesPartes(Matrix4 model, Matrix4 view, Matrix4 projection)
        {
            foreach (Objeto Obj in Partes)
            {
                Obj.setMatrices(model, view, projection);
            }

        }
        public void RotarPartes(float angulo, String eje)
        {
            foreach (Objeto Obj in Partes)
            {
                switch (eje)
                {
                    case "x": Obj.RotarX(angulo); break;
                    case "y": Obj.RotarY(angulo); break;
                    case "z": Obj.RotarZ(angulo); break;
                    default:
                        break;
                }
            }
        }

    }
}
