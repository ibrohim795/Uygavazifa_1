namespace Uygavazifa_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Tesla tesla = new Tesla(2000, 90000, 4, "6000A");
             tesla.Displayinfo();


            Wolkswagen wolkswagen = new Wolkswagen(1999, 200, 4, "200A");
             wolkswagen.Displayinfo();

            Toyota toyota = new Toyota(2020,2000,2,"500");
             toyota.Displayinfo();

            Bmw bmw = new Bmw(2030,4000,2,"550");
             bmw.Displayinfo();

            Airplane airplane = new Airplane(2015, 900000, "800");
             airplane.Displayinfo();

        }
    }
    class vhicle
    {
        public int Year { get; set; }
        public decimal Price { get; set; }
        public vhicle(int year, decimal price)
        {
            Year = year;
            Price = price;
        }

        public void Displayinfo() 
        {
            Console.WriteLine();
            Console.WriteLine($"Year: {Year}\nPrice: {Price}");
           
        }
    }
    class Airvhicle : vhicle
    { 
        public string Fuelcapacity { get; set; }
        public Airvhicle(int year,decimal price,string fuelcapacity)
            : base(year,price) 
        { 
         Fuelcapacity = fuelcapacity;
        }
    }
    class Airplane : Airvhicle
    {
        public Airplane(int year, decimal price, string fuelcapacity)
            : base(year, price, fuelcapacity)
        {

        }
        public void Displayinfo()
        {
            base.Displayinfo();
            Console.WriteLine("Name: Airplane ");
        }
    }
    class Car : vhicle
    { 
        public int NumberOfDoors { get; set; }
        public Car(int year,decimal price,int numberOfDoors)
            : base(year, price)
        {
            NumberOfDoors = numberOfDoors;
        }
       
        public void Displayinfo()
        {
           base.Displayinfo();
            Console.WriteLine($"NumberOfDoors: {NumberOfDoors}");
        }
    }
    class Elictric : Car
    {
        public string BattaryCapacity { get; set; }
        public Elictric(int year,decimal price,int numberOfDoors,string battarycapacity)
            : base(year, price,numberOfDoors)
        {
            BattaryCapacity = battarycapacity;
        }
        public void Displayinfo()
        {

            
            base.Displayinfo();
            Console.WriteLine($"ChangeBatary: {BattaryCapacity}");
        }
    }
    class Disel: Car
    {
        public string  Maxspeed { get; set; }
        public Disel(int year,decimal price ,int numberOfDoors,string maxspeed)
            : base(year, price,numberOfDoors)
        {
            Maxspeed = maxspeed;
        }
        public void Displayinfo()
        {
            base.Displayinfo() ;
            Console.WriteLine($"Maxspeed: {    Maxspeed}");
        }
    }
    class Tesla : Elictric
    {
        public Tesla(int year, decimal price, int numberOfDoors, string battarycapacity)
           : base(year, price, numberOfDoors, battarycapacity)
        {

        }
        public void Displayinfo()
        {
            base.Displayinfo();
            Console.WriteLine("Name: Tesla");
        }

    }
    class Wolkswagen : Elictric
    {

        public Wolkswagen(int year, decimal price, int numberOfDoors, string battarycapacity)
           : base(year, price, numberOfDoors, battarycapacity)
        {

        }
        public void Displayinfo()
        {
            base.Displayinfo();
            Console.WriteLine("Name:  Wolkswagen ");
        }
    }
    class Toyota : Disel
    {
        
        public Toyota(int year,decimal price ,int numberOfDoors, string maxspeed)
            :base (year, price,numberOfDoors ,maxspeed)
        {
            
        }
        public void Displayinfo()
        {
            base.Displayinfo();
            Console.WriteLine("Name: Toyota");

        }
    }
    class Bmw : Disel
    {

        public Bmw(int year, decimal price, int numberOfDoors, string maxspeed)
            : base(year, price, numberOfDoors, maxspeed)
        {

        }
        public void Displayinfo()
        {
           base.Displayinfo();
           Console.WriteLine("Name: BMW");
        }
    }
   
}