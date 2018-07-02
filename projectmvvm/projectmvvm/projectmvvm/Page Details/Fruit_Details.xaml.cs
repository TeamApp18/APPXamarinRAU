using projectmvvm.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectmvvm.Page_Details
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Fruit_Details : ContentPage
	{
		public Fruit_Details (classFruit fruit)
		{
			InitializeComponent ();
            Details_ImageFruit.Source = fruit.Fruit_Image;
            Details_NameFruit.Text = fruit.Fruit_Name;
            Details_DescribeFruit.Text = fruit.Fruit_Describes;
            Details_PriceFruit.Text = fruit.Fruit_Price;
            Details_PointFruit.Text = fruit.Fruit_Point;
            Details_IdFruit.Text = fruit.Fruit_Id;
            Details_InventoryFruit.Text = fruit.Fruit_Inventory;
        }
	}
}