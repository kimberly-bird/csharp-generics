namespace garys_generics
{
    public interface IGasPowered
    {
        double FuelCapacity { get; set; }

        string Name {get; set;}
        void RefuelTank ();
    }
}
