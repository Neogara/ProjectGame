using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


class Trigger
{
 
    TriggerType triggertype;
    Vector2 position;
    int triggerW;
    int trigeersH;
    Rectangle rect;
    Script ActionScrint;

    bool NeedAction;

    public Trigger(Vector2 position , int triggerW,int triggerH , Script script, TriggerType triggerType)
    {
        this.triggertype = triggerType;
        this.position = position;
        this.trigeersH = triggerH;
        this.triggerW = triggerW;
        rect = new Rectangle((int)position.X, (int)position.Y, triggerW, triggerH);
        this.ActionScrint = script;
        NeedAction = true;
    }

   public virtual void Action (Rectangle targetRect)
    {
        if (rect.Intersects(targetRect) & NeedAction)
        {
            if (triggertype == TriggerType.OnEnter)
            {
                ActionScrint.Action();
                NeedAction = false;
            }
            else if (triggertype == TriggerType.OnState)
            {
                ActionScrint.Action();
            }

        }
    }
}

