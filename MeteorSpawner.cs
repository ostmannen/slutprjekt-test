using System;
using Raylib_cs;
using System.Collections.Generic;

namespace slutProjekt_test
{
    public class MeteorSpawner
    {
        Random generator = new Random();
        
        private int spawnTimer = 0;
        public void Update()
        {
            if (spawnTimer <= 0){
                RandomSpawn();
                spawnTimer = 60;
            }
            spawnTimer--;
            //kör metoden randomspawn varje sekund
            for (int i = 0; i < Meteor.allMeteors.Count; i++)
            {
                Meteor.allMeteors[i].Update();
            }
            
        }
        private int Randomise(int min, int max){
            int r = generator.Next(min, max);
            return r;
        }
        private void RandomSpawn(){
            int r = Randomise(1,4);
            if (r == 1){
                Meteor.allMeteors.Add(new Meteor(Randomise(1,600), -40, Randomise(40,80), Randomise(40,80), Color.BLACK));
            }
            if (r == 2){
                Meteor.allMeteors.Add(new ExplodingMeteor(Randomise(1,600), -40, Randomise(40,80), Randomise(40,80), Color.PINK));
            }
            if (r == 3){
                Meteor.allMeteors.Add(new speedBuffMeteor(Randomise(1,600), -40, Randomise(40,80), Randomise(40,80), Color.BLUE));
            }
        }
    }
}
