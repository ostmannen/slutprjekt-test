using System;
using Raylib_cs;

namespace slutProjekt_test
{
    public class SmallMeteor : Meteor
    {
        public SmallMeteor(float x, float y, float width, float height, Color recColor, int speedX, int speedY): base(x, y, width, height, recColor)
        {
            moveX = speedX;
            moveY = speedY;
        }
    }
}
