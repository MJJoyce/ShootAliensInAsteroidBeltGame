using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace ShootAliensInAsteroidBeltGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        enum GameStates {Title, Playing, Dead, GameOver};
        GameStates gameState = GameStates.Title;
        Texture2D titleScreen;
        Texture2D spriteSheet;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        ///
        /// enum GameStates {Title, Playing, Dead, GameOver};
        /// GameStates gameState = GameStates.Title;
        /// Texture2D titleScreen;
        /// Texture2D spriteSheet;
        ///
        /// enum GameStates {Title, Playing, Dead, GameOver};
        /// GameStates gameState = GameStates.Title;
        /// Texture2D titleScreen;
        /// Texture2D spriteSheet;
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            titleScreen = Content.Load<Texture2D>(@"Textures\TitleScreen");
            spriteSheet = Content.Load<Texture2D>(@"Textures\SpriteSheet");

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            switch (gameState)
            {
                case GameStates.Title:
                    break;

                case GameStates.Playing:
                    break;

                case GameStates.Dead:
                    break;

                case GameStates.GameOver:
                    break;
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            if (gameState == GameStates.Title)
            {
                spriteBatch.Draw(
                        titleScreen,
                        new Rectangle(
                            0,
                            0,
                            this.Window.ClientBounds.Width,
                            this.Window.ClientBounds.Height),
                        Color.White);
            }

            if ((gameState == GameStates.Playing) ||
                (gameState == GameStates.Dead) ||
                (gameState == GameStates.GameOver))
            {
            }

            if (gameState == GameStates.GameOver)
            {
            }

            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
