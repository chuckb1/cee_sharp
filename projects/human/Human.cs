class Human{
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;
    public int Attack(Human target) {
    // target health reduced by 5* attackers str
        int Damage = 5 * Strength;
        target.Health -= Damage;
        Console.WriteLine(Name + " hit " + target.Name + " for " + Damage + "points of damage");
        return target.Health;
    }
// prepopulated constructor
    public Human(string name){
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }

//overloaded constructor
    public Human(string name, int str, int intel, int dex, int hp){
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = hp;
    }
}

