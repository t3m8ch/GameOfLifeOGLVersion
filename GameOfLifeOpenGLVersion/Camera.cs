using System;

namespace GameOfLifeOpenGLVersion
{
    public class Camera
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public float MovementDelta { get; set; }

        public float Zoom { get; private set; }
        public float ZoomDelta { get; set; }

        public Camera(float x = 0, float y = 0, float zoom = -25, 
            float zoomDelta = 0.5f, float movementDelta = 0.5f)
        {
            if (zoom >= -1)
                throw new ArgumentException("Зум не может быть больше или равен -1",
                    nameof(zoom));

            if (zoom <= -98)
                throw new ArgumentException("Зум не может быть меньше или равен -98",
                    nameof(zoom));

            X = x;
            Y = y;
            Zoom = zoom;

            ZoomDelta = zoomDelta;
            MovementDelta = movementDelta;
        }

        public void MoveRight()
        {
            X -= MovementDelta;
        }

        public void MoveLeft()
        {
            X += MovementDelta;
        }

        public void MoveTop()
        {
            Y -= MovementDelta;
        }

        public void MoveBottom()
        {
            Y += MovementDelta;
        }

        public void ZoomIn()
        {
            if (Zoom < -1)
                Zoom += ZoomDelta;
        }

        public void ZoomOut()
        {
            if (Zoom > -98)
                Zoom -= ZoomDelta;
        }
    }
}
