using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Ground : GameObject
{
    public GroundType GroundType;

    public Ground(GroundType groundType, Texture2D texture, Rectangle rect)
    {
        this.GroundType = groundType;
        base.texture = texture;
        base.rect = rect;

    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(base.texture, base.rect, Color.White);
    }
    public override void Update(SpriteBatch spriteBatch)
    {
        Draw(spriteBatch);
    }
} // пол