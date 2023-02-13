namespace AngryMonkey.Cloud.Geography;

public class Coordinate
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public Coordinate(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }
    private static char StringifySeparator { get; set; } = ',';

    public static Coordinate? Parse(string value)
    {
        if (string.IsNullOrEmpty(value))
            return null;

        string[] values = value.Split(StringifySeparator);

        return new Coordinate(double.Parse(values[0]), double.Parse(values[1]));
    }

    public override string ToString() => $"{Latitude}{StringifySeparator}{Longitude}";

    public double CalculateDistance(Coordinate targetCoordinate, DistanceUnit distanceUnit)
        => CalculateDistance(new Coordinate(Latitude, Longitude), targetCoordinate, distanceUnit);

    public static double CalculateDistance(Coordinate baseCoordinate, Coordinate end, DistanceUnit distanceUnit)
    {
        var distanceUnitValue = distanceUnit switch
        {
            DistanceUnit.NauticalMiles => 3440.07,
            DistanceUnit.Miles => 3958.8,
            DistanceUnit.Kilometers => 6371.0,
            _ => throw new NotImplementedException(),
        };

        double startLatitude = DegreesToRadians(baseCoordinate.Latitude);
        double startLongitude = DegreesToRadians(baseCoordinate.Longitude);
        double endLatitude = DegreesToRadians(end.Latitude);
        double endLongitude = DegreesToRadians(end.Longitude);

        double distance = Math.Acos(Math.Sin(startLatitude) * Math.Sin(endLatitude) +
                                    Math.Cos(startLatitude) * Math.Cos(endLatitude) *
                                    Math.Cos(startLongitude - endLongitude)) * distanceUnitValue;

        return distance;
    }

    private static double DegreesToRadians(double degrees) => (Math.PI / 180) * degrees;
}
