namespace AngryMonkey.Cloud.Geography;

internal partial class BingModels
{
    internal class Address
    {
        public int BuildingNumber { get; set; }
        public int StreetNumber { get; set; }
        public List<int> RouteNumbers { get; set; }
        public string street { get; set; }
        public string streetName { get; set; }
        public string streetNameAndNumber { get; set; }
        public string countryCode { get; set; }
        public string countrySubdivision { get; set; }
        public string countrySecondarySubdivision { get; set; }
        public string municipality { get; set; }
        public int postalCode { get; set; }
        public string country { get; set; }
        public string countryCodeISO3 { get; set; }
        public string freeformAddress { get; set; }
        public AddressBoundingBox boundingBox { get; set; }
        public string localName { get; set; }
    }
}