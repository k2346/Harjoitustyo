﻿using System;
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


namespace SuperAwesomePotatoPrincessDressingGame
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SavedOutFitsPage : Page
    {

// Määritellään tallennuskansio ja lista tallennettavista kuvista
        Windows.Storage.StorageFolder storageFolder =
       Windows.Storage.ApplicationData.Current.LocalFolder;

        List<BitmapImage> images = new List<BitmapImage>();

        public SavedOutFitsPage()
        {
            this.InitializeComponent();
            // Avataan sovellus 1000 x 1000

            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            ApplicationView.PreferredLaunchViewSize = new Size(1000, 1000);
            //ladataan flipviewiin kuvat kansiosta
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
// metodi joka lataa sivun uudelleen 
        public bool Reload()
        {
            if (!this.Frame.BackStack.Any())
                return false;
            var current = this.Frame.BackStack.First();
            this.Frame.BackStack.Remove(current);
            return this.Frame.Navigate(current.SourcePageType, current.Parameter);


        }


        // asynkroninen metodi joka poistaa kaikki käyttäjän tallentamat kuvat 
        public async void deletefile()
        {
                StorageFolder sourceFolder = ApplicationData.Current.LocalFolder;
 

            IReadOnlyList<StorageFile> folderList = await sourceFolder.GetFilesAsync();
            if (folderList.Count > 0)
            {
                foreach (StorageFile f1 in folderList)
                {

                    await f1.DeleteAsync(StorageDeleteOption.PermanentDelete);
                   Reload();
                }
            }
            deleteTextBlock.Text = "Nothing to show! Go and create a new Potato Princess";


        }

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            // Näytä edellinen kuva flipviewissä
            if (savedView.SelectedIndex > 0) savedView.SelectedIndex--;
        }

        private void RightButton_Click(object sender, RoutedEventArgs e)
        {
            // Näytä seuraava kuva flipviewissä
            if (savedView.SelectedIndex < (images.Count - 1)) savedView.SelectedIndex++;
        }

        //return buttonia klikkaamalla navigoidaan takaisin
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

        //Quit button lopettaa sovelluksen
        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
        //Remove buttonilla suoritetaan deletefile metodi, joka poistaa kaikki kansiossa olevat käyttäjän tallentamat kuvat.
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {

                 deletefile();  

                }
            }
        }
    

