using GameDev.Commands;
using GameDev.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using Levels.Level;

namespace GameDev
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;


        private Texture2D texture;
        Hero hero;
        Level level;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            level = new Level(Content);
            level.CreateWorld();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            texture = Content.Load<Texture2D>("Run");                                                                       //Set image to texture var

            InitializeGameObjects();
        }

        private void InitializeGameObjects()
        {
            hero = new Hero(texture, new KeyboardReader(), new MoveCommand()) ;                                                                 // DIP => Hier geef je de eigenlijke input mee

            _graphics.PreferredBackBufferWidth = 1100; //width
            _graphics.PreferredBackBufferHeight = 900; //height
            _graphics.ApplyChanges();
            Window.AllowUserResizing = true;
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            hero.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();                                                                                               //Draw between begin and end

            level.DrawWorld(_spriteBatch);
            hero.Draw(_spriteBatch);

            _spriteBatch.End();

           

            base.Draw(gameTime);
        }
    }
}
