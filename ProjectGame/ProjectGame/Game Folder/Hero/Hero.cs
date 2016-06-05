using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public class Hero : GameObject
{
    public HeroType HeroType;

    public string Name;
    public string Discroption;

    public int Heath = 100;
    public int Mana = 100;
    public int Speed = 5;
    public int Karma = 0 ;

    //характеристики
    public int Strench = 5;
    public int Agility = 5;
    public int Intelect = 5;
    public int Charisma = 5;
    public int Luck = 5;
    public int Barter = 5;

    public int Attack= 5;
    public int Deffense = 5;
    public int MissChanse = 1;
    

    public Hero(HeroType HeroType, Vector2 position, Texture2D texture, int frameH, int frameW) : base(position, texture, frameH, frameW)
    {
        this.HeroType = HeroType;
    }

    public Hero() : this(HeroType.Knight, new Vector2(0, 0), null, 0, 0) { }
  
    public override void Update(GameTime gameTime)
    {
        #region Move 
        if (Keyboard.GetState().IsKeyDown(Keys.W))
        {
            position.Y += -Speed;
            GoUpSideAnimation(gameTime);
        }
        else if (Keyboard.GetState().IsKeyDown(Keys.S))
        {
            position.Y += Speed;
            GoDownSideAnimation(gameTime);
        }

        if (Keyboard.GetState().IsKeyDown(Keys.A))
        {
            position.X += -Speed;
            GoLeftSideAnimation(gameTime);
        }
       else if (Keyboard.GetState().IsKeyDown(Keys.D))
        {
            position.X += Speed;
            GoRightSideAnimation(gameTime);
        }
       else
        {
            IdleAnimation(gameTime);
        }
        #endregion //Хождение героя 
    }

    public void IdleAnimation(GameTime gameTime)
    {
        // animation.DrawAnimation(gameTime, 1, 1, 1);
    }

    public void GoRightSideAnimation (GameTime gameTime)
    {
        this.rect = animation.DrawAnimation(gameTime, 0,0,33);
    }

    public void GoLeftSideAnimation(GameTime gameTime)
    {
         this.rect = animation.DrawAnimation(gameTime, 1, 0,33 );
    }

    public void GoUpSideAnimation(GameTime gameTime)
    {
        // this.rect = animation.DrawAnimation(gameTime, 1, 1, 1);
    }

    public void GoDownSideAnimation(GameTime gameTime)
    {
        //this.rect =  animation.DrawAnimation(gameTime, 1, 1, 1);
    }

    public void SetInfo(string Name, string Discroption)
    {
        switch (HeroType)
        {
            case HeroType.Knight:
                {

                    break;
                }
            case HeroType.Mage:
                {
                    break;
                }
            case HeroType.Rogue:
                {
                    break;
                }
        }
    }

}
 //герой за которого мы играем 