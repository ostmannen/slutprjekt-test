using System;
using Raylib_cs;

namespace slutProjekt_test
{
    public class buffingMeteor : Meteor
    {
        public buffingMeteor(float x, float y, float width, float height, Color recColor): base(x, y, width, height, recColor)
        {
        }
        public override void onDeath(){
            buff();
        }
        //används som en mall för att kunna skapa flera andra metioriter som ska ge spelaren en buff när spelaren förstör dem
        public virtual void buff(){

        }
        
    }
}
