namespace AngryMonkey.Cloud.Geography;
internal partial class BingModels
{
    internal class AddressResponse
    {
        public AddressSummary summary { get; set; }
        public List<AddressReponseList> Addresses { get; set; }
    }
}