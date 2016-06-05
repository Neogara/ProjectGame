using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectGame;

public class Camera // камера для персонажа 
{
    public Vector2 screenCenter;
    public Matrix matrixScreen;
    public Viewport viewPort;



    public Camera(Viewport viewPort)
    {
        this.viewPort = viewPort;
    }

    public void Update(GameTime gameTime,GameObject viewObject) // сдвиг камеры на персонажа 
    {
        screenCenter = new Vector2(viewObject.position.X - viewPort.Width/2 , viewObject.position.Y - viewPort.Height / 2);
        matrixScreen = Matrix.CreateScale(new Vector3(1, 1, 0)) * Matrix.CreateTranslation(new Vector3(-screenCenter.X, -screenCenter.Y, 0));
        
    }
}

