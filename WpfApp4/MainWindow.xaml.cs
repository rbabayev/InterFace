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

namespace WpfApp4
{

    public partial class MainWindow : Window
    {

        public class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public string Year { get; set; }

          
        }

        public MainWindow()
        {
            InitializeComponent();
            int nowYear = DateTime.Now.Year;
            int numberOfYear = 30;
            for (int i = 0; i < numberOfYear; i++) { int year = nowYear - i; Year.Items.Add(year); }
        }

        public void SaveButton(object sender, RoutedEventArgs e)
        {
            List<Car> list = new List<Car>
            {
                new(){Make="Mercedes",Model="E63 AMG",Year="2022"},
                new(){Make="Bmw",Model="M5",Year="2018"},
                new(){Make="Kia",Model="Optima",Year="2014"},
                new(){Make="Hyundai",Model="Elantra",Year="2015"},
                new(){Make="Lamborghini",Model="Aventador",Year="2012"},
                new(){Make="Volvo",Model="XC90",Year="2022"},
                new(){Make="Togg",Model="T10X",Year="2022"},
            };



            foreach (Car car in list) { CarList.Items.Add(car); }
        }
    }



}

