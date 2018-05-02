using System;

namespace carClass
{
    class Car
    {
        private string _make; 
        private string _color; 
        private string _gearbox; 

        public string GetMake() {
            return _make; 
        }

        public void SetMake(string make) {
            _make = make; 
        }

        public string GetColor() {
            return _color; 
        }

        public void SetColor(string color) {
            _color = color; 
        }

        public string GetGearbox() {
            return _gearbox;
        }

        public void SetGearbox(string gearbox) {
            _gearbox = gearbox; 
        }

        public string DescribeCar() {
            return $"This car is a {GetMake()} and is {GetColor()} the transmission is a {GetGearbox()}.";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter car details below");
            Console.WriteLine("Make:  ");
            var make = Console.ReadLine();
            Console.WriteLine("Color:  ");
            var color = Console.ReadLine();
            Console.WriteLine("GearBox:  "); 
            var gearbox = Console.ReadLine(); 

            Console.WriteLine(); 


            var car1 = new Car();
            car1.SetMake(make); 
            car1.SetColor(color); 
            car1.SetGearbox(gearbox);
            Console.WriteLine(car1.DescribeCar());


            Console.WriteLine("Press any key to exit"); 
            Console.ReadKey(); 
        }
    }
}
