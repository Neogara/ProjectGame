using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;



class Grass : Ground
{


    Random random = new Random();

    public Grass(Vector2 position, Texture2D texture, int frameH, int frameW) : base(GroundType.Grass, position, texture, frameH, frameW)
    {

    }
    public override void Draw(SpriteBatch spriteBatch, float rotation, float scale)
    {
        //  int offSet = random.Next(1, 3);

        rect = new Rectangle(0, 0, frameW, frameH);
        base.Draw(spriteBatch, 0f, 1f);
    }

}



