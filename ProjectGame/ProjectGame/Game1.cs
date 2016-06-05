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

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {
            base.Initialize();
            MainCamera = new Camera(GraphicsDevice.Viewport);
        }


        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);


            MainHero = new Hero(HeroType.Mage, new Vector2(50, 50), Content.Load<Texture2D>("fameleSprite"), 31, 11);

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

           // spriteBatch.Begin(SpriteSortMode.Texture,null, null, null, null, null,MainCamera.matrixScreen);
            spriteBatch.Begin(SpriteSortMode.Deferred,null,SamplerState.PointWrap,DepthStencilState.Default,RasterizerState.CullNone,null,MainCamera.matrixScreen);
            MainHero.Draw(spriteBatch, 0f, 5f);
            Merch.Draw(spriteBatch, 0f, 5f);
            MainHero.Draw(spriteBatch, 0f, 5f);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
