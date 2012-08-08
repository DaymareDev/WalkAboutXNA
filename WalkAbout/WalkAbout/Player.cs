using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace WalkAbout
{
    /// <summary>
    /// The Player is a character that can be controlled by the keyboard.
    /// </summary>
    public class Player : Character
    {

        private KeyboardState _currentKeyboardState;
        private int _spriteWidth = 24;
        private int _spriteHeight = 32;
        private float _animationStepTime;
        private float _animationTimer;
        private int _currentDirection; // 0: up, 1: right, 2:down, 3: left
        private int _animationCounter;

        /// <summary>
        /// Create a player character at the position supplied.
        /// </summary>
        /// <param name="position">The position of the upper left corner of the player collision box.</param>
        public Player(Point position) 
            : base(position) //Same as super() in java
        {
            _activeSprite = new Rectangle(0,_spriteHeight,_spriteWidth, _spriteHeight);
            _characterBox.Width = _spriteWidth * 2;
            _characterBox.Height = _spriteHeight * 2;
            _animationStepTime = 1f/3; //Time to perform a whole animation cycle divided by 3. 
            _currentDirection = 2;
            _animationCounter = 0;
        }

        public override void Update(float deltaTime)
        {
            //puts all the information needed about the keyoard into the current keyboard state.
            _currentKeyboardState = Keyboard.GetState();

            //TODO: Lets move around a bit!
            if (_currentKeyboardState.IsKeyDown(Keys.D))
            {
                //If D is being held down, move the character to the left.
                _characterBox.X += 4;
                _currentDirection = 1; 
                _animationTimer += deltaTime;
            }
            else if (_currentKeyboardState.IsKeyDown(Keys.A))
            {
                //If A is being held down, move the character to the left.
                _characterBox.X -= 4;
                _currentDirection = 3;
                _animationTimer += deltaTime;
            }
            
            if (_animationTimer >= _animationStepTime)
            {
                _animationCounter++;
                if (_animationCounter == 2)
                    _animationCounter = 0;
                _animationTimer -= _animationStepTime;
            }
            _activeSprite.X = _animationCounter * _spriteWidth;
            _activeSprite.Y = _currentDirection * _spriteHeight;
        }
        
    }
}
