using projectmvvm.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace projectmvvm.Service
{
    public class NavigationService
    {
         public async Task Navigate(string pageName)
        {
            App.Master.IsPresented = false;
            switch (pageName)
            {
                case "UserPage":
                    await App.Navigator.PushAsync(new UserPage());
                    break;
                case "OrderPages":
                    await App.Navigator.PushAsync(new OrderPages());
                    break;
                case "FavoriteProductPages":
                    await App.Navigator.PushAsync(new FavoriteProductPages());
                    break;
                case "AccoutPages":
                    await App.Navigator.PushAsync(new AccoutPages());
                    break;
                case "MessagePages":
                    await App.Navigator.PushAsync(new MessagePages());
                    break;
            }
        }
    }
}
