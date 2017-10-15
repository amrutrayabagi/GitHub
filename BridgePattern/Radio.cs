namespace VSMBridgePattern
{
    public abstract class Radio
    {
      
        public IRadioTuner RadioTuner { get; set; }
        protected float _currentChannel;
        public virtual string RadioStatus { get; protected set; }
        public virtual string PowerStatus { get; protected set; }
        public virtual bool Enabled { get; protected set; }

        public abstract void On();
        public abstract void Off();

        public virtual void TuneToChannel(float channel)
        {
            RadioTuner.SetStation(channel);
            _currentChannel = channel;
        }

        public virtual void NextChannel()
        {
            _currentChannel += RadioTuner.StationDelta;
           TuneToChannel(_currentChannel);
        }

        public virtual void PreviousChannel()
        {
            _currentChannel -= RadioTuner.StationDelta;
            TuneToChannel(_currentChannel);
        }
    }
}
