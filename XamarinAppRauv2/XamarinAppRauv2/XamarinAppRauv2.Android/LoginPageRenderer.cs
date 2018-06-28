using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json.Linq;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinAppRauv2;

[assembly: ExportRenderer(typeof(Login), typeof(XamarinAppRauv2.Droid.LoginPageRenderer))]
namespace XamarinAppRauv2.Droid
{
    public class LoginPageRenderer : PageRenderer
    {
        public LoginPageRenderer(Context context) : base(context)
        {
            var activity = this.Context as Activity;

            var auth = new OAuth2Authenticator(
                clientId: "186355732026422", // your OAuth2 client id
                scope: "", // the scopes for the particular API you're accessing, delimited by "+" symbols
                authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"),
                redirectUrl: new Uri("https://www.facebook.com/connect/login_success.html"));

            auth.Completed += async (sender, eventArgs) => {
                if (eventArgs.IsAuthenticated)
                {
                    var accessToken = eventArgs.Account.Properties["access_token"].ToString();
                    var expiresIn = Convert.ToDouble(eventArgs.Account.Properties["expires_in"]);
                    var expiryDate = DateTime.Now + TimeSpan.FromSeconds(expiresIn);

                    var request = new OAuth2Request("GET", new Uri("https://graph.facebook.com/me"), null, eventArgs.Account);
                    var response = await request.GetResponseAsync();
                    var obj = JObject.Parse(response.GetResponseText());

                    var id = obj["id"].ToString().Replace("\"", "");
                    var name = obj["name"].ToString().Replace("\"", "");

                    await App.NavigateToProfile(string.Format("Hello {0} Click go to Main Menu", name));
                }
                else
                {
                    await App.NavigateToProfile2("User can't login");
                }
            };

            activity.StartActivity(auth.GetUI(activity));
        }
    }
}