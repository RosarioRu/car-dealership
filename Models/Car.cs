using System;

namespace Dealership.Models 
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    //constructor for new instance of class named Car is below:
    public Car (string makeModel, int price, int milage)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = milage;
    }
    
    //below is a 'getter method':
    public string GetMakeModel()
    {
      return _makeModel;
    }

    //below we add a method that will return a bool type for objects that are instances of Car:
    public bool WorthBuying (int maxPrice) //WorthBuying() method takes one argument - maxPrice
    {
      return (Price <= maxPrice); //return true if the price is less than the maxPrice user enters, if not, return false
    }
  }
}





    