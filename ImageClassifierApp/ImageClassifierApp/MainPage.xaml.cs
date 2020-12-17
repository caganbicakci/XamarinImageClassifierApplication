using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xam.Plugins.OnDeviceCustomVision;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Essentials;
using System.IO;


namespace ImageClassifierApp
{
    public partial class MainPage : ContentPage
    {

        
        public MainPage()
        {
            InitializeComponent();

            //TakePhotoBtn.Clicked += async (sender, args) =>
            //{
            //    if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            //    {
            //        await DisplayAlert("No Camera", ":( No camera available.", "OK");
            //        return;
            //    }

            //    var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            //    {
            //        Directory = "Test",
            //        SaveToAlbum = true,
            //        CompressionQuality = 75,
            //        CustomPhotoSize = 50,
            //        PhotoSize = PhotoSize.MaxWidthHeight,
            //        MaxWidthHeight = 2000,
            //        DefaultCamera = CameraDevice.Front
            //    });

            //    if (file == null)
            //        return;

            //    Image.Source = ImageSource.FromStream(() =>
            //    {
            //    var stream = file.GetStream();
            //    file.Dispose();
            //    return stream;
            //    });
            //};



        }



    }


    
}
