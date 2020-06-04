using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;
using GameOfLifeLibrary;
using System.Threading;

namespace GameOfLifeOpenGLVersion
{
    public partial class MainForm : Form
    {
        private Camera camera = new Camera(0, 0, -2, 0.5f, 0.5f);
        private Game game = new Game();
        private Color pointColor = new Color(1, 1, 1);

        private int gameplayFps = 0;

        public MainForm()
        {
            InitializeComponent();
            MouseWheel += new MouseEventHandler(this_MouseWheel);
        }

        private void Draw()
        {
            var gl = glControl.OpenGL;

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();

            gl.Translate(camera.X, camera.Y, camera.Zoom);

            if (game.IsStarted)
            {
                for (int i = 0; i < game.Cols; i++)
                {
                    for (int j = 0; j < game.Rows; j++)
                    {
                        if (game.Field[i, j])
                            DrawPoint(new Point(i, j), pointColor);
                    }
                }
            }

            gl.Flush();
        }

        private void DrawPoint(Point point, Color color)
        {
            var gl = glControl.OpenGL;

            var size = 0.01f;

            gl.Begin(OpenGL.GL_QUADS);

            gl.Color(color.Red, color.Green, color.Blue);
            gl.Vertex((0.0f + point.X) * size, (0.0f + point.Y) * size);

            gl.Color(color.Red, color.Green, color.Blue);
            gl.Vertex((1.0f + point.X) * size, (0.0f + point.Y) * size);

            gl.Color(color.Red, color.Green, color.Blue);
            gl.Vertex((1.0f + point.X) * size, (1.0f + point.Y) * size);

            gl.Color(color.Red, color.Green, color.Blue);
            gl.Vertex((0.0f + point.X) * size, (1.0f + point.Y) * size);

            gl.End();
        }

        private async void StartGame()
        {
            toggleEnabledControls(false);

            fpsTime.Start();

            await game.StartAsync((int)nudWidth.Value, 
                (int)nudHeight.Value, (int)nudDensity.Value, cbIsMultithread.Checked);
        }

        private void StopGame()
        {
            toggleEnabledControls(true);

            game.Stop();
        }

        private void toggleEnabledControls(bool isEnabled)
        {
            nudDensity.Enabled = isEnabled;
            nudHeight.Enabled = isEnabled;
            nudWidth.Enabled = isEnabled;
            cbIsMultithread.Enabled = isEnabled;
            btnStart.Enabled = isEnabled;
            btnStop.Enabled = !isEnabled;
        }

        private void MoveCamera(Keys keyCode)
        {
            switch (keyCode)
            {
                case Keys.W:
                    camera.MoveTop();
                    break;
                case Keys.A:
                    camera.MoveLeft();
                    break;
                case Keys.S:
                    camera.MoveBottom();
                    break;
                case Keys.D:
                    camera.MoveRight();
                    break;
            }
        }

        private void ZoomCamera(int delta)
        {
            if (delta > 0)
                camera.ZoomIn();
            else
                camera.ZoomOut();
        }

        private void UpdateColor(Color color)
        {
            pointColor = color;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void glControl_OpenGLDraw(object sender, RenderEventArgs args)
        {
            Draw();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            MoveCamera(e.KeyCode);
        }

        private void this_MouseWheel(object sender, MouseEventArgs e)
        {
            ZoomCamera(e.Delta);
        }

        private void fpsTime_Tick(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if (game.IsStarted)
                {
                    var temp = game.Generations;
                    Thread.Sleep(1000);
                    var currentGenerations = game.Generations;

                    gameplayFps = currentGenerations - temp;

                    Invoke(new Action(() => 
                        Text = $"Game Of Life | OpenGL Version | Gameplay FPS = {gameplayFps}"));
                }
            });
        }

        private void tbColorRed_Scroll(object sender, EventArgs e)
        {
            UpdateColor(new Color(tbColorRed.Value / 255f, 
                tbColorGreen.Value / 255f, tbColorBlue.Value / 255f));
        }

        private void tbColorGreen_Scroll(object sender, EventArgs e)
        {
            UpdateColor(new Color(tbColorRed.Value / 255f,
                tbColorGreen.Value / 255f, tbColorBlue.Value / 255f));
        }

        private void tbColorBlue_Scroll(object sender, EventArgs e)
        {
            UpdateColor(new Color(tbColorRed.Value / 255f,
                tbColorGreen.Value / 255f, tbColorBlue.Value / 255f));
        }
    }
}
