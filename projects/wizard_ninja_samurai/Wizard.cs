class Wizard : Human 
{
    public Wizard(string name) : base(name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 25;
        Dexterity = 3;
        Health = 50;
    }

    public override int Attack(Human target)
    {
        int Damage = 5 * Intelligence;
        target.Health -= Damage;
        Health += Damage;
        Console.WriteLine(Name + " hit " + target.Name + " for " + Damage + "points of HP");
        return target.Health;
    }
    
    public int Heal(Human target)
    {
        int Healing = 10 * Intelligence;
        target.Health += Healing;
         Console.WriteLine(Name + " healed " + target.Name + " for " + Healing + " points of HP");
        return target.Health;
    }
}