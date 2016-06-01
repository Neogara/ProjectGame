using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


public abstract class GameObject // игровой обьект 
{
    public Vector2 Position; // позиция
    public Texture2D texture; // текстура
    public Rectangle rect; //Бокс
    public bool Collision; // колизия 
    public TypeGameObject GameType; // тип 

    abstract public void Draw(SpriteBatch spriteBatch);  // функия рисования

    abstract public void Update(SpriteBatch spriteBatch) // функция ОБновления 
}










