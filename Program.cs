public class Program 
{
  public static void Main()
  {
    //using the constructor for instances of class named Car to instiate the Car objects below:
    Car volkswagen = new Car ("1974 Volkswagen Thing", 1100, 368792);
    Car yugo = new Car ("1980 Yugo Koral", 700, 56000);
    Car ford = new Car ("1988 Ford Country Squire", 1400, 239001);
    Car amc = new Car("1976 AMC Pacer", 400, 198000);

    //CODE BELOW REPLACED BY FOUR LINES ABOVE BY USING CONSTRUCTOR//
    // Car volkswagen = new Car();
    // volkswagen.MakeModel = "1974 Volkswagen Thing";
    // volkswagen.Price = 1100;
    // volkswagen.Miles = 368792;

    // Car yugo = new Car();
    // yugo.MakeModel = "1980 Yugo Koral";
    // yugo.Price = 700;
    // yugo.Miles = 56000;

    // Car ford = new Car();
    // ford.MakeModel = "1988 Ford Country Squire";
    // ford.Price = 1400;
    // ford.Miles = 239001;

    // Car amc = new Car();
    // amc.MakeModel = "1976 AMC Pacer";
    // amc.Price = 400;
    // amc.Miles = 198000;

    List<Car> TheCars = new List<Car>() {volkswagen, yugo, ford, amc};
    // code to get maxPrice from user:
    Console.WriteLine("Enter Maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);
    
    List<Car> CarsMatchingSearch = new List<Car> (0);

    foreach (Car automobile in TheCars)
    {
      if (automobile.WorthBuying(maxPrice))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }
  
    foreach (Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }
    
  }
}