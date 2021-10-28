using FreshFruit.model;
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

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, model.BucketEventListener
    {
        Seller toni;
        public MainWindow()
        {
            InitializeComponent();
            Bucket keranjangBuah = new Bucket(2);
            Controller.BucketController bucketController = new
           Controller.BucketController(keranjangBuah, this);
            toni = new model.Seller("toni", bucketController);
            ListBoxBucket.ItemsSource = keranjangBuah.FindAll();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            model.Fruit anggur = new model.Fruit("Anggur");
            toni.addFruit(anggur);
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            model.Fruit Apel = new model.Fruit("Apel");
            toni.addFruit(Apel);
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            model.Fruit Banana= new model.Fruit("Banana");
            toni.addFruit(Banana);
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            model.Fruit jeruk = new model.Fruit("Jeruk");
            toni.addFruit(jeruk);
        }
        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning");
        }
        public void onSucceed(string message)
        {
            ListBoxBucket.Items.Refresh();
        }
    }

    internal class Bucket : model.Bucket
    {
        public Bucket(int capacity) : base(capacity)
        {
        }
    }
}