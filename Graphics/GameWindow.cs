using System;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Graphics
{
    public class GameWindow : OpenTK.GameWindow
    {
        Texture sadFaceTexture;

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
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);

            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Lequal);

            GL.Enable(EnableCap.Texture2D);

            this.sadFaceTexture = Content.LoadTexture("D:/Dev/sadface.png");
            this.sadFaceTexture = Content.LoadTexture("D:/Dev/sadface.png");
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, this.Width, this.Height);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.ClearColor(System.Drawing.Color.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            // Draw the RGB triangle
            GL.Begin(PrimitiveType.Triangles);

            GL.Color3(1.0, 0.0, 0.0);
            GL.Vertex2(-0.25, -0.25);

            GL.Color3(0.0, 1.0, 0.0);
            GL.Vertex2(0.25, -0.25);

            GL.Color3(0.0, 0.0, 1.0);
            GL.Vertex2(-0.25, 0.25);

            GL.End();

            // Draw the texture
            GL.BindTexture(TextureTarget.Texture2D, this.sadFaceTexture.Id);

            GL.Begin(PrimitiveType.Triangles);

            GL.Color4(1.0, 1.0, 1.0, 1.0);

            GL.TexCoord2(0, 0);
            GL.Vertex2(0.0, 0.5);

            GL.TexCoord2(0, 1);
            GL.Vertex2(0.0, 0.0);

            GL.TexCoord2(1, 1);
            GL.Vertex2(0.5, 0.0);

            GL.TexCoord2(1, 1);
            GL.Vertex2(0.5, 0.0);

            GL.TexCoord2(1, 0);
            GL.Vertex2(0.5, 0.5);

            GL.TexCoord2(0, 0);
            GL.Vertex2(0.0, 0.5);

            GL.End();

            this.SwapBuffers();
        }
    }
}
