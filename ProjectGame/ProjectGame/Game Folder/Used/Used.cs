﻿using System;
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

    public Used(UsedType UsedType, Vector2 position, Texture2D texture, Rectangle rect, int frameH, int frameW) : base(position, texture, frameH, frameW)
    {
        this.UsedType = UsedType;
        base.texture = texture;
        base.rect = rect;

    }


    public override void Update(GameTime gameTime)
    {

    }

    public virtual void Action() { } //действие при активации 

} // юзабельный предмет
