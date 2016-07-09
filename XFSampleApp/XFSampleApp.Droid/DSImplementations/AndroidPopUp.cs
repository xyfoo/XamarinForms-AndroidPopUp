using XFSampleApp.DSInterfaces;
using Xamarin.Forms;
using Android.Support.Design.Widget;
using Plugin.CurrentActivity;
using Android.App;
using Android.Widget;

[assembly: Dependency(typeof(XFSampleApp.Droid.AndroidPopUp))]

namespace XFSampleApp.Droid
{
    public class AndroidPopUp : IAndroidPopUp
    {
        public void ShowSnackbar(string message)
        {
            Activity activity = CrossCurrentActivity.Current.Activity;
            // Get root view of current activity
            Android.Views.View activityRootView = activity.FindViewById(Android.Resource.Id.Content);
            Snackbar.Make(activityRootView, message, Snackbar.LengthLong).Show();
        }

        public void ShowToast(string message)
        {
            Activity activity = CrossCurrentActivity.Current.Activity;
            Toast.MakeText(Forms.Context, message, ToastLength.Long).Show();
        }
    }
}