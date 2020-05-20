# RedCorners.Forms.CameraView

A CameraView for Xamarin.Forms (iOS and Android only), based on ZXing.Net by Redth.

To include the namespace in your XAML:

```
xmlns:rfc="clr-namespace:RedCorners.Forms;assembly=RedCorners.Forms.CameraView"
```

Then simply use it:

```
<rfc:CameraView x:Name="cameraView" />
```

To take a photo:

```
await cameraView.CapturePhotoAsync(path);
```

Permissions are handled by Xamarin.Essentials on first use. You have to set up Xamarin.Essentials permissions in your projects.

# Example

```
<rf:TitledContentView Title="RedCorners.Forms.CameraView" HasButton="False" x:Name="titleView">
	<rf:TitledContentView.ToolBar>
		<Button Visual="Default" BackgroundColor="Transparent" Text="Capture" Clicked="Button_Clicked" TextColor="White" />
	</rf:TitledContentView.ToolBar>
	<Grid>
		<rfc:CameraView x:Name="cameraView" />
		<Image x:Name="previewImage" Aspect="AspectFill" />
	</Grid>
</rf:TitledContentView>
```

```
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
```