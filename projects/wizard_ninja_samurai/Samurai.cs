class Samurai : Human 
{
    public Samurai(string name) : base(name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 200;
    }

    public override int Attack(Human target)
    {
        int Damage = 5 * Strength;
        target.Health -= Damage;
        Console.WriteLine(Name + " hit " + target.Name + " for " + Damage + " points of HP");
        if (target.Health < 50)
        {
            target.Health = 0;
        }
        return target.Health;
    }
    public int Meditate()
    {
        Health = 200;
        return Health;
    }
}