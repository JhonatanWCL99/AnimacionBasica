using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;

namespace EstructuraJuego
{
    class Fondos:ListadeObjeto
    {
        public Fondos()
        {
            Partes.Add(new Fondo_Suelo());
            Partes.Add(new Fondo_Trasero());
        }
    }

    class Fondo_Suelo:Objeto
    {
        Color4 color1;
        Vector3 centrodemasa1;
        public Fondo_Suelo()
        {
            centrodemasa1 = new Vector3(0, 0, 0);
            color1 = new Color4(0.3f, 1.0f, 0.5f, 1.0f);
            
            float[] vertices1 =
            {
                 6.5f, 0.0f, -5.5f,
                 6.5f, -2.5f, 0.0f,
                -6.5f, -2.5f, 0.0f,
                -6.5f, 0.0f, -5.5f,
                };

            uint[] indices1 =
            {
                0,1,2,
                0,2,3
            };
            cargarBuffers(vertices1, indices1, color1, centrodemasa1);
        }
            

    }

    class Fondo_Trasero:Objeto
    {
        Color4 color1;
        Vector3 centrodemasa1;
        public Fondo_Trasero()
        {
            centrodemasa1 = new Vector3(0, 0, 0);
            color1 = new Color4(0.0f, 0.1f, 0.3f, 1.0f);

            float[] vertices1 =
            {
                 6.5f, 0.0f, -5.5f,
                 6.5f, 6.5f, -5.5f,
                -6.5f, 6.5f, -5.5f,
                -6.5f, 0.0f, -5.5f,
                };

            uint[] indices1 =
            {
                0,1,2,
                0,2,3
            };
            cargarBuffers(vertices1, indices1, color1, centrodemasa1);
        }

    }
}
