using AngryMonkey.Cloud.Geography;
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

        public List<TimeZoneInfo> Get(params string[] timeZoneCodes) => timeZoneCodes.Any() ? TimeZoneInfo.GetSystemTimeZones().ToList().Where(TimeZone => timeZoneCodes.Any(key => key == TimeZone.Id) ).ToList() : TimeZoneInfo.GetSystemTimeZones().ToList();

        public DateTime GetDateTime(string timeZoneId) => TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById(timeZoneId));

        public DateTime GetDateTime(DateTime dateTime, string timeZoneId) => TimeZoneInfo.ConvertTimeFromUtc(dateTime, TimeZoneInfo.FindSystemTimeZoneById(timeZoneId));

        public DateTime GetDateTime(DateTime dateTime, string fromTimeZoneId, string toTimeZoneId) => TimeZoneInfo.ConvertTime(dateTime, TimeZoneInfo.FindSystemTimeZoneById(fromTimeZoneId), TimeZoneInfo.FindSystemTimeZoneById(toTimeZoneId));


    }
}
