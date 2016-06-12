using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Npc : GameObject
{

    public NpcType npcType;
    public string Name;


    public Npc(NpcType NpcType, Vector2 position, Texture2D texture, int frameH, int frameW) : base(position, texture, frameH, frameW)
    {
        this.npcType = NpcType;
    }




}

