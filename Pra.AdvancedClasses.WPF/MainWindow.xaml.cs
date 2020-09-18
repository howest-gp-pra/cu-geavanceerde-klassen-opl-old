using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pra.AdvancedClasses.CORE;

namespace Pra.AdvancedClasses.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnShowCar_Click(object sender, RoutedEventArgs e)
        {
            Car car = new Car();
            car.NumberOfDoors = 4;
            car.HasEngine = true;
            car.Brand = "Honda";
            lblDetails.Content = car.ShowDetails();
        }

        private void btnShowBicycle_Click(object sender, RoutedEventArgs e)
        {
            Bicycle bicycle = new Bicycle();
            bicycle.HasFenders = true;
            bicycle.HasEngine = false;
            bicycle.Brand = "Specialized";
            lblDetails.Content = bicycle.ShowDetails();
        }

        private void btnShowVehicle_Click(object sender, RoutedEventArgs e)
        {
            Vehicle vehicle = new Vehicle
            {
                HasEngine = true,
                Brand = "Airbus"
            };
            lblDetails.Content = vehicle.ShowDetails();
        }

        private void btnMakeMeansOfTransportation_Click(object sender, RoutedEventArgs e)
        {
            Bicycle bicycle1 = new Bicycle { HasEngine = true, HasFenders = true, Brand = "Granville" };
            Bicycle bicycle2 = new Bicycle { HasEngine = false, HasFenders = false, Brand = "Merckx" };
            Car car1 = new Car { NumberOfDoors = 2, HasEngine = true, Brand = "BMW" };
            Car car2 = new Car { NumberOfDoors = 4, HasEngine = true, Brand = "Peugeot" };
            Car car3 = new Car { NumberOfDoors = 3, HasEngine = false, Brand = "Trabant" };

            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(bicycle1);
            vehicles.Add(bicycle2);
            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(car3);

            lblDetails.Content = "";
            foreach (Vehicle vehicle in vehicles)
            {
                lblDetails.Content += $"{vehicle.ShowDetails()}\n";
            }

            //foreach (Vehicle vehicle in vehicles)
            //{
            //    if (vehicle is Bicycle)
            //    {
            //        Bicycle bicycle = (Bicycle)vehicle;
            //        bicycle.ShowDetails();
            //    }
            //    if (vehicle is Car)
            //    {
            //        Car car = (Car)vehicle;
            //        car.ShowDetails();
            //    }
            //}

        }
    }
}
