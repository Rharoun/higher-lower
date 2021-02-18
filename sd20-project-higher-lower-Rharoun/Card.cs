using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHigherLower
{
    // Vervang de class Card met de Card van card-assignment opdracht zodra die af is.
    class Card
    {
        /*
         * Attributten bepalen
         *  
         * Hoe weet je nu welke attributes een class moet hebben?
         *
         * De attributes van een class beschrijven waar het object uit moet bestaan.
         *
         * Een kaart heeft bijvoorbeeld een symbol, harten, schoppen, ruiten of klaveren.
         * De engelse benaming hiervoor is een suit.
         * Een suit bestaat vaak uit de kleur rood of zwart. Deze variabele noemen we colour.
         * Verder bestaat het uit een getal of letter, 2 - 10, J, Q, K, A. Deze variabele noemen we value.
         * Dit getal of deze letter heeft vaak ook een waarde, vaak kan je de J zien als 11, Q als 12, K als 13, A als 14. Echter verschilt dit nog wel eens per kaarspel.
         * Er moet een punten op de kaart zitten om de waarde te bepalen of een kaart hoger is dan een andere. Deze variabele noemen we points.
         */
        // Attributes
        private string suit;
        private string colour;
        private string value;
        private int points;
        private static string[] allowedValues = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        /*
         * Constructor
         */
        public Card(string value, string suit, int points)
        {
            this.SetValue(value);
            this.SetSuit(suit);
            this.points = points;
        }

        // TODO #2 This method should be implemented.
        /**
         * This method prints the card e.g. 2♡ or J♤
         */
        public void PrintCard()
        {
            Console.Write(" 2♡ ");

        }

        // TODO #1 This method seems to be broken. Can someone fix this please?
        /**
         * Checks wether the value is in the allowedValues list.
         * If it is this method returns true. - gedaan
         */
        public bool CheckValue(string value)
        {
            bool isAllowed = false;
            for (int i = 0; i < allowedValues.Length; i++)
            {
                if (value == allowedValues[i])
                {
                    isAllowed = true;
                }
            }
            return isAllowed;
        }

        /**
         * This method returns the points of this card. 
         */
        public int GetPoints()
        {
            return points;
        }

        /**
         * This method sets the Suit of the card AND the colour that represents that suit.
         */
        public void SetSuit(string suit)
        {
            if (suit == "♡" || suit == "♢" || suit == "♧" || suit == "♤")
            {
                this.suit = suit;
                this.colour = GetColour(suit);
            }
            else
            {
                throw new Exception("Could not find the specified suit.");
            }
        }

        /**
         * This method checks the value and if the value is allowed it sets the value.
         * This method method uses the CheckValue method to check if the value is correct.
         */
        public void SetValue(string value)
        {
            if (CheckValue(value))
            {
                this.value = value;
            }
            else
            {
                throw new Exception("This value of a card is not allowed");
            }
        }

        /**
         * This method returns the color. 
         * You can use this method with and suit argument to translate a suit to colour 
         */
        public string GetColour()
        {
            return this.colour;
        }

        /**
         * This method translate a suit to the corresponsing color.
         * Use this method to get the colour of a suit
         */
        public string GetColour(string suit)
        {
            if (suit == "♡" || suit == "♢")
            {
                return "red";
            }
            else if (suit == "♧" || suit == "♤")
            {
                return "black";
            }
            else
            {
                throw new Exception("Could not find the specified suit.");
            }
        }

        /**
         * Returns all the allowed Card Values
         */
        public static string[] GetAllowedCardValues()
        {
            return allowedValues;
        }

        public static void Cardmake() 
        { 
          
        }
    }
}
