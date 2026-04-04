using AngryMonkey.Cloud.Geography;

namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    public class SubdivisionsMethods
    {
        private readonly CloudGeographyClient Client;

        internal SubdivisionsMethods(CloudGeographyClient client) => Client = client;

        public List<Subdivision> Get(string countryCode)
        {
            try
            {
                return SubdivisionsList[countryCode];
            }
            catch
            {
                return [];
            }
        }

        public List<Subdivision> Get(string countryCode, params string[] subdivisionCodes) => Get(countryCode).Where(key => subdivisionCodes.Any(s => key.CodeCheck(s))).ToList();

        public Subdivision? Get(string countryCode, string subdivisionCode) => Get(countryCode).FirstOrDefault(key => key.CodeCheck(subdivisionCode));

        public List<Subdivision>? GetChildren(string countryCode, string subdivisionCode)
        {
            Subdivision? subdivision = Get(countryCode, subdivisionCode);

            return subdivision?.Children;
        }

        public Subdivision? GetChild(string countryCode, string subdivisionCode, string childCode)
        {
            List<Subdivision>? children = GetChildren(countryCode, subdivisionCode);

            return children?.FirstOrDefault(key => key.CodeCheck(childCode));
        }

        public List<Subdivision> GetAll(string countryCode)
        {
            List<Subdivision> result = [];

            Flatten(Get(countryCode), result);

            return result;
        }

        private static void Flatten(List<Subdivision> subdivisions, List<Subdivision> result)
        {
            foreach (Subdivision subdivision in subdivisions)
            {
                result.Add(subdivision);

                if (subdivision.Children != null)
                    Flatten(subdivision.Children, result);
            }
        }
    }
}