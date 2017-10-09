using System;
using System.Collections.Generic;

class Car
{
  private string _MakeModel;
  private int _Price;
  private int _Miles;
  public bool Availability;

  public Car()
  {
    Availability = true;
  }

  public void SetCode(string newModel, int newPrice, int newMiles)
  {
    _MakeModel = newModel;
    _Price = newPrice;
    _Miles = newMiles;
  }

  public int GetPrice()
  {
    return _Price;
  }

  public string GetModel()
  {
    return _MakeModel;
  }

  public int GetMiles()
  {
    return _Miles;
  }
}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car();
    porsche.SetCode("2014 Porsche 911",114991,7864);

    Car ford = new Car();
    ford.SetCode("2014 Ford F450",55995,14241);

    Car lexus = new Car();
    lexus.SetCode("2013 Lexus RX 350",44700,20000);

    Car mercedes = new Car();
    mercedes.SetCode("Mercedes Benz CLS550",39900,37979);

    mercedes.Availability = false;

    List<Car> Cars = new List<Car>() {porsche, ford, lexus, mercedes};

    foreach(Car automobile in Cars)
    {
      Console.WriteLine(automobile.GetModel());
    }

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>();

    foreach (Car automobile in Cars)
    {
      if (automobile.GetPrice() < maxPrice)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      if(automobile.Availability){
        Console.WriteLine(automobile.GetModel());
      }
    }
  }
}
