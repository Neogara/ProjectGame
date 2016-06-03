using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Ground : GameObject
{
    public GroundType GroundType;

    public Ground(GroundType groundType,Vector2 position, Texture2D Texture ,Rectangle Rect) :base(position,Texture,Rect)
    {
        
        this.GroundType = groundType;
    

    }

    public override void Draw()
    {
        Sprite.Begin();
        Sprite.Draw(base.texture, base.rect, Color.White);
        Sprite.End();
    }
    public override void Update()
    {
        Draw();
    }
} // пол