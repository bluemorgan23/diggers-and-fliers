using System;
using System.Collections.Generic;

namespace diggers_and_fliers
{
    public class AnimalLists
    {
        public List<IWalking> LandAnimals {get; set;} 
        public List<ISwimming> SeaAnimals {get; set;} 
        public List<IFlying> AnimalsOfTheSky {get; set;} 

        public List<IDigging> AnimalsThatDig {get; set;} 

    }
}