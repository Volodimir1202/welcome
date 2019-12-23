/******************************************************************************
1. Створити клас, який буде уособлювати Гараж Шейха. 
Створити клас, який буде уособлювати Автомобіль. 
В Гаражі зберігається необмежена кількість Автомобілів. 
Шейх може купити новий Автомобіль в Гараж, чи викинути існуючий. 
Також Шейх може взяти машину покататися за певними критеріями: за ім’ям машини, 
кольором, швидкістю, року випуску (за всіма параметрами, або частково). 
Після введення параметру на екран виводяться всі Автомобілі з Гаражу Шейха, 
які підходять за цими параметрами
*******************************************************************************/
using System;
using System.Collections.Generic; 

class Program {
  static void Main() {
        // create Garash Sheiha
        Garash Sheiha = new Garash();
        // my cars
        Car toyota_big = new Car(){model = "toyota rav4",color = "red",speed = 170,create_year = 2019};
        Car toyota_mini = new Car(){model = "toyota yaris",color = "red",speed = 170,create_year = 2019};
        
        // adding cars in Garash
        Sheiha.my_cars.Add(toyota_big);
        Sheiha.my_cars.Add(toyota_mini);
        Sheiha.ShowAllCar();
        Console.WriteLine();
        
        // buy a car
        Console.WriteLine("[Byu a car]");
        Sheiha.ByuCar();
        Sheiha.ShowAllCar();
        
        Console.WriteLine();
        // delete a car
        Console.WriteLine("[delete a car]");
        Sheiha.DeleteCar();
        Sheiha.ShowAllCar();
        
        Console.WriteLine();
        // Drive a car
        Console.WriteLine("[Drive a car]");
        Sheiha.DriveCar();
  }
}

public class Garash{

  public List<Car> my_cars = new List<Car>();
  
  public void ByuCar(){
    Console.WriteLine("[Shop Car]");
    Car new_car = new Car();
    
    Console.WriteLine("Which car do you want to buy?");
    
    Console.Write("model = ");
    new_car.model = Console.ReadLine();
    Console.Write("color = ");
    new_car.color = Console.ReadLine();
    Console.Write("Швидкість = ");
    new_car.speed = Convert.ToInt32(Console.ReadLine());
    Console.Write("Рік випуску = ");
    new_car.create_year = Convert.ToInt32(Console.ReadLine());
  
    this.my_cars.Add(new_car);
  }
  public void DeleteCar(){
      this.ShowAllCar();
      Console.WriteLine("Which car do you want to delete?");
      int parking = 0;
      do{
          Console.WriteLine("select parking space");
          parking = Convert.ToInt32(Console.ReadLine());
      }while(parking < 1 || parking > this.my_cars.Count);
      this.my_cars.RemoveAt(parking-1);
  }

  public static void ShowCar(Car car){
      Console.WriteLine("model: " + car.model + " | " + "year: " + car.create_year);
      Console.WriteLine("color: " + car.color + " | " + "max speed: " + car.speed);
  }
   
  public void ShowAllCar(List<Car>  cars = null){
    if(cars == null){
        Console.WriteLine("[Your cars]");
        cars = this.my_cars;
    }
      for(int i = 0;i<cars.Count; i++)
      {
          Console.WriteLine("[Parking space " + (i+1) + "]");
          Garash.ShowCar(cars[i]);
      }
  }
      public void DriveCar(List<Car> cars = null){
        if(cars == null)
            cars = this.my_cars;
        List<int> old_parametr = new List<int>();
        Console.WriteLine(cars.Count);
        
        while(cars.Count>1  || cars.Count == 0){
            if(cars.Count == 0){
                Console.WriteLine("Your not have car");
                return;
            }
            this.ShowAllCar(cars);
            Console.WriteLine("select creteria");
            string [] parametrs = {"model", "color", "speed","year"};
            
            for(int i = 0;i<parametrs.Length;i++){
                bool flag = false; 
                for(int j = 0;j<old_parametr.Count;j++){
                    if((i+1)==old_parametr[j])
                        flag = true;
                }
                if(flag == false)
                    Console.Write((i+1)+")"+parametrs[i]+" ");
            }
            Console.WriteLine();
            int k = 0;
            do{
                Console.Write("filter=");
                k = Convert.ToInt32(Console.ReadLine());
                if(k<1 || k>4)
                    Console.WriteLine("Invalide value");
            }while(k<1 || k>4);
            old_parametr.Add(k);
            switch(k){
                case 1:
                    Console.WriteLine("model:");
                    string model = Console.ReadLine();
                    cars = this.SearchName(model);
                    break;
                case 2:
                    Console.WriteLine("color:");
                    string color = Console.ReadLine();
                    cars = this.SearchColor(color);
                    break;
                case 3:
                    Console.WriteLine("speed:");
                    int speed = Convert.ToInt32(Console.ReadLine());
                    cars = this.SearchSpeed(speed);
                    break;
                case 4:
                    Console.WriteLine("year:");
                    int year = Convert.ToInt32(Console.ReadLine());
                    cars = this.SearchYear(year);
                    break;
                }
            }
            if (cars.Count == 0 )
                Console.WriteLine("your have not car with creteria");
            else{
                Console.WriteLine("[You select car ]");
                Garash.ShowCar(cars[0]);
            }
            Console.WriteLine("----------------------------------");
        }
        
    public List<Car> SearchName(string name, List<Car> cars = null){
        if(cars == null)
            cars = this.my_cars;
        List<Car> out_cars = new List<Car>();
        foreach(Car el in cars)
            if(el.model == name)
                out_cars.Add(el);
        return out_cars;
    }
    public List<Car> SearchColor(string color, List<Car> cars = null){
        if(cars == null)
            cars = this.my_cars;
        List<Car> out_cars = new List<Car>();
        foreach(Car el in cars)
            if(el.color == color)
                out_cars.Add(el);
        return out_cars;
    }
    public List<Car> SearchYear(int year, List<Car> cars = null){
        if(cars == null)
            cars = this.my_cars;
        List<Car> out_cars = new List<Car>();
        foreach(Car el in cars)
            if(el.create_year == year)
                out_cars.Add(el);
        return out_cars;
    }
    public List<Car> SearchSpeed(int speed, List<Car> cars = null){
        if(cars == null)
            cars = this.my_cars;
        List<Car> out_cars = new List<Car>();
        foreach(Car el in cars)
            if(el.speed == speed)
                out_cars.Add(el);
        return out_cars;
    }
    
    public List<Car> SearchSpeed(int speedmin, int speedmax, List<Car> cars = null){
        if(cars == null)
            cars = this.my_cars;
        List<Car> out_cars = new List<Car>();
        foreach(Car el in cars)
            if(speedmin <= el.speed && el.speed <= speedmax)
                out_cars.Add(el);
        return out_cars;
    }
  
}

public class Car{
    public string model { get; set; }
    public string color { get; set; }
    public int speed { get; set; }
    public int create_year { get; set; }
}