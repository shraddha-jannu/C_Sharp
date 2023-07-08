using System;

class Country{
    string country_name;
    double population;
    
    public Country(string country_name, double population){
        this.country_name = country_name;
        this.population = population;
    }
    
    public virtual void DisplayInfo(){
        Console.WriteLine("Country Name: "+this.country_name);
        Console.WriteLine("Population: "+this.population);
    }
}
class State:Country{
    string state_name;
    double pop;
    
    public State(string country_name, double population, string state_name, double pop):base(country_name,population){
        this.state_name = state_name;
        this.pop =  pop;
    }
    
    public new void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("State name: "+this.state_name);
        Console.WriteLine("State population: "+this.pop);
    }
}

class HelloWorld {
  static void Main() {
      Country obj1 = new Country("India",12345678);
      obj1.DisplayInfo(); 
      
      Console.WriteLine();
        State obj2 = new State("India",12345678,"Mah",672431);
        obj2.DisplayInfo();
  }
}
