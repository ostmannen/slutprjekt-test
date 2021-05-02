using System.Reflection;
using System;
using Raylib_cs;
using System.Collections.Generic;

namespace slutProjekt_test
{
    public class Intro
    {
        public bool play = true;

        private int yPostion = 100;
        Queue<string> introText = new Queue<string>();
        //skapar en queue        
        public void intro(){
            
            
            
            Raylib.InitWindow(800, 600, "Game Engine");

            Raylib.SetTargetFPS(60);

             while (play)
            {
                introText.Enqueue("HI WELCOME TO GAME");
                introText.Enqueue("MOVE WITH YOUR ARROW KEYS");
                introText.Enqueue("SHOT WITH SPACE");
                introText.Enqueue("DO NOT GET HIT BY EVIL CUBES");
                introText.Enqueue("PRESS ENTER TO START");
                introText.Enqueue("GL HF");
                //lägger till vad som ska skrivas ut i min queue

                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.GRAY);
                yPostion = 100;
                //sätter så att y positionen är 100
                for (int i = 0; i < introText.Count - 1; i++)
                {
                    Raylib.DrawText(introText.Peek(), 25,yPostion,40,Color.GREEN);
                    introText.Dequeue();
                    yPostion += 50;
                    //går igenom och det som är i queue och skriver ut det och ser till att nästa rad skrivs lengre ner
                }
                //väldigt dålig användning av en queue, men det är en queue
               

                if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER)){
                    play = false;
                    //ifall splaren klickar enter så avslutas intro instuktionerna och spelet startas
                }

                Raylib.EndDrawing();
            }   
            Raylib.CloseWindow();
            
        }
    }
}
