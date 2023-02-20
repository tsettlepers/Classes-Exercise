namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car() { Make = "Honda", Model = "Pilot", Year = 2015 };
            Console.WriteLine($"I drive a {myCar.Year} {myCar.Make} {myCar.Model}.");
        }
    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

    }
}
