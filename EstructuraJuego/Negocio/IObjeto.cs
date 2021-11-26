using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace EstructuraJuego
{
    interface IObjeto
    {
        void dibujar();

        void setOrigen(float x, float y, float z);

        void Trasladar(Vector3 Translacion);

        void Escalar(float fov);

        void RotarX(float angulo);

        void RotarY(float angulo);

        void RotarZ(float angulo);

    }
}
