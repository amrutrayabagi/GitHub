using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace VSMBridgePattern
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly Radio _radio;

        public MainPage()
        {
            this.InitializeComponent();
            _radio = new CarRadio();
            RadioDetails.DataContext = _radio;
            PowerDetails.DataContext = _radio;
        }

        private void LoadTuners()
        {
            var tuners = new Dictionary<string, IRadioTuner>()
                {
                    { "FM", new FmTuner()},
                    {"XM", new XmTuner()}
                };
            Stations.ItemsSource = tuners;
            Stations.SelectedIndex = 0;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           LoadTuners();
        }

        private void On_Click(object sender, RoutedEventArgs e)
        {
            _radio.On();
            RadioDetails.Visibility = Visibility.Visible;
        }

        private void Off_Click(object sender, RoutedEventArgs e)
        {
            _radio.Off();
            RadioDetails.Visibility = Visibility.Collapsed;
        }

        private void Tune_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(Station.Text))
                _radio.TuneToChannel(float.Parse(Station.Text));
        }

        private void Stations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _radio.RadioTuner = Stations.SelectedValue as IRadioTuner;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            _radio.NextChannel();
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            _radio.PreviousChannel();
        }
    }
}
