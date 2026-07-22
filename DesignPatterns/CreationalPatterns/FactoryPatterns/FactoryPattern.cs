using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryPatterns
{
    public enum VehicleType
    {
        TwoWheeler,
        FourWheeler
    }

    //Step 1
    //Abstarct base vehicle class
    public abstract class Vehicle
    {
        //Abstarct method
        public abstract void PrintInfo();
    }
    //Step 3
    //Create derieved classe from abstract class and implement the abstarct method
    //Two Wheeler
    public class TwoWheeler : Vehicle
    {
        public override void PrintInfo()
        {
            Console.WriteLine("This is Two Wheeler");
        }
    }
    //Four Wheeler
    public class FourWheeler : Vehicle
    {
        public override void PrintInfo()
        {
            Console.WriteLine("This is Four Wheeler");
        }
    }
    //Factory interface
    public interface IVehicleFactory 
    { 
      public Vehicle Build(VehicleType vehicleType);
    }

    //Factory class
    public class VehicleFactory : IVehicleFactory
    {
        public Vehicle Build(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.TwoWheeler:
                    return new TwoWheeler();

                case VehicleType.FourWheeler:
                    return new FourWheeler();

                default:
                    return null;
            }           
        }
    }

    //Client class
    public class Client
    {
        private Vehicle _vehicle;
        public Client()
        {
            _vehicle = null;
        }
        public void BuildVehicle(VehicleType vehicleType)
        {
            IVehicleFactory factory = new VehicleFactory();
            _vehicle= factory.Build(vehicleType);
        }
        public Vehicle GetVehicle()
        {
            return _vehicle;
        }
    }

    public class FactoryPattern
    {
       //Main method to call
       public static void Main()
        {
            Client c1= new Client();
            Client c2= new Client();
            c1.BuildVehicle(VehicleType.TwoWheeler);
            c1.GetVehicle().PrintInfo();
            c2.BuildVehicle(VehicleType.FourWheeler);
            c2.GetVehicle().PrintInfo();
        }
    }
}
