using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace WalkAbout
{
    public class Character
    {
        /// <summary>
        /// The character box represents the area the sprite is drawn to, 
        /// as well as the collision area. 
        /// </summary>
        protected Rectangle _characterBox;
        /// <summary>
        /// This is the sprite in the spritesheet we are currently drawing.
        /// </summary>
        protected Rectangle _activeSprite;
        protected Texture2D _textureSheet;

        public Character(Point position)
        {
            //We set the width and height in the child classes.
            _characterBox = new Rectangle(position.X, position.Y, 0, 0);
        }

        /// <summary>
        /// A virtual function can be overriden using the override keyword.
        /// </summary>
        /// <param name="texture">The texture you want to use for this object instance.</param>
        public virtual void SetTextureSheet(Texture2D texture)
        {
            _textureSheet = texture;
        }

        public virtual void Update(float deltaTime)
        {
            
        }
        /// <summary>
        /// The draw method for all our characters.
        /// Because the base class contains the drawer.draw call, all children inheriting this class
        /// will automatically be able to draw themselves, once the texture is set :)
        /// </summary>
        /// <param name="drawer">The spritebatch we are going to use.</param>
        public virtual void Draw(SpriteBatch drawer)
        {
            //This simple check allows us to know why the game suddenly crashed.
            if (_textureSheet == null)
            {
                Console.WriteLine("Attempted to draw a character without a spritesheet set!");
                System.Threading.Thread.Sleep(100);
            }
            drawer.Draw(_textureSheet, _characterBox, _activeSprite, Color.White);
        }
    }
}
