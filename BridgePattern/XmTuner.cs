namespace VSMBridgePattern
{
    public class XmTuner : IRadioTuner
    {
        public string StationInfo { get; private set; }
        public float StationDelta { get; private set; }
        public float CurrentStation { get; private set; }

        public XmTuner()
        {
            StationDelta = 1;
        }

        public void SetStation(float station)
        {
            CurrentStation = (int)station;
            StationInfo = string.Format("XM {0}", CurrentStation);
        }
    }
}
