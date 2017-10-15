using System;

namespace VSMBridgePattern
{
    public class FmTuner : IRadioTuner
    {
        public string StationInfo { get; private set; }
        public float CurrentStation { get; set; }
        public float StationDelta { get; private set; }

        public FmTuner()
        {
            StationDelta = 0.1f;
        }

        public void SetStation(float station)
        {
            CurrentStation = (float)Math.Round(station, 1);
            StationInfo = string.Format("{0} FM", CurrentStation);
        }
    }
}
