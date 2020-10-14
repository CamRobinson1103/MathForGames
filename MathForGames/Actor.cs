using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;


namespace MathForGames
{
    class Actor
    {
        protected char _icon = ' ';
        protected Vector2 _position;
        protected Vector2 _velocity;
        protected ConsoleColor _Color;

        public Vector2 Position
        { 
            get
            {
                return _position;
            }
            set
            {
                _position= value;
            }
        
        }


        public Vector2 Velocity
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }

        }


        public Actor()
        {
            _position = new Vector2();
            _velocity = new Vector2();
        }
            
        public Actor(float x, float y, char icon = ' ', ConsoleColor color = ConsoleColor.Blue)
        {
            _icon = icon;
            _position = new Vector2(x, y);
            _velocity = new Vector2();
            _Color = color;
        }




        public virtual void Start()
        {

        }
        
        public virtual void Update()
        { 
            _position.X += _velocity.X;
            _position.Y += _velocity.Y;
            _velocity.X = Math.Clamp(_velocity.X , 0, Console.WindowWidth-1);
            _velocity.Y = Math.Clamp(_velocity.Y , 0, Console.WindowHeight-1);
        }

        public virtual void Draw()
        {
            Console.SetCursorPosition((int)_position.X, (int)_position.Y);
            Console.Write(_icon);
            Console.ForegroundColor = _Color;
            Console.ForegroundColor = Game.DefaultColor;
        }

        public virtual void End()
        {

        }
    }
}
