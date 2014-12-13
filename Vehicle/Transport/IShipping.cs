namespace Vehicle.Transport
{
    public interface IShipping
    {
        int ComfortLevel { get; }
        int GetCost(int totalKm);
    }
}