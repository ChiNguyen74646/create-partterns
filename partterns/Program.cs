using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace partterns
{
    internal class Program
    {
       /// <summary>
        /// MainApp startup class for Real-World 
        /// Builder Design Pattern.
        /// </summary>

        public class MainApp
        {
            /// <summary>
            /// Entry point into console application.
            /// </summary>

            public static void Main()
            {
                VehicleBuilder builder;

                // Create shop with vehicle builders

                Shop shop = new Shop();

                // Construct and display vehicles

                builder = new ScooterBuilder();
                shop.Construct(builder);
                builder.Vehicle.Show();

                builder = new CarBuilder();
                shop.Construct(builder);
                builder.Vehicle.Show();

                builder = new MotorCycleBuilder();
                shop.Construct(builder);
                builder.Vehicle.Show();

                // Wait for user

                Console.ReadKey();
            }
        }

        /// <summary>
        /// The 'Director' class
        /// </summary>

        class Shop
        {
            // Builder uses a complex series of steps

            
        /// <summary>
        /// The 'ConcreteBuilder1' class
        /// </summary>

        class MotorCycleBuilder : VehicleBuilder
        {
            public MotorCycleBuilder()
            {
                vehicle = new Vehicle("MotorCycle");
            }

            public override void BuildFrame()
            {
                vehicle["frame"] = "MotorCycle Frame";
            }

            public override void BuildEngine()
            {
                vehicle["engine"] = "500 cc";
            }

            public override void BuildWheels()
            {
                vehicle["wheels"] = "2";
            }

            public override void BuildDoors()
            {
                vehicle["doors"] = "0";
            }
        }

        /// <summary>
        /// The 'ConcreteBuilder2' class
        /// </summary>

        

        /// <summary>
        /// The 'ConcreteBuilder3' class
        /// </summary>

        

        /// <summary>
        /// The 'Product' class
        /// </summary>

       

}