using System;
using Raylib_cs;
using System.Collections.Generic;

namespace slutProjekt_test
{
    public class Ship
    {
        public int hp = 3;
        public static float moveSpeed = 8;
        public static float shotSpeed = 1;
        public float canShot;
        public Rectangle player = new Rectangle(375, 400, 50, 50);
        

        public void update(){
            Raylib.DrawRectangleRec(player, Color.BLACK);
            move();
            shot();
            checkCollistion();
            
            
        }
        private void move(){
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) && player.x <= 750)
            {
                player.x += moveSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) && player.x >= 0)
            {
                player.x -= moveSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP) && player.y >= 0)
            {
                player.y -= moveSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN) && player.y <= 550)
            {
                player.y += moveSpeed;
            }
        }
        private void shot(){
            if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE) && canShot <= 0) {
                new Bullet(player.x, player.y);
                canShot = 30;
            }
            canShot -= shotSpeed;
            System.Console.WriteLine(shotSpeed);
        }
        public void checkCollistion(){
            
            for (int i = 0; i < Meteor.allMeteors.Count; i++)
            {
                if (Raylib.CheckCollisionRecs(player, Meteor.allMeteors[i].meteor))
                {
                    hp--;
                    Meteor.allMeteors.RemoveAt(i);
                }
            }
        }
    }
}
