using System;
using Raylib_cs;

namespace slutProjekt_test
{
    public class bigShip : Ship
    {
        public bigShip(){
            player = new Rectangle(375, 400, 100, 100);
        }
        private void Shot(){
            if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE) && canShot <= 0) {
                new Bullet(player.x , player.y);
                canShot = 30;
            }
            canShot -= shotSpeed;
        }
    }
}
