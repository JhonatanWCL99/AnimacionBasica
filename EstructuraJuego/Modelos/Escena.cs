using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace EstructuraJuego
{
    class Escena : ListadeEscenas
    {
        public Escena()
        {

            Escenas.Add(new Escena0());
            Escenas.Add(new Escena1());
            Escenas.Add(new Escena2());
            Escenas.Add(new Escena3());
            Escenas.Add(new Escena4());
            Escenas.Add(new Escena5());
            Escenas.Add(new Escena6());
            Escenas.Add(new Escena7());
            Escenas.Add(new Escena8());
            Escenas.Add(new Escena9());
            Escenas.Add(new Escena10());
           
        }
    }
    class Escena0 : Escenario
    {
        public Escena0()
        {
            Fondos f = new Fondos();
            Arbol A = new Arbol();
            Perro P = new Perro();
            Lista.Add(f);
            Lista.Add(A);
            Lista.Add(P);
        }

    }
    class Escena1 : Escenario
    {
        public Escena1()
        {
            Vector3 traslacion = new Vector3(0.1f, 0, 0);
            Vector3 traslacion2 = new Vector3(-0.1f, 0, 0);
            Fondos f = new Fondos();
            Arbol A = new Arbol();
            Perro P = new Perro();
            P.Partes[3].RotarX(10);
            P.Partes[3].RotarZ(10);
            P.Partes[4].RotarX(10);
            P.Partes[4].RotarZ(10);
            A.TrasladarPartes(traslacion2);
            P.TrasladarPartes(traslacion);
            Lista.Add(f);
            Lista.Add(A);
            Lista.Add(P);
        }
    }
    class Escena2 : Escenario
    {
        public Escena2()
        {
            Vector3 traslacion = new Vector3(0.2f, 0, 0);
            Vector3 traslacion2 = new Vector3(-0.2f, 0, 0);
            Fondos f = new Fondos();
            Arbol A = new Arbol();
            Perro P = new Perro();
            P.Partes[3].RotarX(20);
            P.Partes[4].RotarX(20);
            P.Partes[3].RotarZ(20);
            P.Partes[4].RotarZ(20);
            A.TrasladarPartes(traslacion2);
            P.TrasladarPartes(traslacion);
            Lista.Add(f);
            Lista.Add(A);
            Lista.Add(P);
        }
    }
    class Escena3 : Escenario
    {
        public Escena3()
        {
            Vector3 traslacion = new Vector3(0.3f, 0, 0);
            Vector3 traslacion2 = new Vector3(-0.3f, 0, 0);
            Fondos f = new Fondos();
            Arbol A = new Arbol();
            Perro P = new Perro();
            P.Partes[3].RotarX(30);
            P.Partes[4].RotarX(30);
            P.Partes[3].RotarZ(30);
            P.Partes[4].RotarZ(30);
            A.TrasladarPartes(traslacion2);
            P.TrasladarPartes(traslacion);
            Lista.Add(f);
            Lista.Add(A);
            Lista.Add(P);
        }
    }
    class Escena4 : Escenario
    {
        public Escena4()
        {
            Vector3 traslacion = new Vector3(0.4f, 0, 0);
            Vector3 traslacion2 = new Vector3(-0.4f, 0, 0);
            Fondos f = new Fondos();
            Arbol A = new Arbol();
            Perro P = new Perro();
            P.Partes[5].RotarX(10);
            P.Partes[6].RotarX(10);
            P.Partes[5].RotarZ(10);
            P.Partes[6].RotarZ(10);
            A.TrasladarPartes(traslacion2);
            P.TrasladarPartes(traslacion);
            Lista.Add(f);
            Lista.Add(A);
            Lista.Add(P);
        }
    }
    class Escena5 : Escenario
    {
        public Escena5()
        {
            Vector3 traslacion = new Vector3(0.5f, 0, 0);
            Vector3 traslacion2 = new Vector3(-0.5f, 0, 0);
            Fondos f = new Fondos();
            Arbol A = new Arbol();
            Perro P = new Perro();
            P.Partes[5].RotarX(20);
            P.Partes[6].RotarX(20);
            P.Partes[5].RotarZ(20);
            P.Partes[6].RotarZ(20);
            A.TrasladarPartes(traslacion2);
            P.TrasladarPartes(traslacion);
            Lista.Add(f);
            Lista.Add(A);
            Lista.Add(P);
        }
    }
    class Escena6 : Escenario
    {
        public Escena6()
        {
            Vector3 traslacion = new Vector3(0.6f, 0, 0);
            Vector3 traslacion2 = new Vector3(-0.6f, 0, 0);
            Fondos f = new Fondos();
            Arbol A = new Arbol();
            Perro P = new Perro();
            P.Partes[5].RotarX(30);
            P.Partes[6].RotarX(30);
            P.Partes[5].RotarZ(30);
            P.Partes[6].RotarZ(30);
            A.TrasladarPartes(traslacion2);
            P.TrasladarPartes(traslacion);
            Lista.Add(f);
            Lista.Add(A);
            Lista.Add(P);
        }
    }
    class Escena7 : Escenario
    {
        public Escena7()
        {
            Vector3 traslacion = new Vector3(0.7f, 0, 0);
            Vector3 traslacion2 = new Vector3(-0.7f, 0, 0);
            Fondos f = new Fondos();
            Arbol A = new Arbol();
            Perro P = new Perro();
            P.Partes[3].RotarX(10);
            P.Partes[4].RotarX(10);
            P.Partes[3].RotarZ(10);
            P.Partes[4].RotarZ(10);
            A.TrasladarPartes(traslacion2);
            P.TrasladarPartes(traslacion);
            Lista.Add(f);
            Lista.Add(A);
            Lista.Add(P);
        }
    }
    class Escena8 : Escenario
    {
        public Escena8()
        {
            Vector3 traslacion = new Vector3(0.8f, 0, 0);
            Vector3 traslacion2 = new Vector3(-0.8f, 0, 0);
            Fondos f = new Fondos();
            Arbol A = new Arbol();
            Perro P = new Perro();
            P.Partes[3].RotarX(20);
            P.Partes[4].RotarX(20);
            P.Partes[3].RotarZ(20);
            P.Partes[4].RotarZ(20);
            A.TrasladarPartes(traslacion2);
            P.TrasladarPartes(traslacion);
            Lista.Add(f);
            Lista.Add(A);
            Lista.Add(P);
        }
    }
    class Escena9 : Escenario
    {
        public Escena9()
        {
            Vector3 traslacion = new Vector3(0.9f, 0, 0);
            Vector3 traslacion2 = new Vector3(-0.9f, 0, 0);
            Fondos f = new Fondos();
            Arbol A = new Arbol();
            Perro P = new Perro();
            P.Partes[3].RotarX(30);
            P.Partes[4].RotarX(30);
            P.Partes[3].RotarZ(30);
            P.Partes[4].RotarZ(30);
            A.TrasladarPartes(traslacion2);
            P.TrasladarPartes(traslacion);
            Lista.Add(f);
            Lista.Add(A);
            Lista.Add(P);
        }
    }

    class Escena10 : Escenario
    {
        public Escena10()
        {
            Vector3 traslacion = new Vector3(1.0f, 0, 0);
            Vector3 traslacion2 = new Vector3(-1.0f, 0, 0);
            Fondos f = new Fondos();
            Arbol A = new Arbol();
            Perro P = new Perro();
            P.Partes[5].RotarX(10);
            P.Partes[6].RotarX(10);
            P.Partes[5].RotarZ(10);
            P.Partes[6].RotarZ(10);
            A.TrasladarPartes(traslacion2);
            P.TrasladarPartes(traslacion);
            Lista.Add(f);
            Lista.Add(A);
            Lista.Add(P);
        }
    }

   
    
}
