using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace nughty_bird
{
    
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public int game_step;
        
        //chapter 1 memu page
        Backscreen menu;
        animation [] cloud;
        animation pressanykey;
        

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        
        protected override void Initialize()
        {
            graphics.PreferredBackBufferHeight = 768;
            graphics.PreferredBackBufferWidth = 1024;
            graphics.IsFullScreen = true;
            graphics.ApplyChanges();
            this.IsMouseVisible = false;

            game_step = 1; //start with menu page;


            base.Initialize();
        }

       
        protected override void LoadContent()
        {
            
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //game_step == 1 menu page
            var texture = Content.Load<Texture2D>("background_menu");
            menu = new Backscreen(texture);
            var texture1 = Content.Load<Texture2D>("cloud") ;
            var texture1_1 = Content.Load<Texture2D>("cloud2");
            cloud = new animation[3];
            cloud[0] = new animation(texture1, new Vector2(0, 0));
            cloud[1] = new animation(texture1_1, new Vector2(1000, 250));
            cloud[2] = new animation(texture1, new Vector2(500, 100));

            var texture2 = Content.Load<Texture2D>("start_menu");

            pressanykey = new animation(texture2, new Vector2((this.GraphicsDevice.Viewport.Width /2)-(750/2), this.GraphicsDevice.Viewport.Height / 2));
            pressanykey.wide = 750;
            pressanykey.height = 100;

            
            
           
        }

        
        protected override void UnloadContent()
        {
            
        }

        
        protected override void Update(GameTime gameTime)
        {
            //if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            //  Exit();
            if (game_step == 1)
            {
                
                cloud[0].Update();
                cloud[1].Update();
                cloud[2].Update();

                if (Keyboard.GetState().IsKeyDown(Keys.Enter))
                {
                    game_step = 2;
                    
                }
            }

            if (game_step == 2)
            {
               
            }
           

            base.Update(gameTime);
        }

        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            if (game_step == 1) {
                menu.Draw(spriteBatch);
                
                pressanykey.Draw(spriteBatch);
                
                cloud[0].Draw(spriteBatch);
                cloud[1].Draw(spriteBatch);
                cloud[2].Draw(spriteBatch);
     
            }

            spriteBatch.End();
            

            base.Draw(gameTime);
        }
    }
}
