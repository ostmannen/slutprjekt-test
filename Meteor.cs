using System.Net.Sockets;
using System;
using Raylib_cs;
using System.Collections.Generic;

namespace slutProjekt_test
{
    public class Meteor
    {
        public static int scorecounter = 0;
        public Rectangle meteor;
        public static List<Meteor> allMeteors = new List<Meteor>();
        public int moveX = 0;
        public int moveY = 3;
        public Color meteorColor = Color.BLACK;
        public Meteor(float x, float y, float width, float height, Color recColor){
            meteor = new Rectangle(x, y, width, height);
            meteorColor = recColor;
            //när en instans av Meteor skapas så kommer den skapa en rectangel som har höjd , bredd och position endligt vad som skrevs in
            //färgen som skrevs in kommer också sparas 
        }

        public void update(){
            
            Raylib.DrawRectangleRec(meteor, meteorColor);
            checkCollision();
            move();
            //varje frame så ritas rektangeln ut och checkCollision samt move metoderna körs            
        }
        public void move(){
            meteor.y += moveY;
            meteor.x += moveX;
            //adderar på x och y värdet
        }
        public void checkCollision(){
            for (int i = 0; i < Bullet.allBullets.Count; i++)
            {
                if (Raylib.CheckCollisionRecs(Bullet.allBullets[i].bullet, meteor))
                {
                    allMeteors.Remove(this);
                    Bullet.allBullets.RemoveAt(i);
                    onDeath();
                }
                //går igenom alla bullets och kollar ifall de colliderar med meteor
                //ifall det händer så förstörs meteor och bullet och onDeath metoden körs
            }
        }
        public virtual void onDeath(){
        }
        public void add(){
            
        }
    }
}
