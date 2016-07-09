using Xamarin.Forms;
using XFSampleApp.DSInterfaces;

namespace XFSampleApp
{
    public class App : Application
    {
        public App()
        {
            // Toast button
            Button showToastButton = new Button() { Text = "Show toast", HorizontalOptions = LayoutOptions.Center };
            showToastButton.Clicked += (s, e) =>
            {
                if (Device.OS == TargetPlatform.Android)
                {
                    DependencyService.Get<IAndroidPopUp>().ShowToast("This is a toast");
                }
            };

            // Snackbar button
            Button showSnackbarButton = new Button() { Text = "Show snackbar", HorizontalOptions = LayoutOptions.Center };
            showSnackbarButton.Clicked += (s, e) =>
            {
                if (Device.OS == TargetPlatform.Android)
                {
                    DependencyService.Get<IAndroidPopUp>().ShowSnackbar("This is a snackbar");
                }
            };

            StackLayout mainContent = new StackLayout() { VerticalOptions = LayoutOptions.Center };
            mainContent.Children.Add(showToastButton);
            mainContent.Children.Add(showSnackbarButton);

            MainPage = new ContentPage
            {
                Content = mainContent
            };
        }
    }
}
