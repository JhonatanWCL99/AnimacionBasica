using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstructuraJuego.Negocio;
using OpenTK;

namespace EstructuraJuego
{
    class Escenario:IEscenario
    {
        public List<ListadeObjeto> Lista = new List<ListadeObjeto>();

        public  void dibujarEscenario()
        {
            foreach (ListadeObjeto Obj in Lista)
            {
                Obj.dibujarPartes();
            }
        }

        public  void TrasladarEscenario(Vector3 traslacion)
        {
            foreach (ListadeObjeto Obj in Lista)
            {
                Obj.TrasladarPartes(traslacion);
            }
        }

        public  void EscalarEscenario(float fov)
        {
            foreach (ListadeObjeto Obj in Lista)
            {
               Obj.EscalarPartes(fov);
            }
        }

        public void RotarEscenario(float angulo,String eje)
        {
            foreach (ListadeObjeto Obj in Lista)
            {
                Obj.RotarPartes(angulo,eje);
            }
        }
        public void setMatricesEscenario(Matrix4 model,Matrix4 view,Matrix4 projection)
        {
            foreach (ListadeObjeto Obj in Lista)
            {
                Obj.setMatricesPartes(model, view, projection);
            }

        }
        public void eliminarEscenario()
        {
            foreach (ListadeObjeto Obj in Lista)
            {
                Obj.eliminarPartes();
            }
        }
    }
}
