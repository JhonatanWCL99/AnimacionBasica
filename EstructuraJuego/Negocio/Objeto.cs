using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using EstructuraJuego.Shaders;
using System.Xml.Serialization;
using System.Data.Common;

namespace EstructuraJuego
{
    class Objeto : IObjeto
    {


        public Shader _shader;

        public int VertexBufferObject;//VBO
        public int VertexArrayObject;//VAO
        public int ElementBufferObject;//EBO

        public Vector3 centrodemasa;
        public float[] vertices;
        public uint[] indices;



        public Color4 color;

        public Matrix4 view = Matrix4.LookAt(new Vector3(0.0f, 0.0f, 0.3f),
            new Vector3(0.0f, 0.0f, 0.0f),
            new Vector3(0.0f, 1.0f, 0.0f));

        public Matrix4 model = Matrix4.Identity;

        public Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(90), 800 / 600, 0.1f, 100f);

        public Matrix4 rotar;
        public Matrix4 trasladar;
        public Matrix4 escalar;

        public Objeto()
        {

        }

        public void cargarBuffers(float[] vertices, uint[] indices, Color4 color, Vector3 centrodemasa)
        {
            this.vertices = vertices;
            this.indices = indices;
            this.color = color;
            this.centrodemasa = centrodemasa;

            VertexArrayObject = GL.GenVertexArray();
            VertexBufferObject = GL.GenBuffer();
            ElementBufferObject = GL.GenBuffer();

            GL.BindVertexArray(VertexArrayObject);

            GL.BindBuffer(BufferTarget.ArrayBuffer, VertexBufferObject);
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StaticDraw);


            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ElementBufferObject);
            GL.BufferData(BufferTarget.ElementArrayBuffer, indices.Length * sizeof(uint), indices, BufferUsageHint.StaticDraw);

            GL.EnableVertexAttribArray(0);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);

            setColor();

           

        }
        public void setOrigen(float x, float y, float z)
        {
            this.centrodemasa.X = x;
            this.centrodemasa.Y = y;
            this.centrodemasa.Z = z;
        }
        public void setMatrices(Matrix4 model, Matrix4 view, Matrix4 projection)
        {
            this.model = model;
            this.view = view;
            this.projection = projection;
        }
        public void dibujar()
        {
            setmatrix();
            _shader.Use();
            GL.BindVertexArray(VertexArrayObject);
            GL.DrawElements(PrimitiveType.Triangles, indices.Length, DrawElementsType.UnsignedInt, 0);
        }
     

        public void delete()
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.DeleteBuffer(VertexBufferObject);
            _shader.Dispose();
        }

        public void RotarX(float angulo)
        {
            rotar = model * Matrix4.CreateTranslation(-centrodemasa) * Matrix4.CreateRotationX(MathHelper.DegreesToRadians(angulo));
            rotar = rotar * Matrix4.CreateTranslation(centrodemasa);
            model = rotar;
        }
        public void RotarY(float angulo)
        {
            rotar = model * Matrix4.CreateTranslation(-centrodemasa) * Matrix4.CreateRotationY(MathHelper.DegreesToRadians(angulo));
            rotar = rotar * Matrix4.CreateTranslation(centrodemasa);
            model = rotar;
        }
        public void RotarZ(float angulo)
        {
            rotar = model * Matrix4.CreateTranslation(-centrodemasa) * Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(angulo));
            rotar = rotar * Matrix4.CreateTranslation(centrodemasa);
            model = rotar;
        }
        public void Trasladar(Vector3 traslacion)
        {
            trasladar = model * Matrix4.CreateTranslation(traslacion);
            model = trasladar;
        }

        public void Escalar(float fov)
        {
            escalar = model * Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(fov), 800 / 600, 0.01f, 100f);
            model = escalar;
        }
        private void setShader()
        {
            _shader = new Shader("Shaders/shader.vert", "Shaders/shader.frag");
            _shader.Use();
        }
        private void setmatrix()
        {
            _shader.SetMatrix4("view", view);
            _shader.SetMatrix4("projection", projection);
            _shader.SetMatrix4("model", model);
        }
        private void setColor()//pintamos del color que le demos al grafico
        {
            setShader();
            int locationColorUniform = GL.GetUniformLocation(_shader.Handle, "vColor");
            GL.Uniform4(locationColorUniform, color);
        }
    }
}
