using System.Net.Sockets;
using System;
using Raylib_cs;
using System.Collections.Generic;

namespace slutProjekt_test
{
    public class Meteor
    {
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

        public void Update(){
            
            Raylib.DrawRectangleRec(meteor, meteorColor);
            CheckCollision();
            Move();
            //varje frame så ritas rektangeln ut och checkCollision samt move metoderna körs            
        }
        private void Move(){
            meteor.y += moveY;
            meteor.x += moveX;
            //adderar på x och y värdet
        }
        private void CheckCollision(){
            for (int i = 0; i < Bullet.allBullets.Count; i++)
            {
                if (Raylib.CheckCollisionRecs(Bullet.allBullets[i].bullet, meteor))
                {
                    allMeteors.Remove(this);
                    Bullet.allBullets.RemoveAt(i);
                    OnDeath();
                }
                //går igenom alla bullets och kollar ifall de colliderar med meteor
                //ifall det händer så förstörs meteor och bullet och onDeath metoden körs
            }
        }
        public virtual void OnDeath(){
        }
        //skulle kunna användas för att lägga till score men orkade inte så...

    }
}
