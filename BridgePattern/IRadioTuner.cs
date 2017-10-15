namespace VSMBridgePattern
{
    public interface IRadioTuner
    {
        string StationInfo { get; }
        float StationDelta { get; }
        void SetStation(float station);
    }
}
