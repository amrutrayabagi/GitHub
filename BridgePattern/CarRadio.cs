using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VSMBridgePattern
{
    public class CarRadio : Radio, INotifyPropertyChanged
    {
        private string _radioStatus;
        public override string RadioStatus
        {
            get { return _radioStatus; }
            protected set
            {
                if (_radioStatus == value) return;
                _radioStatus = value;
                NotifyPropertyChanged();
            }
        }

        private string _powerStatus;
        public override string PowerStatus
        {
            get { return _powerStatus; }
            protected set
            {
                if (_powerStatus == value) return;
                _powerStatus = value;
                NotifyPropertyChanged();
            }
        }

        public override void On()
        {
            Enabled = true;
            PowerStatus = "Welcome";
        }

        public override void Off()
        {
            Enabled = false;
            PowerStatus = "Goodbye";
        }

        public override void TuneToChannel(float channel)
        {
            base.TuneToChannel(channel);
            RadioStatus = RadioTuner.StationInfo;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
