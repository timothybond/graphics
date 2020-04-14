using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using Tetris.Logic;

namespace Tetris.Game
{
    public class GameWindow : OpenTK.GameWindow
    {
        private readonly Board board = new Board(10, 20);

        public GameWindow() :
            base(
                1280,
                720,
                new GraphicsMode(32, 8, 0, 8),
                "Game Window",
                GameWindowFlags.Default,
                DisplayDevice.Default,
                4,
                3,
                GraphicsContextFlags.ForwardCompatible)
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);

            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Lequal);

            GL.Enable(EnableCap.Texture2D);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, this.Width, this.Height);
        }

        protected override void OnKeyDown(KeyboardKeyEventArgs e)
        {
            Console.WriteLine("KeyDown: {0} {1}", e.Key, e.IsRepeat ? "(repeat)" : string.Empty);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {

        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.ClearColor(System.Drawing.Color.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Matrix4 projectionMatrix = Matrix4.CreateOrthographicOffCenter(0, this.Width, 0, this.Height, 0, 1);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projectionMatrix);

            GL.BindTexture(TextureTarget.Texture2D, 0);

            // Draw the RGB triangle
            GL.Begin(PrimitiveType.Triangles);

            GL.Color3(1.0, 0.0, 0.0);
            GL.Vertex2(200, 200);

            GL.Color3(0.0, 1.0, 0.0);
            GL.Vertex2(500, 200);

            GL.Color3(0.0, 0.0, 1.0);
            GL.Vertex2(200, 500);

            GL.End();
            
            GL.Begin(PrimitiveType.Triangles);

            GL.Color4(1.0, 1.0, 1.0, 1.0);

            GL.TexCoord2(0, 0);
            GL.Vertex2(500.0, 700.0);

            GL.TexCoord2(0, 1);
            GL.Vertex2(500.0, 500.0);

            GL.TexCoord2(1, 1);
            GL.Vertex2(700.0, 500.0);

            GL.TexCoord2(1, 1);
            GL.Vertex2(700.0, 500.0);

            GL.TexCoord2(1, 0);
            GL.Vertex2(700.0, 700.0);

            GL.TexCoord2(0, 0);
            GL.Vertex2(500.0, 700.0);

            GL.End();

            this.SwapBuffers();
        }
    }
}
