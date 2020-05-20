using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using RedCorners;
using RedCorners.Forms;
using System.IO;

namespace CameraViewDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            titleView.BackCommand = new Command(() =>
            {
                previewImage.Source = null;
                titleView.HasButton = false;
            });
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "photo.jpg");

            await cameraView.CapturePhotoAsync(path);

            previewImage.Source = path;
            titleView.HasButton = true;
        }
    }
}