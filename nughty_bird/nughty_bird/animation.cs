using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace nughty_bird
{
    class animation
    {
        Texture2D _texture;
        Vector2 _position;
        public int wide = 300;
        public int height = 150;
        public int speed = 1;
        
        public animation(Texture2D texture,Vector2 vector)
        {
            _texture = texture;
            _position = vector;
        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(_texture,destinationRectangle: new Rectangle((int)_position.X,(int)_position.Y,wide,height));
        }

        public void Update()
        {
            _position.X += speed;

            if(_position.X >= 1366)
            {
                _position.X = 0;
            }
        }
    }
}
