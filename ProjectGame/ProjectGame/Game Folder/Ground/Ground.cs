using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Ground : GameObject
{
    public GroundType GroundType;

    public Ground(GroundType groundType ,Vector2 position, Texture2D texture, Rectangle rect, int frameH, int frameW) :base(position,texture,frameH,frameW)
    {
        this.GroundType = groundType;
    }

    public override void Update(GameTime gameTime)
    {

    }
} // пол