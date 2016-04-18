using System;
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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    
    {
 

        private object NotifyType;

        public object PixelFormats { get; private set; }
        public UIElement RenderedCanvas { get; private set; }

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

        private void Acc1_3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("JEE");
            Image image = new Image();
            Image sImage = sender as Image;
            image.Source = sImage.Source;
            image.Width = 700;
            image.Height = 700;
            image.Margin = new Thickness(-57, 123, 392, 13);
            image.IsTapEnabled = true;
            image.Tapped += Image_Tapped;
            MyGrid.Children.Add(image);
        }

        //Koodia valmiin perunan tallentamiseen
        //EI TOIMI VIELÄ OIKEIN, OTTAA KUVAN KOKO HÖSKÄSTÄ EIKÄ VAAN CANVASISTA
        /// <summary>
        /// Event handler for the "Save Image.." button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void saveButton_Click(object sender, RoutedEventArgs e)
        {


   

            // Render to an image at the current system scale and retrieve pixel contents
            RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap();
            await renderTargetBitmap.RenderAsync(RenderedCanvas);
            var pixelBuffer = await renderTargetBitmap.GetPixelsAsync();

            var savePicker = new FileSavePicker();
            savePicker.DefaultFileExtension = ".png";
            savePicker.FileTypeChoices.Add(".png", new List<string> { ".png" });
            savePicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            savePicker.SuggestedFileName = "PotatoPrincess.png";

            // Prompt the user to select a file
            var saveFile = await savePicker.PickSaveFileAsync();

            // Verify the user selected a file
            if (saveFile == null)
                return;

            // Encode the image to the selected file on disk
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

          //  GamePage.NotifyUser("File saved!", NotifyType.StatusMessage); // TÄHÄN JOKU JUTTU JOKA TEKEE TEXTBLOCKKIIN TEKSTIN, ETTÄ KUVA TALLENNETTU
        }

    }

}
