using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Enemy : GameObject
{
    public EnemyType EnemyType;
    public string Name;
    public string Discroption;

    public Enemy(EnemyType EnemyType, Texture2D texture, Rectangle rect)
    {
        this.EnemyType = EnemyType;
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
} //Враг