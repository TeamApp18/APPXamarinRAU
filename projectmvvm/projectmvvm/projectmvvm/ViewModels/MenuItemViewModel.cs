using GalaSoft.MvvmLight.Command;
using projectmvvm.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace projectmvvm.ViewModels
{
   public class MenuItemViewModel
    {
        #region Thuộc tính chuyển pages
        private NavigationService navigationService;
        #endregion

        #region Properties
        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }
        #endregion

        #region contructor điều hướng
        public MenuItemViewModel()
        {
            navigationService = new NavigationService();
        }
        #endregion

        public ICommand NavigateCommad { get { return new RelayCommand(Navigate); } }

        public async void Navigate()
        {
            await navigationService.Navigate(PageName);
        }
    }
}
