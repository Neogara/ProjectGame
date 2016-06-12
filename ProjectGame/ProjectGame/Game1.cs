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

namespace ProjectGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {

        Hero MainHero;
        Camera MainCamera;
        Hero Merch;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Grass[,] grass;
        Trigger testTrigger;
        SpriteFont font;

        // BarkSystem barktest;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {
            base.Initialize();
            MainCamera = new Camera(GraphicsDevice.Viewport);
            GraphicsDevice.SamplerStates[0] = SamplerState.LinearClamp;

        }


        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Texture2D grassTexture = Content.Load<Texture2D>("GrassSprite");
            grass = new Grass[100, 100];
            for (int i = 0; i <= grass.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= grass.GetLength(1) - 1; j++)
                {
                    grass[i, j] = new Grass(new Vector2(i * 32, j * 32), grassTexture, 32, 32);
                }
            }
            font = Content.Load<SpriteFont>("BarkFont");
            
            MainHero = new Hero(HeroType.Mage, new Vector2(50, 50), Content.Load<Texture2D>("fameleSprite"), 31, 11);
            testTrigger = new Trigger(new Vector2(300, 300), 100, 100, new TestScript(spriteBatch, font, "test ", MainHero.position),TriggerType.OnState);
            Merch = new Hero(HeroType.Rogue, new Vector2(200, 50), Content.Load<Texture2D>("Merch"), 32, 32);

            IsMouseVisible = true;


        }


        protected override void UnloadContent()
        {

        }


        protected override void Update(GameTime gameTime)
        {
            MainCamera.Update(gameTime, MainHero);
            MainHero.Update(gameTime);
          

            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, SamplerState.PointClamp, DepthStencilState.Default, null, null, MainCamera.matrixScreen);

            foreach (Grass grass in grass)
            {
                grass.Draw(spriteBatch, 0f, 0f);

            }
            testTrigger.Action(MainHero.collider);
            spriteBatch.DrawString(font, "position main hero " + MainHero.position.X.ToString() + "," + MainHero.position.Y.ToString() + " .", MainHero.position+new Vector2(75,-75), Color.White);
            Merch.Draw(spriteBatch, 0f, 5);
            MainHero.Draw(spriteBatch, 0f, 5);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
