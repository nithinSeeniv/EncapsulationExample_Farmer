using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample_Farmer
{
    class Farmer
    {

        public Farmer(int numberOfCows, int feedMultiplier) //CONSTRUCTOR 
        {
            this.feedMultiplier = feedMultiplier; //same name, therefore use this. to refer to the private field 
            NumberOfCows = numberOfCows;

        }


        public int BagsOfFeed { get; private set; }
        //public const int FeedMultiplier = 30;
        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } }
        private int numberOfCows;

     
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }

            set
            {
                numberOfCows = value;
                BagsOfFeed = FeedMultiplier * numberOfCows;
            }
        }
    }
}
