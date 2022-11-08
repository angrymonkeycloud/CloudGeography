using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryMonkey.Cloud;
public partial class CloudGeographyClient
{
    public class TimeZonesMethods
    {
        private CloudGeographyClient Client { get; set; }
        internal TimeZonesMethods(CloudGeographyClient client) => Client = client;
        public DateTime GetCurrentTimeByZoneId(string ZoneId)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById(ZoneId));
        }
        public DateTime ConvertTimeByZoneId(DateTime dateTime, string fromZoneId, string toZoneId)
        {
            return TimeZoneInfo.ConvertTime(dateTime, TimeZoneInfo.FindSystemTimeZoneById(fromZoneId), TimeZoneInfo.FindSystemTimeZoneById(toZoneId));
        }
        public ReadOnlyCollection<TimeZoneInfo> GetAllTimeZones()
        {
            return TimeZoneInfo.GetSystemTimeZones();
        }
    }
}
