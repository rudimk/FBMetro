using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Facebook;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace FBMetro_III
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FbInfo : Page
    {

        private readonly FacebookClient _fb = new FacebookClient();
        private string _userId;

        public FbInfo()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            dynamic parameter = e.Parameter;
            _fb.AccessToken = parameter.access_token;
            _userId = parameter.id;

            GetUserProfilePicture();
            GetUserName();
            GetUserBio();
            GetUserLocation();
        }

        private async void GetUserProfilePicture()
        {
            try
            {
                dynamic result = await _fb.GetTaskAsync("me?fields=picture");
                string id = result.id;

                // available picture types: square (50x50), small (50xvariable height), large (about 200x variable height) (all size in pixels)
                // for more info visit http://developers.facebook.com/docs/reference/api
                string profilePictureUrl = string.Format("https://graph.facebook.com/{0}/picture?type={1}&access_token={2}", _userId, "square", _fb.AccessToken);

                imgProfilePic.Source = new BitmapImage(new Uri(profilePictureUrl));
            }
            catch (FacebookApiException ex)
            {
                // Write an error handler of some sort.
            }
        }

        private async void GetUserName()
        {
            try
            {
                dynamic result_username = await _fb.GetTaskAsync("me?fields=name");
                txbUserName.Text = result_username.name;
            }
            catch (FacebookApiException ex)
            {
                // Again, write some sort of error handler.
            }
        }


        private async void GetUserBio()
        {
            try
            {
                dynamic result_bio = await _fb.GetTaskAsync("me?fields=bio");
                txbBio.Text = result_bio.bio;
            }
            catch (FacebookApiException ex)
            {
                // Error handlers.
            }

        }

        private async void GetUserLocation()
        {
            try
            {
                dynamic result_location = await _fb.GetTaskAsync("me?fields=location");
                txbLocation.Text = result_location.location.name;
            }
            catch (FacebookApiException ex)
            {
                // Error handlers.
            }
        }


    }
}
