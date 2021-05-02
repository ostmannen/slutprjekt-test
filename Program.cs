using System;
using Raylib_cs;

namespace slutProjekt_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro introduction = new Intro();

            introduction.intro();
            //skapar en instans av intro och för dens intro metod

            Raylib.InitWindow(800, 600, "Game Engine");

            Raylib.SetTargetFPS(60);
            //skapar ett fönster åt raylib och setter fps

            Ship player = new Ship();

            MeteorSpawner spawn = new MeteorSpawner();
            //skapar instanser av ship och meteorspawner

            while (!Raylib.WindowShouldClose())
            {   //while loop som kommer köras genom hela spelet
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.GRAY);

                player.update();
                //kör ship update metoden

                Raylib.DrawText(player.hp.ToString() + "Hp",25,25,30, Color.RED);
                //skriver ut hur mycket hp spelaren har

                spawn.update();
                //kör meteorspwner update metoden

                for (int i = 0; i < Bullet.allBullets.Count; i++)
                {
                    Bullet.allBullets[i].update();
                }
                //kör alla bullets update
                Raylib.EndDrawing();
            }   
        }   
    }
}
