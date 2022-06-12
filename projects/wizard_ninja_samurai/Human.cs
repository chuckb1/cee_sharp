class Human{
    public string Name {get; set;} 
    public int Strength {get; set;}
    public int Intelligence {get; set;}
    public int Dexterity {get; set;}
    public int Health {get; set;}
    public virtual int Attack(Human target) {
    // target health reduced by 3* attackers str
        int Damage = 5 * Strength;
        target.Health -= Damage;
        Console.WriteLine(Name + " hit " + target.Name + " for " + Damage + " points of HP");
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