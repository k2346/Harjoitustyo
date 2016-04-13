using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SuperAwesomePotatoPrincessDressingGame
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {
        public GamePage()
        {
            this.InitializeComponent();

        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MyGrid.Children.Remove(sender as Image);
        }





        // return button
        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            if (rootFrame == null) return;

            // Navigate back if possible
            if (rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }

        // Lisätään mekkoja perunan päälle
        private void Dress1_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-50, 120, 392, 10);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }

        private void Dress1_2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-50, 120, 392, 10);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }

        private void Dress1_3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-50, 120, 392, 10);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }

        private void Dress2_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-55, 120, 392, 10);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }

        private void Dress2_2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-55, 120, 392, 10);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }

        private void Dress2_3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-55, 120, 392, 10);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }

        private void Dress3_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-55, 120, 392, 5);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }

        private void Dress3_2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-55, 120, 392, 5);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }

        private void Dress3_3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-55, 120, 392, 5);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }

        private void Dress4_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-55, 120, 392, 23);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }

        private void Dress4_2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-55, 120, 392, 23);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }

        private void Dress4_3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-55, 120, 392, 23);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }

        private void Dress5_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-55, 120, 392, 13);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }

        private void Dress5_2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-55, 120, 392, 13);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }

    

        private void Dress5_3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-55, 120, 392, 13);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }


// Hiuksien lisäys perunalle

        private void Hair2_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-55, 120, 392, 13);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }

        private void Heart_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-55, 120, 392, 13);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }

        private void Crown_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-55, 120, 392, 13);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }

        private void Crown_2_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }
    }
}
