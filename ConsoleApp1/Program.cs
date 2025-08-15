using System;
using System.Runtime.ConstrainedExecution;

var people = new List<Person>
{
    new Person { Name = "Ali", Age = 25 },
    new Person { Name = "Bobur", Age = 32 },
    new Person { Name = "Dilnoza", Age = 28 },
    new Person { Name = "Kamol", Age = 40 },
    new Person { Name = "Madina", Age = 35 }
};
int[] numbers = { 3, 4, 7, 10, 13, 15, 19, 21, 23, 29 };
var cars = new List<Car>
{
    new Car { Model = "Chevrolet Cobalt", Year = 2020 },
    new Car { Model = "Chevrolet Gentra", Year = 2021 },
    new Car { Model = "Nexia 3", Year = 2020 },
    new Car { Model = "Malibu 2", Year = 2022 },
    new Car { Model = "Tracker", Year = 2021 }
};
//1
//IEnumerable<string> person =
//    from peoples in people.AsParallel()
//    where peoples.Age > 30
//    select peoples.Name;
//foreach (var item in person)
//{
//    Console.WriteLine(item);
//}

//2
//var person = 
//    from peoples in people.AsParallel()
//    group peoples.Age by peoples.Age into age
//    select new { Age=age.Key, Count = age.Count() };
//foreach (var item in person)
//{
//    Console.WriteLine(item);
//}

//3
//var person =
//    (from peoples in people
//     orderby peoples.Age descending
//     select peoples.Name).Take(5);

//foreach(var p in person)
//{
//    Console.WriteLine(p);
//}

//4

//var primes =
//    from n in numbers.AsParallel()
//    where IsPrime(n)
//    select n;

//foreach (var p in primes)
//{
//    Console.WriteLine(p);
//}


// 5

var car = from c in cars
          group c by c.Year into yearGroup
          select new
          {
              Year = yearGroup.Key,
              Count = yearGroup.Count()
          };
    foreach(var carss  in car)
{
    Console.WriteLine(carss);
}





bool IsPrime(int n)
{
    if (n < 2) return false;
    for (int i = 2; i <= Math.Sqrt(n); i++)
        if (n % i == 0) return false;
    return true;
}
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Car
{
    public string Model { get; set; }
    public int Year { get; set; }
}
