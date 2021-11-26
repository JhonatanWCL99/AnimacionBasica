using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraJuego
{
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            using (var game = new Game(700, 600, "LearnOpenTK - Creating a Window"))
            {
                game.Run(60.0);
            }
        }
    }
}
