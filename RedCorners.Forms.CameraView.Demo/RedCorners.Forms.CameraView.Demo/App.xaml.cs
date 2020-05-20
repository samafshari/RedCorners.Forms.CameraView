using RedCorners;
using RedCorners.Components;
using RedCorners.Forms;
using CameraViewDemo.Systems;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CameraViewDemo
{
    public partial class App : Application2
    {
        public override Page GetFirstPage()
            => new Views.MainPage();

        public override void InitializeSystems()
        {
            InitializeComponent();
            base.InitializeSystems();
            SplashTasks.Add(SettingsSystem.Instance.InitializeAsync);
        }
    }
}
