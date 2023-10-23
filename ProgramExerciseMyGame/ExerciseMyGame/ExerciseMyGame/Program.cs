using System.Collections.Generic;
using System.Reflection;
using UDK;

namespace ExerciseMyGame
{
    //Debo crear tres ficheros(MyGame,MyWorld,Character), en el que meteré una clase en cada uno (MyGame,MyWorld,Characters).
    //
    //Debe mostrar algo similar a lo de aquí.(en MyWorld pon funciones para Draw, OnLoad, Create...;
    //en Program SOLO debe estar lo que hay en Main;
    //y en MyGame debe estar la lista de personajes)
    //
    //Clase de listas: SIEMPRE pon RemoveAt, IndexOf...

    internal class Program
    {
        static void Main(string[] args)
        {

            MyGame juego = new MyGame();
            UDK.Game.Launch(juego);
        }
    }
}