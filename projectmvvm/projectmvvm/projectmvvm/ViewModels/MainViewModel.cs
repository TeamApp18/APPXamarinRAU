using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace projectmvvm.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        #endregion


        #region Construct
        public MainViewModel()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
            LoadMenu();
        }


        #endregion

        private void LoadMenu()
        {
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_Product.png",
                PageName = "UserPage",
                Title = "Product",
            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_DonHang.png",
                PageName = "OrderPages",
                Title = "Order Manager",
            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_ProductLike.png",
                PageName = "FavoriteProductPages",
                Title = "Favorite Product",
            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_MyAccout.png",
                PageName = "AccoutPages",
                Title = "Accout Manager",
            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_Message.png",
                PageName = "MessagePages",
                Title = "Message",
            });
        }
    }
}


