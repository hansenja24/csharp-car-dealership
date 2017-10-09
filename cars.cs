using System;
using System.Collections.Generic;

class Car
{
  private int _code;
  public string MakeModel;
  public int Price;
  public int Miles;
  public bool Availability;

  public Car(string CarModel, int CarPrice = 25000, int CarMiles = 0)
  {
    MakeModel = CarModel;
    Price = CarPrice;
    Miles = CarMiles;
    Availability = true;
  }

  public void SetCode(int newCode)
  {
    _code = newCode;
  }

  public int GetCode()
  {
    return _code;
  }
}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car("2014 Porsche 911",114991,7864);
    Car ford = new Car("2014 Ford F450",55995);
    Car lexus = new Car("2013 Lexus RX 350",44700,20000);
    Car mercedes = new Car("Mercedes Benz CLS550",39900);

    porsche.SetCode(11);
    ford.SetCode(12);
    lexus.SetCode(13);
    mercedes.SetCode(21);
    mercedes.Availability = false;

    List<Car> Cars = new List<Car>() {porsche, ford, lexus, mercedes};

    foreach(Car automobile in Cars)
    {
      Console.WriteLine(automobile.MakeModel);
      Console.WriteLine(automobile.GetCode());
    }

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>();

    foreach (Car automobile in Cars)
    {
      if (automobile.Price < maxPrice)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      if(automobile.Availability){
        Console.WriteLine(automobile.MakeModel);
        Console.WriteLine(automobile.GetCode());
      }
    }
  }
}
