using System;

namespace DesignPatternsDemo.StructuralPattern.ProxyPattern
{
    public class ProxyCar : ICar
    {
        private readonly Driver _driver;
        private readonly ICar _realCar;

        public ProxyCar(Driver driver)
        {
            _driver = driver;
            _realCar = new Car();
        }

        public string DriveCar()
        {

            var random = new Random();

            Console.WriteLine(random.Next(1, 26));
            
            return _driver.Age < 16 ? "Sorry, the driver is too young to drive." : _realCar.DriveCar();
        }
    }
}