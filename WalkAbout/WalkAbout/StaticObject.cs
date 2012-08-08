using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WalkAbout
{
    public class StaticObject
    {
        private Texture2D _spriteSheet;
        /// <summary>
        /// Where to get art from on spritesheet.
        /// </summary>
        private Rectangle _sourceRect;
        /// <summary>
        /// Where to draw on screen
        /// </summary>
        private Rectangle _destinationRect;

        public StaticObject(Texture2D sprite, Rectangle sourceRect, Rectangle destRect)
        {

        }
    }
}
