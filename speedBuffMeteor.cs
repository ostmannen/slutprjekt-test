using System.Reflection.Emit;
using System;
using Raylib_cs;

namespace slutProjekt_test
{
    public class speedBuffMeteor : buffingMeteor
    {
        public speedBuffMeteor(float x, float y, float width, float height, Color recColor): base(x, y, width, height, recColor)
        {
        }
        public override void buff(){
            Ship.moveSpeed += 1;
        }
    }
}
