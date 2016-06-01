using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Item : GameObject
{
    public ItemsType ItemType;
    public string Name;
    public string Discroption;

    public Item(ItemsType itemType, Texture2D texture, Rectangle rect)
    {
        this.ItemType = itemType;
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
} //вещи