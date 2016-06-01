using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public class Hero : GameObject
{
    public HeroType HeroType;
    public string Name;
    public string Discroption;
    public int Speed = 5;

    public Hero(HeroType HeroType, Texture2D texture, Rectangle rect)
    {
        this.HeroType = HeroType;
        base.texture = texture;
        base.rect = rect;

    }

    public override void Update(SpriteBatch spriteBatch)
    {
        #region Move 
        if (Keyboard.GetState().IsKeyDown(Keys.W))
        {
            rect.Y += Speed;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.S))
        {
            rect.Y += -Speed;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.A))
        {
            rect.X += -Speed;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.D))
        {
            rect.X += Speed;
        }
        #endregion //Хождение героя 

        Draw(spriteBatch);
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(base.texture, base.rect, Color.White);
    }
} //герой за которого мы играем 