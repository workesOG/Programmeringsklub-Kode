using System.Security.Cryptography;

namespace Code;
class Classes
{
    public void Main()
    {
        Car car = new Car(); // Making a new instance of our "Car" class.
        car.DisplayInfo(); // Calling the predefined DisplayInfo() from the newly created instance of the "Car" class.
        car.color = "Candy Red"; // Here we are assigning a new value to a field in our instance of the "Car" class.
        car.DisplayInfo(); // Calling the function again to check that the value has changed.

        ElectricCar electricCar = new ElectricCar(); // Creating a new instance of the "ElectricCar" class
        electricCar.DisplayInfo(); // Calling the overridden DisplayInfo() function

        Person person1 = new Person("Anders", "Andersen", 42); // Creating a new instance of the "Person" class using our constructor.
        Person person2 = new Person("Jack", "Sparrow", 20, 2003); // Creating another instance of the "Person" class using our other constructor that includes 1 overload.

        // Calling our DisplayPersonData() function for both our instances of people.
        person1.DisplayPersonData();
        person2.DisplayPersonData();
    }
}

class Car
{
    // We define our variables. We define them as "public", so that we can change them from other classes.
    public string model = "Ford Fiesta";
    public int productionYear = 2014;
    public string color = "Green";

    public virtual void DisplayInfo() // We add the "virtual" keyword, so that the function can be overwritten
    {
        Console.WriteLine("Car type: normal");
        Console.WriteLine($"Model: {model}, Production year: {productionYear}, Color: {color}");
    }
}

class ElectricCar : Car
{
    // We define our new variable
    int batteryCapacity = 105;

    // Here we are redefining our inherited variables using the "new" keyword.
    new string model = "Tesla";
    new int productionYear = 2020;
    new string color = "White";

    public override void DisplayInfo() // We use the override keyword in order to signal that we are overriding an existing function.
    {
        Console.WriteLine("Car type: electric");
        Console.WriteLine($"Model: {model}, Production year: {productionYear}, Color: {color}, Battery Capacity: {batteryCapacity} kWh");
    }
}

class Person
{
    // We will first define our fields. Here we are using the "private" keyword, as these should not be accessible from other scripts, as we set them using the constructor.
    private string firstName;
    private string lastName;
    private int age;
    private int birthYear;

    // Defining a constructor for the "Person" class that takes 3 parameters, and automatically calculates the birth year using the current year and the input age.
    public Person(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;

        int year = 2023;

        this.birthYear = year - age;
    }

    // Defining a second constructor for the "Person" class that takes 4 paramenters, so the person can manually write the birth year.
    public Person(string firstName, string lastName, int age, int birthYear)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.birthYear = birthYear;
    }

    // Displaying the data about our person.
    public void DisplayPersonData()
    {
        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Birth year: " + birthYear);
    }

}
