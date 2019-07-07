using CatFactsApp.Api;
using CatFactsApp.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace CatFactsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Facts _allFacts;

        public Facts allFacts
        {
            get { return _allFacts; }
            set { _allFacts = value; NotifyPropertyChanged(); }
        }


        public MainWindow()
        {
            InitializeComponent();
            allFacts = new Facts();
        }

        private async void GetFacts()
        {
            try
            {
                allFacts = await ApiWrapper.RetrieveFacts();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                GetFacts();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
