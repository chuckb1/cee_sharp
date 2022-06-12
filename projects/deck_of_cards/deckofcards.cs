class Card {
    public string Name;
    // Name =  "Ace","2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King";

    public string Suit;
    // suit = Diamond Heart Spade Club
    public int Val;

//print method
    public void Print() {
        Console.WriteLine(Name);
        Console.WriteLine(Suit);
        Console.WriteLine(Val);
        return;
    }
//constructor
    public Card(string name, string suit, int val) {
        Name = name;
        Suit = suit;
        Val = val;
    }
}