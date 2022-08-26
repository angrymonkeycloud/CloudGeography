using AngryMonkey.Cloud.Geography;

namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
	public class SubdivisionsMethods
	{
		private CloudGeographyClient Client { get; set; }

		internal SubdivisionsMethods(CloudGeographyClient client) => Client = client;

		public List<Subdivision> GetAll(string countryCode) => DeserializeModel<List<Subdivision>>($"{countryCode}-subdivisions", "subdivisions") ?? new List<Subdivision>();

		public List<Subdivision> Get(string countryCode, params string[] subdivisionCodes) => GetAll(countryCode).Where(key => subdivisionCodes.Contains(key.Code)).ToList();

		public Subdivision? Get(string countryCode, string subdivisionCode) => GetAll(countryCode).FirstOrDefault(key => key.Code.Equals(subdivisionCode.Trim(), StringComparison.OrdinalIgnoreCase));
	}
}