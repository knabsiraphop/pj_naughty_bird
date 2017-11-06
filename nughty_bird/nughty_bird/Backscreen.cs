using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace nughty_bird
{
    class Backscreen
    {
        
        private Texture2D _texture;
        public Vector2 _position;
        private int widescreen = 1366;
        private int heightscreen = 768;


        public  Backscreen(Texture2D texture)
        {
            _texture = texture;
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, destinationRectangle: new Rectangle(0, 0, widescreen, heightscreen));
        }


        
    }
}
