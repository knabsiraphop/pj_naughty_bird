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
    class button
    {
        Texture2D _texture;
        public int  _positionX = 0;
        public int _positionY = 0;
        public int wide_button = 200;
        public int height_button = 200;
        public int state;

        public int returnstate()
        {
            return state;
        }

        public button(Texture2D texture)
        {
            _texture = texture;
        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(_texture,destinationRectangle:new Rectangle(_positionX,_positionY,wide_button,height_button));
        }

        public void Update()
        {
            
        }

    }
}
