namespace deck_of_playing_cards
{
    class Card
    {
        public string stringVal { get; set; }
        public string suit { get; set; }        

        public Card(string faceVal, string suitVal)
        {
            stringVal = faceVal;
            suit = suitVal;           
        }
    }
}
