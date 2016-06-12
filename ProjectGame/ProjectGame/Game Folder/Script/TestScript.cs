using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


class TestScript : Script
{
    SpriteBatch spriteBatch;
    SpriteFont font;
    string text;
    Vector2 position;

    public TestScript(SpriteBatch spriteBatch, SpriteFont font, string Text, Vector2 position)
    {
        this.spriteBatch = spriteBatch;
        this.font = font;
        this.text = Text;
        this.position = position;

    }

    public override void Action()
    {
        
        spriteBatch.DrawString(font, text, position, Color.White);

    }


}

