class Food{
    public string Name;
    public int Calories;
    public bool IsSpicy; 
    public bool IsSweet; 
    public Food(string foodName, int calories, bool isSpicy, bool isSweet){
        Name = foodName;
        Calories = calories;
        IsSpicy = isSpicy;
        IsSweet = isSweet;
    }
}
class Buffet
{
    public List<Food> Menu;

    //constructor
    public Buffet()
    {
        Menu = new List<Food>(){
            
            new Food("Hamburger", 600, false, false),
            new Food("Pizza", 400, false, false),
            new Food("Tacos", 600, false, false),
            new Food("Gumbo", 800, true, false),
            new Food("S'more's", 600, false, true),
            new Food("Icecream", 400, false, true),
            new Food("Buffalo Wings", 1200, true, false)
            
        };
    }
    public Food Serve(){
        Random flip = new Random();
        int randomNum = flip.Next(7);
        Food randomFood = this.Menu[randomNum];
        Console.WriteLine($"You just at some {randomFood.Name}! Crazy Bro.");
        return randomFood;
    }
}
class Ninja{
    private int calorieIntake;
    public List<Food> FoodHistory;
    // add a public "getter" property called "IsFull"
    public bool isFull {
        get {return calorieIntake > 1200;}
    }
    // add a constructor
    public Ninja() {
        calorieIntake = 0;
        FoodHistory = new List<Food>();
    }
    // build out the Eat method
    public void Eat(Food item){
        this.calorieIntake += item.Calories;
        FoodHistory.Add(item);
        
    }
}

