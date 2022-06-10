class Animal {
    //establish the attributes of this mf
    public string Species;
    public double Weight;
    public string Diet;

//Contructor
    public Animal(string species, double weight, string diet){
        Species = species;
        Weight = weight;
        Diet = diet;
    }

// Second constructor that accepts 2 arguments and autofills the 3rd
    public Animal(string species, double weight) {
        Species = species;
        Weight = weight;
        Diet = "Omnivore";
    }
}