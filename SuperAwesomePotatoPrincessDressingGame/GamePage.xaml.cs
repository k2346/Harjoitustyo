﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.Graphics.Imaging;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI;
using Windows.UI.Xaml.Shapes;
using Windows.Storage.Streams;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SuperAwesomePotatoPrincessDressingGame
{
    //tämä tekee aikaleiman tallennettavan tiedoston perään, että siitä saadaan uniikki
    public static class MyExtensions
    {
        public static string AppendTimeStamp(this string fileName)
        {
            return string.Concat(
                System.IO.Path.GetFileNameWithoutExtension(fileName),
                DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                System.IO.Path.GetExtension(fileName)
                );
        }
    }
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page


    
    {

        //tallentaminen
        // define storage file
        
        Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
        

        //Onko perunalla jotain päällä vai ei, eli voidaanko lisätä uusia, määritellään näillä muuttujilla

        private bool IsDress = false;
        private bool IsHair = false;
        private bool IsCrown = false;
        private bool IsLips = false;
        private bool IsHeart = false;


        public object PixelFormats { get; private set; }
        




        public GamePage()
        {
            this.InitializeComponent();

        }

        //Poistetaan vaatteet/hiukset/jne.. perunan päältä
        //Ehtolause muuttaa perunan "tilan" niin että poistetut voidaan vaihtaa uusiin

       private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Image image = sender as Image;
            Debug.WriteLine(image.Name);
            if (image.Name.Equals("Dress"))
            {
                IsDress = false;
            }
            else if (image.Name.Equals("Hair"))
            {
                IsHair = false;
            }
            else if (image.Name.Equals("Crown"))
            {
                IsCrown = false;
            }
            else if (image.Name.Equals("Lips"))
            {
                IsLips = false;
            }
            else if (image.Name.Equals("Heart"))
            {
                IsHeart = false;
            }
            MyGrid.Children.Remove(sender as Image);    
            
        }

        //************
        //Navigointi sivujen välillä
        //************
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
        // Mene SavedOutfitsPagelle
        private void moveOutfitsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SavedOutFitsPage));
        }

        //**************
        //Mekot
        //**************
        // Lisätään mekkoja perunan päälle

        private void Dress1_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (IsDress == false)
            {
                Debug.WriteLine("JEE");
                Image image = new Image();
                Image sImage = sender as Image;
                image.Source = sImage.Source;
                image.Width = 700;
                image.Height = 700;
                image.Margin = new Thickness(-87, 85, 392, 10);
                image.IsTapEnabled = true;
                image.Tapped += Image_Tapped;
                image.Name = "Dress";
                MyGrid.Children.Add(image);
                IsDress = true;
            }
        }

        private void Dress1_2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (IsDress == false)
            {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-87, 85, 392, 10);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            image.Name = "Dress";
            MyGrid.Children.Add(image);
            IsDress = true;
            }
        }

        private void Dress1_3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (IsDress == false) {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-87, 85, 392, 10);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            image.Name = "Dress";
            MyGrid.Children.Add(image);
            IsDress = true;
            }
        }

        private void Dress2_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (IsDress == false)
            {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-88, 92, 392, 10);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            image.Name = "Dress";
            MyGrid.Children.Add(image);
            IsDress = true;
            }
        }

        private void Dress2_2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (IsDress == false)
            {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-88, 92, 392, 10);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            image.Name = "Dress";
            MyGrid.Children.Add(image);
            IsDress = true;
            }
        }

        private void Dress2_3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (IsDress == false)
            {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-88, 92, 392, 10);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            image.Name = "Dress";
            MyGrid.Children.Add(image);
            IsDress = true;
            }
        }

        private void Dress3_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (IsDress == false)
            {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-89, 95, 392, 5);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            image.Name = "Dress";
            MyGrid.Children.Add(image);
            IsDress = true;
            }
        }

        private void Dress3_2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (IsDress == false)
            {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-89, 95, 392, 5);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            image.Name = "Dress";
            MyGrid.Children.Add(image);
            IsDress = true;
            }
        }

        private void Dress3_3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (IsDress == false)
            {
                Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-89, 95, 392, 5);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            image.Name = "Dress";
            MyGrid.Children.Add(image);
            IsDress = true;
            }
        }

        private void Dress4_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (IsDress == false)
            {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-87, 85, 392, 23);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            image.Name = "Dress";
            MyGrid.Children.Add(image);
            IsDress = true;
            }
        }

        private void Dress4_2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (IsDress == false)
            {
                Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-87, 85, 392, 23);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            image.Name = "Dress";
            MyGrid.Children.Add(image);
            IsDress = true;
            }
        }

        private void Dress4_3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (IsDress == false)
            {
                Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-87, 85, 392, 23);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            image.Name = "Dress";
            MyGrid.Children.Add(image);
            IsDress = true;
            }
        }

        private void Dress5_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (IsDress == false)
            {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-87, 85, 392, 13);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            image.Name = "Dress";
            MyGrid.Children.Add(image);
            IsDress = true;
            }
        }

        private void Dress5_2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (IsDress == false)
            {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-87, 85, 392, 13);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            image.Name = "Dress";
            MyGrid.Children.Add(image);
            IsDress = true;
            }
        }



        private void Dress5_3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (IsDress == false)
            {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-87, 85, 392, 13);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            image.Name = "Dress";
            MyGrid.Children.Add(image);
            IsDress = true;
            }
        }


        // Hiuksien lisäys perunalle


        private void Hair2_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (IsHair == false)
            {
                Debug.WriteLine("JEE");
                Image image = new Image();
                Image sImage = sender as Image;
                image.Source = sImage.Source;
                image.Width = 700;
                image.Height = 700;
                image.Margin = new Thickness(-88, 95, 392, 13);
                image.IsTapEnabled = true;
                image.Tapped += Image_Tapped;
                image.Name = "Hair";
                MyGrid.Children.Add(image);
                IsHair = true;
            }
        }

        private void Heart_1_Tapped(object sender, TappedRoutedEventArgs e)
        {   if (IsHeart == false)
            {
                Debug.WriteLine("JEE");
                Image image = new Image();
                Image sImage = sender as Image;
                image.Source = sImage.Source;
                image.Width = 700;
                image.Height = 700;
                image.Margin = new Thickness(-88, 90, 392, 13);
                image.IsTapEnabled = true;
                image.Tapped += Image_Tapped;
                image.Name = "Heart";
                MyGrid.Children.Add(image);
                IsHeart = true;
            }
        }

        private void Crown_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (IsCrown == false)
            {

            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-88, 93, 392, 13);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            image.Name = "Crown";
            MyGrid.Children.Add(image);
            IsCrown = true;
            }
        }

        private void Crown_2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (IsCrown == false)
            {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-85, 93, 392, 13);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            image.Name = "Crown";
            MyGrid.Children.Add(image);
            IsCrown = true;
            }
        }

        private void Acc1_3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-88, 92, 392, 13);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }
            private void Lips_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (IsLips == false)
            {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-85, 91, 392, 13);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            image.Name = "Lips";
            MyGrid.Children.Add(image);
            IsLips = true;
        }
    }

        //Metodi valmiin perunan tallentamiseen.

        private async void saveButton_Click(object sender, RoutedEventArgs e)
        {


            // Render to an image at the current system scale and retrieve pixel contents
            RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap();
            await renderTargetBitmap.RenderAsync(MyGrid);
            var pixelBuffer = await renderTargetBitmap.GetPixelsAsync();
            // tallennetaan kuva nimellä potato ja lisätään perään yksilöivä timestamp
            var saveFile = await storageFolder.CreateFileAsync("potato.png".AppendTimeStamp(), Windows.Storage.CreationCollisionOption.OpenIfExists);

            // 
            using (var fileStream = await saveFile.OpenAsync(FileAccessMode.ReadWrite))
            {  
                var encoder = await BitmapEncoder.CreateAsync(BitmapEncoder.PngEncoderId, fileStream);

                encoder.SetPixelData(
                BitmapPixelFormat.Bgra8,
                BitmapAlphaMode.Ignore,
                (uint)renderTargetBitmap.PixelWidth,
                (uint)renderTargetBitmap.PixelHeight,
                DisplayInformation.GetForCurrentView().LogicalDpi,
                DisplayInformation.GetForCurrentView().LogicalDpi,
                pixelBuffer.ToArray());
                await encoder.FlushAsync();
            }



            
        }

    }

}
