class Ninja : Human 
{
    public Ninja(string name) : base(name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 175;
        Health = 100;
    }

    public override int Attack(Human target)
    {
        int Damage = 5 * Dexterity;
        target.Health -= Damage;
        Random random = new Random();
        int ChanceHit = random.Next(5);
        if (ChanceHit == 1)
        {
        Console.WriteLine("ChanceHit Successful");
        target.Health -= 10;
        }
        Console.WriteLine(Name + " hit " + target.Name + " for " + Damage + " points of HP");
        return target.Health;
    }
    public int Steal(Human target)
    {
        int Stolen = 5;
        target.Health -= Stolen;
        Health += Stolen;
        return target.Health;
    }
}