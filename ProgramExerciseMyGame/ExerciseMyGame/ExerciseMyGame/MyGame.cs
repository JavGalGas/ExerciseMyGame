using System.Collections.Generic;
using System.Reflection;
using UDK;

namespace ExerciseMyGame
{
    public class MyGame : IGameDelegate
    {

        

        //cuando entres al juego
        public void OnLoad(GameDelegateEvent gameEvent)
        {
            MyWorld.CreateCharacters(pj1);
        }

        //al pulsar una tecla del teclado
        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            Character? p1 = MyWorld.GetCharacterAt(1);

            if (keyboard.IsKeyDown(Keys.Right))
            {
                p1.x += 0.007;
            }
            if (keyboard.IsKeyDown(Keys.Left))
            {
                p1.x -= 0.007;
            }
            if (keyboard.IsKeyDown(Keys.Up))
            {
                p1.y += 0.007;
            }
            if (keyboard.IsKeyDown(Keys.Down))
            {
                p1.y -= 0.007;
            }
        }

        //...
        public void OnAnimate(GameDelegateEvent gameEvent)
        {
            for (int i = 0; i < MyWorld.GetCharacterCount(); i++)
            {
                Character ch = MyWorld.GetCharacterAt(i);
                ch.x = ch.x + Utils.GetRandomBetween(-0.007, 0.007);
                ch.y = ch.y + Utils.GetRandomBetween(-0.007, 0.007);
            }
        }

        //...
        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            canvas.Clear(0.0, 0.0, 0.0, 1.0);
            canvas.Camera.SetRectangle(MyWorld.Rectangle.x, MyWorld.Rectangle.y, MyWorld.Rectangle.width, MyWorld.Rectangle.height);

            for (int i = 0; i < MyWorld.GetCharacterCount(); i++)
            {
                Character ch = MyWorld.Characters[i];
                Character.Draw(canvas);
            }
        }

        //cuando salgas del juego
        public void OnUnload(GameDelegateEvent gameEvent)
        {

        }
    }
}

