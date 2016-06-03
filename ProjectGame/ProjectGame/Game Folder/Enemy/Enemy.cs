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

    public int Heath = 100;
    public int Mana = 100;
    public int Speed = 5;

    public int Attack= 5;
    public int Deffense = 5;
    public int MissChanse = 1;

    public Enemy(EnemyType EnemyType, Vector2 position, Texture2D texture, Rectangle rect) : base(position, texture, rect)
    {
        this.EnemyType = EnemyType;
      

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
} //Враг