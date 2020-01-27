using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFileForm
{
    class Coin
    {
        //Field to represent the side facing up
        private string sideUp;

        //Constructor
        public Coin()
        {
            sideUp = "Heads";
        }

        //The toss method simulates tossing the coin
        public void Toss()
        {
            //create a random object
            Random rand = new Random();

            //use a random number to determind the side of the coin is facing up
            //0 = heads, 1 = tails
            if (rand.Next(2) == 0)
            {
                sideUp = "Heads";
            }
            else
            {
                sideUp = "Tails";
            }
        }

        //The GetSideUp method returns the value of the sideUp field
        public string GetSideUp()
        {
            return sideUp;
        }
    }
}
