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
	public partial class Vegetables : ContentPage
	{
		public Vegetables ()
		{
			InitializeComponent ();
            var listVegetables = new List<classVegetables>
            {
                new classVegetables
                {
                    Vegetables_Name="CẢI THÌA 01",
                    Vegetables_Describes="Hàng loại nhất",
                    Vegetables_Price="25.000 VNĐ",
                    Vegetables_Id="V001",
                    Vegetables_Point="25",
                    Vegetables_Inventory="100 KG",
                    Vegetables_Image="rau001.jpg"
                },
                new classVegetables
                {
                    Vegetables_Name="CẢI THÌA 02",
                    Vegetables_Describes="Hàng loại nhất",
                    Vegetables_Price="25.000 VNĐ",
                    Vegetables_Id="V002",
                    Vegetables_Point="25",
                    Vegetables_Inventory="100 KG",
                    Vegetables_Image="rau001.jpg"
                },
                new classVegetables
                {
                    Vegetables_Name="CẢI THÌA 03",
                    Vegetables_Describes="Hàng loại nhất",
                    Vegetables_Price="25.000 VNĐ",
                    Vegetables_Id="V003",
                    Vegetables_Point="25",
                    Vegetables_Inventory="100 KG",
                    Vegetables_Image="rau001.jpg"
                },
                new classVegetables
                {
                    Vegetables_Name="CẢI THÌA 04",
                    Vegetables_Describes="Hàng loại nhất",
                    Vegetables_Price="25.000 VNĐ",
                    Vegetables_Id="V004",
                    Vegetables_Point="25",
                    Vegetables_Inventory="100 KG",
                    Vegetables_Image="rau001.jpg"
                }
            };
            listview_Vegetable.ItemsSource = listVegetables;
		}

        private async void tap_ImageVegetables(object sender, ItemTappedEventArgs e)
        {
            var vegetable = e.Item as classVegetables;
            await Navigation.PushAsync(new Vegetables_Details(vegetable));

        }
    }
}