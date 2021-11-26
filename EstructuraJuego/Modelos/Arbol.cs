using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;

namespace EstructuraJuego
{
    class Arbol:ListadeObjeto
    {
        public Arbol()
        {
            Partes.Add(new Tronco());
            Partes.Add(new Rama());
        }
            
    }
    class Tronco:Objeto
    {
        Color4 color1;
        Vector3 centrodemasa1;
        public Tronco()
        {
            centrodemasa1 = new Vector3(0, 0, 0);
            color1 = new Color4(1.0f, 0.5f, 0.2f, 1.0f);

            float[] vertices1 =
            {
                 3.1f, 0.0f, -4.0f,
                 3.1f, -0.35f, -4.0f,
                 2.6f, -0.35f, -4.0f,
                 2.6f,  0.0f, -4.0f,

                 3.1f, 0.0f, -4.25f,
                 3.1f, -0.5f, -4.25f,
                 2.6f, -0.5f, -4.25f,
                 2.6f,  0.0f, -4.25f,

                };

            uint[] indices1 =
            {
                0,1,2,
                0,2,3,

                0,1,5,
                0,4,5,

                4,5,6,
                4,6,7,

                2,3,6,
                3,6,7

            };
            cargarBuffers(vertices1, indices1, color1, centrodemasa1);
        }

    }

    class Rama : Objeto
    {
        Color4 color1;
        Vector3 centrodemasa1;
        public Rama()
        {
            centrodemasa1 = new Vector3(0, 0, 0);
            color1 = new Color4(0.2f, 0.5f, 0.0f, 1.0f);

            float[] vertices1 =
            {
                 3.5f, 0.0f, -4.0f,
                 2.0f, 0.0f, -4.0f,
                 2.75f, 2.0f, -4.0f,

                  3.75f, 0.25f, -4.25f,
                 2.25f, 0.25f, -4.25f,
                 2.75f, 2.0f, -4.0f,

                };

            uint[] indices1 =
            {
                0,1,2,
                0,3,5,
                3,4,5,
                1,2,4,

                0,1,4,
                0,3,4

            };
            cargarBuffers(vertices1, indices1, color1, centrodemasa1);
        }

    }
}
