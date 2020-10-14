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
            //creating a new array with a size one less than the last 
            Actor[] appendedArray = new Actor[_actors.Length + 1];
            //then we loop through and copy everything fom the old array to the new arrray
            for (int i = 0; i < _actors.Length; i++)
            {
                _actors[i] = appendedArray[i];
            }//sets the last value in the new array to be the actor we want to add
            appendedArray[_actors.Length] = actor;
            _actors = appendedArray;
        }//sets old array to hold values of the  new array
        public bool RemoveActor(int index)
        {
            //checks to see if the index is outisde the bounds of the array
            if(index < 0 || index >= _actors.Length)
            {
                return false;
            }
            bool actorRemoved = false;
            //creats a array one smaller than our old array
            Actor[] tempArray = new Actor[_actors.Length - 1];
            //creates variable to access temp array index
            int j = 0;
            //copies values from the old array to the new one 
            for(int i = 0; i < _actors.Length; i++)
            {
                //if the current index is not the index that needs to be removed 
                //add the value into the old array and increment j
                if (i != index)
                {
                tempArray[i] = _actors[i];
                j++;
                }
              else
                {
                    actorRemoved = true;
                }
            }
            _actors = tempArray;
           
            return false;

           
        }
        public bool RemoveActor(Actor actor)
        {
            //check to see if the actor was null
            if(actor == null)
            {

            }
            bool actorRemoved = false;
            for (int i = 0; i < _actors.Length; i++)
            {
                
                Actor[] newArray = new Actor[_actors.Length - 1];
                int j = 0;
            }
            return actorRemoved; 
        }
        public virtual void Start()
        {
            for(int i = 0; i < _actors.Length; i++)
            {
                _actors[i].start();
            }
        }
        public virtual void Update()
        {
            for (int i = 0; i < _actors.Length; i++)
            {
                _actors[i].Update();
            }
        }
        public virtual void Draw()
        {
            for (int i = 0; i < _actors.Length; i++)
            {
                _actors[i].Draw();
            }
        }
        public virtual void End()
        {
            for (int i = 0; i < _actors.Length; i++)
            {
                _actors[i].End();
            }
        }
    }


}
