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
    


    public Hero(HeroType HeroType,Vector2 position, Texture2D texture, Rectangle rect) : base(position, texture, rect)
    {
        this.HeroType = HeroType;
        

    }

    public override void Update()
    {
        #region Move 
        if (Keyboard.GetState().IsKeyDown(Keys.W))
        {
            rect.Y += Speed;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.S))
        {
            rect.Y += -Speed;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.A))
        {
            rect.X += -Speed;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.D))
        {
            rect.X += Speed;
        }
        #endregion //Хождение героя 

        Draw();
    }
    public override void Draw()
    {
        Sprite.Begin();
        Sprite.Draw(base.texture, base.rect, Color.White);
        Sprite.End();
    }
 
}
 //герой за которого мы играем 