using System;
using Raylib_cs;
using System.Collections.Generic;

namespace slutProjekt_test
{
    public class MeteorSpawner
    {
        Random generator = new Random();
        
        private int spawnTimer = 0;
        public void update()
        {
            if (spawnTimer <= 0){
                randomSpawn();
                spawnTimer = 60;
            }
            spawnTimer--;
            //kör metoden randomspawn varje sekund
            for (int i = 0; i < Meteor.allMeteors.Count; i++)
            {
                Meteor.allMeteors[i].update();
            }
            
        }
        private int randomise(int min, int max){
            int r = generator.Next(min, max);
            return r;
        }
        private void randomSpawn(){
            int r = randomise(3,3);
            if (r == 1){
                Meteor.allMeteors.Add(new Meteor(randomise(1,600), -40, randomise(40,80), randomise(40,80), Color.PINK));
            }
            if (r == 2){
                Meteor.allMeteors.Add(new ExplodingMeteor(randomise(1,600), -40, randomise(40,80), randomise(40,80), Color.PINK));
            }
            if (r == 3){
                Meteor.allMeteors.Add(new speedBuffMeteor(randomise(1,600), -40, randomise(40,80), randomise(40,80), Color.BLUE));
            }

        }
       
    }
}
