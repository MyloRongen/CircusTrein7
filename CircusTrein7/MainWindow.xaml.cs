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
using ClassLibraryCircus.Classes;

namespace CircusTrein7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Train _train = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddAnimals_Click(object sender, RoutedEventArgs e)
        {
            AddAnimals();
        }

        private void AddAnimals()
        {
            InitializeAnimal.MakeDummyContentAnimals(_train);

            foreach (Animal animal in _train.Animals)
            {
                _ = AnimalList.Items.Add(animal.Size + " " + animal.Type + " points " + animal.Point);
            }
        }

        private void SortByWagon_Click(object sender, RoutedEventArgs e)
        {
            _train.SortAnimals();
            DisplayAnimalsInTrains();
        }

        private void DisplayAnimalsInTrains()
        {
            string collectionContents = "";
            foreach (Wagon wagon in _train.Wagons)
            {
                collectionContents += "Wagon has: ";
                collectionContents += "\n";

                foreach (Animal animal in wagon.Animals)
                {
                    collectionContents += "Animal type: " + animal.Type + ", Animal size: " + animal.Size + ", Animal point: " + animal.Point + ", ";
                    collectionContents = collectionContents.TrimEnd(',', ' ');
                    collectionContents += "\n";
                }

                collectionContents = collectionContents.TrimEnd(',', ' ');
                collectionContents += "\n";
            }

            _ = MessageBox.Show(collectionContents);
        }
    }
}