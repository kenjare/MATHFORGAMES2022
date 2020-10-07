using System;
using System.Collections.Generic;
using System.Text;

namespace MathForGames
{
    class Scene
    {//creating an array for actors
        private Actor[] _actors;

        public Scene()
        {
            _actors = new Actor[0];
        }
        public void AddActor(Actor actor)
        {
            Actor[] appendedArray = new Actor[_actors.Length + 1];
            for (int i = 0; i < _actors.Length; i++)
            {//copies everything from our old array
                _actors[i] = appendedArray[i];
            }//sets existing array to be another array 
            appendedArray[_actors.Length] = actor;
            _actors = appendedArray;
        }
        public void Start()
        {

        }
        public void Update()
        {

        }
    }

}
