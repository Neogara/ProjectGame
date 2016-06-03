using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


public  class GameObject // игровой обьект 
{
    public Vector2 Position; // позиция
    public Texture2D texture; // текстура
    public Rectangle rect; //Бокс
    public SpriteBatch Sprite;
    public bool Collision; // колизия 
    public TypeGameObject GameType; // тип s

    public GameObject (Vector2 position , Texture2D Texture ,Rectangle Rect)
    {
        texture = Texture;
        rect = Rect;
        Position = position;  
    }

    virtual public void Draw() { }// функия рисования


    virtual public void Update() { } // функция ОБновления 
}










