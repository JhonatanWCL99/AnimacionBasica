using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace EstructuraJuego
{
    class ListadeEscenas
    {
        public List<Escenario> Escenas = new List<Escenario>();

        public void DibujarEscenas()
        {
            foreach (Escenario Esc in Escenas)
            {
                Esc.dibujarEscenario();
            }
        }
        public void DibujarEsc(Escenario E)
        {
            
            E.dibujarEscenario();
        }
        public void setMatricesEscenas(Matrix4 model, Matrix4 view, Matrix4 projection)
        {
            foreach (Escenario Esc in Escenas)
            {
                Esc.setMatricesEscenario(model, view, projection);
            }
        }
        public void eliminarEscenas()
        {
            foreach (Escenario Esc in Escenas)
            {
                Esc.eliminarEscenario();
            }
        }
        public int getCant()
        {
            return Escenas.Count();
        }
    }
}
