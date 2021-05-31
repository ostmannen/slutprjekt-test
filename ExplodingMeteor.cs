using System;
using Raylib_cs;

namespace slutProjekt_test
{
    public class ExplodingMeteor : Meteor
    {
        
        public ExplodingMeteor(float x, float y, float width, float height, Color recColor): base(x, y, width, height, recColor)
        {
        }
        public override void OnDeath(){
            allMeteors.Add(new SmallMeteor(meteor.x, meteor.y, 25, 25, Color.BLACK, 7, 7));
            allMeteors.Add(new SmallMeteor(meteor.x, meteor.y, 25, 25, Color.BLACK, -7, -7));
            allMeteors.Add(new SmallMeteor(meteor.x, meteor.y, 25, 25, Color.BLACK, -7 ,7));
            allMeteors.Add(new SmallMeteor(meteor.x, meteor.y, 25, 25, Color.BLACK, 7 ,-7));
            //när den dör instansieras 4 små metiorer som kommer åka ut från från den
        }
    }
}
