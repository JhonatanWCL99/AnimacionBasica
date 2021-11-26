using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Resources;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Input;

namespace EstructuraJuego
{
    public sealed class Game : GameWindow
    {
       
        Escena E;
        private int c=0;
        private float time=10;
        private float timeespera;
        float ti = 10;

        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title)
        {
            
            E = new Escena();
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            KeyboardState input = Keyboard.GetState();

            if (input.IsKeyDown(Key.Escape))
            {
                Exit();
            }           
            base.OnUpdateFrame(e);
        }
        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
            
            base.OnLoad(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            
            if (ti > time)
            {
                if (c == E.getCant()-1)
                {
                    c = 0;
                }
                else
                {
                    c++;
                }              
                time = time + 1000;                
            }
            E.DibujarEsc(E.Escenas[c]);
            ti = ti + 50;
            SwapBuffers();
            base.OnRenderFrame(e);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            base.OnResize(e);
        }
        protected override void OnUnload(EventArgs e)
        {

            E.eliminarEscenas();         
            base.OnUnload(e);
        }
    }
}
