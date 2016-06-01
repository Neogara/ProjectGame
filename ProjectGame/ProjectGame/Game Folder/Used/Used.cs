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

    public Used(UsedType UsedType, Texture2D texture, Rectangle rect)
    {
        this.UsedType = UsedType;
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

    public virtual void Action()
    { } //действие при активации 
} // юзабельный предмет
