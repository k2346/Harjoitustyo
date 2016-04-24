using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SuperAwesomePotatoPrincessDressingGame
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SavedOutFitsPage : Page
    {
        Windows.Storage.StorageFolder storageFolder =
       Windows.Storage.ApplicationData.Current.LocalFolder;

        List<BitmapImage> images = new List<BitmapImage>();

        public SavedOutFitsPage()
        {
            this.InitializeComponent();
            // try open 1000x1000 window
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            ApplicationView.PreferredLaunchViewSize = new Size(1000, 1000);

            flipviewload();
        }


        //Tässä laitetaan kansiossa olevat kuvat listaan ja lista toistetaan savedView nimisessä Flipviewerissä
      
        public async Task flipviewload()
        {
     

            IReadOnlyList<StorageFile> fileList = await storageFolder.GetFilesAsync();
            if (fileList != null)
            {
                foreach (StorageFile file in fileList)
                {
                    string cExt = file.FileType;
                    if (cExt.Equals(".png"))
                    {
                        Windows.Storage.Streams.IRandomAccessStream fileStream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
                        using (Windows.Storage.Streams.IRandomAccessStream filestream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read))
                        {
                            BitmapImage bitmapImage = new BitmapImage();
                            await bitmapImage.SetSourceAsync(fileStream);
                            images.Add(bitmapImage);
                        }
                    }
                }
            }
            savedView.ItemsSource = images;
        }

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            // show previous image
            if (savedView.SelectedIndex > 0) savedView.SelectedIndex--;
        }

        private void RightButton_Click(object sender, RoutedEventArgs e)
        {
            // show next image
            if (savedView.SelectedIndex < (images.Count - 1)) savedView.SelectedIndex++;
        }

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
        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
