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

    public Item(ItemsType itemType, Vector2 position, Texture2D texture, Rectangle rect) : base(position, texture, rect)
    {
        this.ItemType = itemType;
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
} //вещи