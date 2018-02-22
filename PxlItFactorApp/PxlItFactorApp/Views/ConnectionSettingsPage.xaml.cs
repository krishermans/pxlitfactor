using PxlItFactorApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PxlItFactorApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConnectionSettingsPage : ContentPage
	{
		public ConnectionSettingsPage ()
		{
			InitializeComponent ();

            BindingContext = new ConnectionSettingsViewModel();
		}
	}
}