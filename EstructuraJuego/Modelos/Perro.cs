using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;

namespace EstructuraJuego
{
    class Perro : ListadeObjeto
    {
        public Perro()
        {
            Partes.Add(new Cabeza());
            Partes.Add(new Cuerpo());
            Partes.Add(new Cuello());
            Partes.Add(new Pata_Izquierda_Trasera());
            Partes.Add(new Pata_Izquierda_Delantera());
            Partes.Add(new Pata_Derecha_Trasera());
            Partes.Add(new Pata_Derecha_Delantera());
            Partes.Add(new Cola());
        }
    }
    class Cabeza : Objeto
    {
        Color4 color1;
        Vector3 centrodemasa1;
        public Cabeza()
        {
            centrodemasa1 = new Vector3(0, 0, 0);
            color1 = new Color4(0.8f, 0.0f, 0.2f, 1.0f);

            float[] vertices1 =
            {
                 -0.55f, -1.0f, -3.0f,
                 -0.55f, -1.5f, -3.0f,
                -0.8f, -1.5f, -3.0f,
                -0.8f, -1.0f, -3.0f,

                -0.45f, -0.9f, -3.25f,
                 -0.45f, -1.4f, -3.25f,
                -0.7f, -1.4f, -3.25f,
                -0.7f, -0.9f, -3.25f,

                -0.30f,-1.25f,-3.0f,
                -0.30f,-1.5f,-3.0f,
                -0.55f, -1.5f, -3.0f,
                -0.55f, -1.25f, -3.0f,

                -0.20f,-1.15f,-3.25f,
                -0.20f,-1.4f,-3.25f,
                -0.45f, -1.4f, -3.25f,
                -0.45f, -1.15f, -3.25f,

                -0.7f,-0.75f,-3.0f,
                -0.6f,-0.65f,-3.25f
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
                3,6,7,

                8,9,10,
                8,10,11,

                8,9,13,
                8,12,13,

                12,13,14,
                12,14,15,
                
                11,10,14,
                11,14,15,

                0,3,16,
                4,7,17

            };
            cargarBuffers(vertices1, indices1, color1, centrodemasa1);
        }
    }
    class Cuerpo : Objeto
    {
        Color4 color1;
        Vector3 centrodemasa1;
        public Cuerpo()
        {
            centrodemasa1 = new Vector3(0, 0, 0);
            color1 = new Color4(0.8f, 0.0f, 0.2f, 1.0f);

            float[] vertices1 =
            {
                 -1.0f, -1.0f, -3.0f,
                 -1.0f, -1.5f, -3.0f,
                -2.0f, -1.5f, -3.0f,
                -2.0f, -1.0f, -3.0f,

                -0.9f, -0.9f, -3.25f,
                 -0.9f, -1.4f, -3.25f,
                -1.9f, -1.4f, -3.25f,
                -1.9f, -0.9f, -3.25f,
                };

            uint[] indices1 =
            {
                0,1,2,
                0,2,3,

                0,1,5,
                0,5,4,

                4,5,6,
                4,6,7,

                2,3,6,
                3,6,7
            };
            cargarBuffers(vertices1, indices1, color1, centrodemasa1);
        }
    }
    class Cuello:Objeto
    {
        Color4 color1;
        Vector3 centrodemasa1;
        public Cuello()
        {
            centrodemasa1 = new Vector3(-1.9f, -1.5f, -3.0f);
            color1 = new Color4(0.8f, 0.0f, 0.2f, 1.0f);

            float[] vertices1 =
            {
                -0.95f,-1.15f,-3.15f,
                -0.95f,-1.30f,-3.15f,
                -0.75f,-1.30f,-3.15f,
                -0.75f,-1.15f,-3.15f,

                -0.94f,-1.14f,-3.25f,
                -0.94f,-1.29f,-3.25f,
                -0.74f,-1.29f,-3.25f,
                -0.74f,-1.14f,-3.25f,
            };

            uint[] indices1 =
            {
                0,1,2,
                0,2,3,

                0,1,5,
                0,5,4,

                4,5,6,
                4,6,7,

                2,3,6,
                3,6,7

            };
            cargarBuffers(vertices1, indices1, color1, centrodemasa1);
        }
    }
    class Pata_Izquierda_Trasera : Objeto
    {
        Color4 color1;
        Vector3 centrodemasa1;
        public Pata_Izquierda_Trasera()
        {
            centrodemasa1 = new Vector3(-1.85f, -1.5f, -3.0f);
            color1 = new Color4(0.8f, 0.0f, 0.2f, 1.0f);

            float[] vertices1 =
            {
                -1.85f, -1.5f, -3.0f,
                -1.85f, -1.8f, -3.0f,
                -1.95f, -1.8f, -3.0f,
                 -1.95f, -1.5f, -3.0f,

                 -1.84f, -1.49f, -3.10f,
                -1.84f, -1.79f, -3.10f,
                -1.94f, -1.79f, -3.10f,
                 -1.94f, -1.49f, -3.10f,


            };

            uint[] indices1 =
            {
                 0,1,2,
                0,2,3,

                0,1,5,
                0,5,4,

                4,5,6,
                4,6,7,

                2,3,6,
                3,6,7,
                


            };
            cargarBuffers(vertices1, indices1, color1, centrodemasa1);
        }
    }

    class Pata_Izquierda_Delantera : Objeto
    {
        Color4 color1;
        Vector3 centrodemasa1;
        public Pata_Izquierda_Delantera()
        {
            centrodemasa1 = new Vector3(-1.20f, -1.5f, -3.0f);
            color1 = new Color4(0.8f, 0.0f, 0.2f, 1.0f);

            float[] vertices1 =
            {
                -1.20f, -1.5f, -3.0f,
                -1.20f, -1.8f, -3.0f,
                -1.30f, -1.8f, -3.0f,
                -1.30f, -1.5f, -3.0f,

                -1.19f, -1.49f, -3.15f,
                -1.19f, -1.79f, -3.15f,
                -1.29f, -1.79f, -3.15f,
                -1.29f, -1.49f, -3.15f,


                };

            uint[] indices1 =
            {
                0,1,2,
                0,2,3,

                0,1,5,
                0,5,4,

                4,5,6,
                4,6,7,

                2,3,6,
                3,6,7,
                
            };
            cargarBuffers(vertices1, indices1, color1, centrodemasa1);
        }
    }
    class Pata_Derecha_Delantera: Objeto
    {
        Color4 color1;
        Vector3 centrodemasa1;
        public Pata_Derecha_Delantera()
        {
            centrodemasa1 = new Vector3(-1.0f, -1.5f, -3.0f);
            color1 = new Color4(0.8f, 0.0f, 0.2f, 1.0f);

            float[] vertices1 =
            {
                 -1.0f, -1.5f, -3.0f,
                 -1.0f, -1.8f, -3.0f,
                 -1.10f, -1.8f, -3.0f,
                 -1.10f, -1.5f, -3.0f,

                  -0.99f, -1.49f, -3.15f,
                 -0.99f, -1.79f, -3.15f,
                 -1.09f, -1.79f, -3.15f,
                 -1.09f, -1.49f, -3.15f,
            };

            uint[] indices1 =
            {
                0,1,2,
                0,2,3,

                0,1,5,
                0,5,4,

                4,5,6,
                4,6,7,

                2,3,6,
                3,6,7,

            };
            cargarBuffers(vertices1, indices1, color1, centrodemasa1);
        }
    }
    class Pata_Derecha_Trasera : Objeto
    {
        Color4 color1;
        Vector3 centrodemasa1;
        public Pata_Derecha_Trasera()
        {
            centrodemasa1 = new Vector3(-1.65f, -1.5f, -3.0f);
            color1 = new Color4(0.8f, 0.0f, 0.2f, 1.0f);

            float[] vertices1 =
            {
                -1.65f, -1.5f, -3.0f,
                -1.65f, -1.8f, -3.0f,
                 -1.75f, -1.8f, -3.0f,
                -1.75f, -1.5f, -3.0f,

                -1.64f, -1.49f, -3.10f,
                -1.64f, -1.79f, -3.10f,
                 -1.74f, -1.79f, -3.10f,
                -1.74f, -1.49f, -3.10f,
            };

            uint[] indices1 =
            {
                 0,1,2,
                0,2,3,

                0,1,5,
                0,5,4,

                4,5,6,
                4,6,7,

                2,3,6,
                3,6,7,
                3,6,7

            };
            cargarBuffers(vertices1, indices1, color1, centrodemasa1);
        }
    }
   

   

    class Cola : Objeto
    {
        Color4 color1;
        Vector3 centrodemasa1;
        public Cola()
        {
            centrodemasa1 = new Vector3(-2.0f, -1.4f, -3.0f);
            color1 = new Color4(0.8f, 0.0f, 0.2f, 1.0f);

            float[] vertices1 =
            {
                 -2.0f, -1.10f, -3.0f,
                 -2.0f, -1.35f, -3.0f,
                -2.25f, -1.25f, -3.0f,
                };

            uint[] indices1 =
            {
                0,1,2,
            };
            cargarBuffers(vertices1, indices1, color1, centrodemasa1);
        }

    }
}
