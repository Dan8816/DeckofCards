namespace deck
{
    public class Card
    {
        public string NameVal;
        public string Soot;
        public int IntVal;
        public Card(string StrVal, string Suit, int FaceVal)
        {
            NameVal = StrVal;
            Soot = Suit;
            IntVal = FaceVal;
        }
    }
}