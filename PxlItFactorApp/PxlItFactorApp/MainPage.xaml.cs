using Plugin.BluetoothLE;
using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace PxlItFactorApp
{
    public partial class MainPage : ContentPage
	{
        private IScanResult scanResult;

        public MainPage()
		{
			InitializeComponent();
		}

        private void ScanButton_Clicked(object sender, EventArgs args)
        {
            CrossBleAdapter.Current.Scan().Subscribe(sr => 
            {
                Debug.WriteLine($"found: {sr.Device.Name} - {sr.Device.Uuid}");
                scanResult = sr;
            });
        }
	}
}
