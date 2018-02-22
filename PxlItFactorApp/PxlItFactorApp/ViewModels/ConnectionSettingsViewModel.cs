using MvvmHelpers;
using PxlItFactorApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PxlItFactorApp.ViewModels
{
    public class ConnectionSettingsViewModel : BaseViewModel
    {
        private ObservableRangeCollection<SensorTag> _sensorTagCollection = new ObservableRangeCollection<SensorTag>();

        public ICommand DiscoverSensorTagsCommand { get; private set; }

        public ConnectionSettingsViewModel()
        {
            Title = "Connection settings";
            Subtitle = "Connect to a SensorTag device";

            DiscoverSensorTagsCommand = new Command(DiscoverSensorTags);
        }

        public ObservableRangeCollection<SensorTag> SensorTagCollection
        {
            get
            {
                return _sensorTagCollection;
            }
            private set
            {
                _sensorTagCollection = value;
                OnPropertyChanged();
            }
        }

        private void DiscoverSensorTags()
        {
            SensorTagCollection.ReplaceRange(new List<SensorTag>()
            {
                new SensorTag
                {
                    Id = new Guid("00000000-0000-0000-0000-b0b448c0cf82"),
                    Name = "CC2650 SensorTag"
                },
                new SensorTag
                {
                    Id = new Guid("00000000-0000-0000-0000-b0b448c0cf83"),
                    Name = "CC2650 SensorTag 2"
                },
                new SensorTag
                {
                    Id = new Guid("00000000-0000-0000-0000-b0b448c0cf84"),
                    Name = "CC2650 SensorTag 3"
                }
            });
        }
    }
}
