using System;
using System.Collections.Generic;
using System.Text;
using mathLibrary;

namespace MathForGames
{
    class Actor
    {
        protected char _icon = 'a';
        protected int _X = 0;
        protected int _y = 0;
        protected Vector2 _position;
        protected Vector2 _velocity;

        public float X
        {
            get
            {
                return _position.X;
            }
            set
            {
                _position.X = value;
            }
            
        }

        public static object Velocity { get; internal set; }

        public Actor(float x, float y, char icon = ' ', ConsoleColor color = ConsoleColor.White)
        {
            _position = new Vector2();
            _velocity = new Vector2();
            _icon = icon;
            _position = new Vector2;

        }
 
       

      public virtual  void start()
        {
            Console.CursorVisible = false;
            
        }
     
      
        
        public virtual void Update()
        {
            ConsoleKey keyPressed = Game.GetNextKey();
            switch (keyPressed)
            {
                case ConsoleKey.A:
                    _velocity.X = -1;
                    _X--;
                    break;
                case ConsoleKey.D:
                    _velocity.X = 1;
                    _X++;
                    break;
                case ConsoleKey.W:
                    _velocity.Y = -1;
                    _y--;
                    break;
                case ConsoleKey.S:
                    _velocity.Y = 1;
                    _y++;
                    break;
                default:
                    _velocity.X = 0;
                    _velocity.Y = 0;
                    break;
            }
            _position.X += _velocity.X;
            _position.Y += _velocity.Y;

            //if x is less than or equalto zero
           _X = Math.Clamp(_X, 0, Console.WindowWidth - 1);
           _y = Math.Clamp(_y, 0, Console.WindowHeight - 1);
            if (_X < 0)
                _X++;
            if (_X > Console.WindowWidth)
                _X--;
            if (_y < 0)
                _y++;
            if (_y > Console.WindowHeight)
                _y--;

        
         
                
        }

        public virtual void Draw()
        { 
            Console.ForegroundColor = _color;
            Console.ForegroundColor = Game.DefaultColor;
            Console.SetCursorPosition((int)_position.X,(int)_position.Y);
            Console.Write(_icon);
           

        }
        public virtual void End()
        {
         
        }

        
    }
}
