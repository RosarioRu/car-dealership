using System;
using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
  //constructor for new instance of class named Car is below:
  public Car (string makeModel, int price, int milage)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = milage;
  }
  //below we add a method that will return a bool type for objects that are instances of Car:
  public bool WorthBuying (int maxPrice) //WorthBuying() method takes one argument - maxPrice
  {
    return (Price <= maxPrice); //return true if the price is less than the maxPrice user enters, if not, return false
  }
}





  