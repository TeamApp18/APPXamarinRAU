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
	public partial class Tubers_Details : ContentPage
	{
		public Tubers_Details (classTubers tuber)
		{
			InitializeComponent ();
            Details_ImageTubers.Source = tuber.Tubers_Image;
            Details_NameTubers.Text = tuber.Tubers_Name;
            Details_DescribeTubers.Text = tuber.Tubers_Describes;
            Details_PriceTubers.Text = tuber.Tubers_Price;
            Details_PointTubers.Text = tuber.Tubers_Point;
            Details_IdTubers.Text = tuber.Tubers_Id;
            Details_InventoryTubers.Text = tuber.Tubers_Inventory;
        }
	}
}