using System;
using Raylib_cs;
using System.Collections.Generic;

namespace slutProjekt_test
{
    public class Bullet
    {
        public Rectangle bullet;
        public static List<Bullet> allBullets = new List<Bullet>();
        public Bullet(float bulletX, float bulletY){
            bullet = new Rectangle(bulletX + 20, bulletY, 10, 10);
            allBullets.Add(this);
            //när den instanseras skapas bullets rectangel och lägger till den i en lista 
        }
        public void Update(){
            Raylib.DrawRectangleRec(bullet, Color.BLUE);
            bullet.y -= 8;
            //ritar ut bullet och gör så att den åker uppåt
            
        }
    }
}
