using projectmvvm.Class;
using projectmvvm.Page_Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectmvvm.Page_ListProduct
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Tubers : ContentPage
	{
		public Tubers ()
		{
			InitializeComponent ();
            var listTubers = new List<classTubers>
            {
                new classTubers
                {
                    Tubers_Name="CỦ NĂNG 01",
                    Tubers_Describes="Hàng loại nhất",
                    Tubers_Price="50.000 VNĐ",
                    Tubers_Id="T001",
                    Tubers_Point="22",
                    Tubers_Inventory="150 KG",
                    Tubers_Image="cu.jpg"
                },
                 new classTubers
                {
                    Tubers_Name="CỦ NĂNG 02",
                    Tubers_Describes="Hàng loại nhất",
                    Tubers_Price="50.000 VNĐ",
                    Tubers_Id="T002",
                    Tubers_Point="22",
                    Tubers_Inventory="150 KG",
                    Tubers_Image="cu.jpg"
                },
                  new classTubers
                {
                    Tubers_Name="CỦ NĂNG 03",
                    Tubers_Describes="Hàng loại nhất",
                    Tubers_Price="50.000 VNĐ",
                    Tubers_Id="T003",
                    Tubers_Point="22",
                    Tubers_Inventory="150 KG",
                    Tubers_Image="cu.jpg"
                },
                   new classTubers
                {
                    Tubers_Name="CỦ NĂNG 04",
                    Tubers_Describes="Hàng loại nhất",
                    Tubers_Price="50.000 VNĐ",
                    Tubers_Id="T004",
                    Tubers_Point="22",
                    Tubers_Inventory="150 KG",
                    Tubers_Image="cu.jpg"
                }

            };
            listview_Tuber.ItemsSource = listTubers;
        }

        private async void tap_ImageTubers(object sender, ItemTappedEventArgs e)
        {
            var tuber = e.Item as classTubers;
            await Navigation.PushAsync(new Tubers_Details(tuber));
        }
    }
}