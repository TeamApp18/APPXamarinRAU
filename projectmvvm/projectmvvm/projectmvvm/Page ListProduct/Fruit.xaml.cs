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
	public partial class Fruit : ContentPage
	{
		public Fruit ()
		{
			InitializeComponent ();
            var listFruit = new List<classFruit>
            {
                new classFruit
                {
                    Fruit_Name="LONG NHÃN 01",
                    Fruit_Describes="Hàng loại nhất",
                    Fruit_Price="100.000 VNĐ",
                    Fruit_Id="F001",
                    Fruit_Point="12",
                    Fruit_Inventory="250 KG",
                    Fruit_Image="nhan.jpg"
                },
                new classFruit
                {
                    Fruit_Name="LONG NHÃN 02",
                    Fruit_Describes="Hàng loại nhất",
                    Fruit_Price="100.000 VNĐ",
                    Fruit_Id="F002",
                    Fruit_Point="12",
                    Fruit_Inventory="250 KG",
                    Fruit_Image="nhan.jpg"
                },
                new classFruit
                {
                    Fruit_Name="LONG NHÃN 03",
                    Fruit_Describes="Hàng loại nhất",
                    Fruit_Price="100.000 VNĐ",
                    Fruit_Id="F003",
                    Fruit_Point="12",
                    Fruit_Inventory="250 KG",
                    Fruit_Image="nhan.jpg"
                },
                new classFruit
                {
                    Fruit_Name="LONG NHÃN 04",
                    Fruit_Describes="Hàng loại nhất",
                    Fruit_Price="100.000 VNĐ",
                    Fruit_Id="F004",
                    Fruit_Point="12",
                    Fruit_Inventory="250 KG",
                    Fruit_Image="nhan.jpg"
                }

            };
            listview_Fruit.ItemsSource = listFruit;
        }

        private async void tap_ImageFruit(object sender, ItemTappedEventArgs e)
        {
            var fruit = e.Item as classFruit;
            await Navigation.PushAsync(new Fruit_Details(fruit));
        }
    }
}