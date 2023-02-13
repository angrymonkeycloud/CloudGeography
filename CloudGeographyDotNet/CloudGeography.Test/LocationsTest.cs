using AngryMonkey.Cloud.Geography;

namespace CloudGeography.Test
{
    [TestClass]
    public class LocationsTest
    {
        [TestMethod]
        public void Get_Distance_Between_Coords_Kilometers()
        {
            Coordinate firstCoords = new(1,4);
            Coordinate secondCoords = new(5, 4);

            Assert.AreEqual(444.77970657822937, firstCoords.CalculateDistance(secondCoords, DistanceUnit.Kilometers));
        }

        [TestMethod]
        public void Get_Distance_Between_Coords_Miles()
        {
            Coordinate firstCoords = new(1, 4);
            Coordinate secondCoords = new(5, 4);

            Assert.AreEqual(276.3763777118026, firstCoords.CalculateDistance(secondCoords, DistanceUnit.Miles));
        }

        [TestMethod]
        public void Get_Distance_Between_Coords_NauticalMiles()
        {
            Coordinate firstCoords = new(1, 4);
            Coordinate secondCoords = new(5, 4);

            Assert.AreEqual(240.16219199632232, firstCoords.CalculateDistance(secondCoords, DistanceUnit.NauticalMiles));
        }
    }
}