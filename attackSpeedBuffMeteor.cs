using System;
using Raylib_cs;

namespace slutProjekt_test
{
    public class attackSpeedBuffMeteor : buffingMeteor
    {
         public attackSpeedBuffMeteor(float x, float y, float width, float height, Color recColor): base(x, y, width, height, recColor)
        {
        }
        public override void buff(){
            Ship.shotSpeed += 2;
            //ökar spelarens attack
        }
    }
}
