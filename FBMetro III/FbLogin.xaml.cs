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
using System.Dynamic;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace FBMetro_III
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FbLogin : Page
    {
       
        //Define a Facebook App ID, as well as extended permissions.
<<<<<<< HEAD
        private const string AppId = "220287254759782";
        private const string ExtendedPermissions = "user_about_me,read_stream,publish_stream,user_location";
=======
        private const string AppId = "";
        private const string ExtendedPermissions = "user_about_me,read_stream,publish_stream";
>>>>>>> 36e182d3e12c89f83407558f6e8e263d93906414
        
        // Initialize the Facebook Client.
        private readonly FacebookClient _fb = new FacebookClient();
 
        public FbLogin()
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
        }

        private void WebView_Loaded_1(object sender, RoutedEventArgs e)
        {
            WebView1.LoadCompleted += WebView1_LoadCompleted;

            var loginUrl = GetFacebookLoginUrl(AppId, ExtendedPermissions);
            WebView1.Navigate(loginUrl);
        }

        private Uri GetFacebookLoginUrl(string appId, string extendedPermissions)
        {
            dynamic parameters = new ExpandoObject();
            parameters.client_id = appId;
            parameters.redirect_uri = "https://www.facebook.com/connect/login_success.html";
            parameters.response_type = "token";
            parameters.display = "popup";

            // add the 'scope' parameter only if we have extendedPermissions.
            if (!string.IsNullOrWhiteSpace(extendedPermissions))
            {
                // A comma-delimited list of permissions
                parameters.scope = extendedPermissions;
            }

            return _fb.GetLoginUrl(parameters);
        }

        private void WebView1_LoadCompleted(object sender, Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            FacebookOAuthResult oauthResult;
            if (!_fb.TryParseOAuthCallbackUrl(e.Uri, out oauthResult))
            {
                return;
            }

            if (oauthResult.IsSuccess)
            {
                var accessToken = oauthResult.AccessToken;
                LoginSucceded(accessToken);
            }
            else
            {
                // user cancelled
            }
        }

        private async void LoginSucceded(string accessToken)
        {
            dynamic parameters = new ExpandoObject();
            parameters.access_token = accessToken;
            parameters.fields = "id";

            dynamic result = await _fb.GetTaskAsync("me", parameters);
            parameters = new ExpandoObject();
            parameters.id = result.id;
            parameters.access_token = accessToken;

            Frame.Navigate(typeof(FbInfo), (object)parameters);
        }
    }
}
