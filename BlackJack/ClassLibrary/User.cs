using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class User
    {
        List<Card> hand;
        public void AddCard(Card c)
        {
            hand.Add(c);
        }

       


    }
}
