using System;

namespace mathLibrary
{
    public class Vector2
    {
        private float _X;
        private float _y;

        public Vector2
        public float X
        {
            get
            {
                return _X;
            }
            set
            {
                _X = value;
            }
                
        }
        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
          

        }
        public Vector2()
        {
            _X = 0;
            _y = 0;
        }
        public Vector2(float x, float y)
        {
            _X = x;
            _y = Y;
        }
    }
}
