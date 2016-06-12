using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


public class GameObject // игровой обьект 
{
    public Vector2 position; // позиция
    public Texture2D texture; // текстура
    public Rectangle rect; //Бокс
    public Rectangle collider; //колайдер 
    public Animation animation; // обьект анимации 
    public Vector2 origialPosition; // 
    public int frameH ;
    public int frameW;

    public bool collision; // колизия 
    public TypeGameObject GameType; // тип s

    public GameObject(Vector2 position, Texture2D texture, int frameH, int frameW)
    {
        this.texture = texture;
        this.position = position;
        this.rect = new Rectangle(0, 0, frameW, frameH);
        this.origialPosition = new Vector2(rect.Width / 2, rect.Height / 2);
        this.collider = new Rectangle((int)position.X, (int)position.Y, frameW, frameH);
        this.frameH = frameH;
        this.frameW = frameW;

        this.animation = new Animation(rect, origialPosition, 100, frameH, frameW);
    }

    virtual public void Draw(SpriteBatch spriteBatch, float rotation, float scale)
    {
        spriteBatch.Draw(texture, position, rect, Color.White, rotation , origialPosition, scale, SpriteEffects.None, 0);
    }// функия рисования

    virtual public void Update(GameTime gameTime) { } // функция ОБновления 
}

public class Animation // обьект анимации 
{
    public Rectangle rect; //Бокс

    public int frameHeight; // высота спрайта 
    public int frameWidth; // ширина спрайта

  
    public int currentFrame; // текущй кадр 

    public float timer; // таймер 
    public float interval = 50; //интервал 
    public Vector2 originalPosition;

    public Animation(Rectangle rect, Vector2 originalPosition, float interval, int frameH, int frameW)
    {
        this.rect = rect;
        this.interval = interval;
        this.frameHeight = frameH;
        this.frameWidth = frameW;
        this.currentFrame = 0;
    }

    public Rectangle DrawAnimation(GameTime gameTime, int rowFrame, int startFrame, int endFrame) // процедура анимации 
    {
        rect = new Rectangle(currentFrame * frameWidth, rowFrame * frameHeight, frameWidth, frameHeight);
        originalPosition = new Vector2(rect.Width / 2, rect.Height / 2);

        timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds / 2;
        if (timer > interval)
        {
            currentFrame++;
            timer = 0;
            if (currentFrame >= endFrame / frameWidth || currentFrame <= startFrame) { currentFrame = 0; }
        }
        return rect;
    }

}

