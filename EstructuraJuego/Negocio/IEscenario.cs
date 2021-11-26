using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace EstructuraJuego.Negocio
{
    interface IEscenario
    {
        void dibujarEscenario();

        void TrasladarEscenario(Vector3 Translacion);

        void EscalarEscenario(float fov);

        void RotarEscenario(float Angulo,String eje);
    }
}
