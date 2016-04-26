using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SuperAwesomePotatoPrincessDressingGame
{
    /// <summary>
    /// Super Awesome Potato Princess Dressing Game
    /// Jenni Rohunen 
    /// Maiju Shcreck
    /// Viivi Järvinen
    /// 2016
    /// </summary>
    public sealed partial class MainPage : Page

    {
        public MainPage()
        {
            this.InitializeComponent();
            // Avataan sovellus 1000 x 1000 ikkunassa
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            ApplicationView.PreferredLaunchViewSize = new Size(1000, 1000);


        }

        //Play buttonilla navigoidaan Gamepagelle
        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {

            this.Frame.Navigate(typeof(GamePage));
        }

        //SavedButtonilla navigoidaan SavedOutfitsPagelle
        private void SavedButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SavedOutFitsPage));
        }
        //Quit button lopettaa sovelluksen
        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }



    }
}