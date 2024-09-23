public class UnitConverter
{
    private double unit;

    public UnitConverter(double unit)
    {
        this.unit = unit;
    }

    public double MetersToFeet()
    {
        return unit * 3.28084;
    }
    public double MetersToCentimeters()
    {
        return unit * 100;
    }
    public double MetersToInches()
    {
        return unit * 39.3701;
    }
    public double FeetToMeters()
    {
        return unit * 0.3048;
    }
    public double CentimetersToMeters()
    {
        return unit / 100;
    }
}