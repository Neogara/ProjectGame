using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


public class Used : GameObject
{
    public UsedType UsedType;
    public string Name;
    public string Discroption;

    public Used(UsedType UsedType, Vector2 position, Texture2D texture, Rectangle rect) : base(position, texture, rect)
    {
        this.UsedType = UsedType;
        base.texture = texture;
        base.rect = rect;

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

    public virtual void Action()
    { } //действие при активации 
} // юзабельный предмет
