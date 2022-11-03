using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsUS()
    {
        AddSubdivisions("US", new List<Subdivision>()
        {
            new()
            { 
                Code = "AL",
                Type = "State",
                Name = "Alabama",
                LocalName = "Alabama"
            },
            new()
            { 
                Code = "AK",
                Type = "State",
                Name = "Alaska",
                LocalName = "Alaska"
            },
            new()
            { 
                Code = "AZ",
                Type = "State",
                Name = "Arizona",
                LocalName = "Arizona"
            },
            new()
            { 
                Code = "AR",
                Type = "State",
                Name = "Arkansas",
                LocalName = "Arkansas"
            },
            new()
            { 
                Code = "CA",
                Type = "State",
                Name = "California",
                LocalName = "California"
            },
            new()
            { 
                Code = "CO",
                Type = "State",
                Name = "Colorado",
                LocalName = "Colorado"
            },
            new()
            { 
                Code = "CT",
                Type = "State",
                Name = "Connecticut",
                LocalName = "Connecticut"
            },
            new()
            { 
                Code = "DE",
                Type = "State",
                Name = "Delaware",
                LocalName = "Delaware"
            },
            new()
            { 
                Code = "DC",
                Type = "District",
                Name = "District of Columbia",
                LocalName = "District of Columbia"
            },
            new()
            { 
                Code = "FL",
                Type = "State",
                Name = "Florida",
                LocalName = "Florida"
            },
            new()
            { 
                Code = "GA",
                Type = "State",
                Name = "Georgia",
                LocalName = "Georgia"
            },
            new()
            { 
                Code = "HI",
                Type = "State",
                Name = "Hawaii",
                LocalName = "Hawaii"
            },
            new()
            { 
                Code = "ID",
                Type = "State",
                Name = "Idaho",
                LocalName = "Idaho"
            },
            new()
            { 
                Code = "IL",
                Type = "State",
                Name = "Illinois",
                LocalName = "Illinois"
            },
            new()
            { 
                Code = "IN",
                Type = "State",
                Name = "Indiana",
                LocalName = "Indiana"
            },
            new()
            { 
                Code = "IA",
                Type = "State",
                Name = "Iowa",
                LocalName = "Iowa"
            },
            new()
            { 
                Code = "KS",
                Type = "State",
                Name = "Kansas",
                LocalName = "Kansas"
            },
            new()
            { 
                Code = "KY",
                Type = "State",
                Name = "Kentucky",
                LocalName = "Kentucky"
            },
            new()
            { 
                Code = "LA",
                Type = "State",
                Name = "Louisiana",
                LocalName = "Louisiana"
            },
            new()
            { 
                Code = "ME",
                Type = "State",
                Name = "Maine",
                LocalName = "Maine"
            },
            new()
            { 
                Code = "MD",
                Type = "State",
                Name = "Maryland",
                LocalName = "Maryland"
            },
            new()
            { 
                Code = "MA",
                Type = "State",
                Name = "Massachusetts",
                LocalName = "Massachusetts"
            },
            new()
            { 
                Code = "MI",
                Type = "State",
                Name = "Michigan",
                LocalName = "Michigan"
            },
            new()
            { 
                Code = "MN",
                Type = "State",
                Name = "Minnesota",
                LocalName = "Minnesota"
            },
            new()
            { 
                Code = "MS",
                Type = "State",
                Name = "Mississippi",
                LocalName = "Mississippi"
            },
            new()
            { 
                Code = "MO",
                Type = "State",
                Name = "Missouri",
                LocalName = "Missouri"
            },
            new()
            { 
                Code = "MT",
                Type = "State",
                Name = "Montana",
                LocalName = "Montana"
            },
            new()
            { 
                Code = "NE",
                Type = "State",
                Name = "Nebraska",
                LocalName = "Nebraska"
            },
            new()
            { 
                Code = "NV",
                Type = "State",
                Name = "Nevada",
                LocalName = "Nevada"
            },
            new()
            { 
                Code = "NH",
                Type = "State",
                Name = "New Hampshire",
                LocalName = "New Hampshire"
            },
            new()
            { 
                Code = "NJ",
                Type = "State",
                Name = "New Jersey",
                LocalName = "New Jersey"
            },
            new()
            { 
                Code = "NM",
                Type = "State",
                Name = "New Mexico",
                LocalName = "New Mexico"
            },
            new()
            { 
                Code = "NY",
                Type = "State",
                Name = "New York",
                LocalName = "New York"
            },
            new()
            { 
                Code = "NC",
                Type = "State",
                Name = "North Carolina",
                LocalName = "North Carolina"
            },
            new()
            { 
                Code = "ND",
                Type = "State",
                Name = "North Dakota",
                LocalName = "North Dakota"
            },
            new()
            { 
                Code = "OH",
                Type = "State",
                Name = "Ohio",
                LocalName = "Ohio"
            },
            new()
            { 
                Code = "OK",
                Type = "State",
                Name = "Oklahoma",
                LocalName = "Oklahoma"
            },
            new()
            { 
                Code = "OR",
                Type = "State",
                Name = "Oregon",
                LocalName = "Oregon"
            },
            new()
            { 
                Code = "PA",
                Type = "State",
                Name = "Pennsylvania",
                LocalName = "Pennsylvania"
            },
            new()
            { 
                Code = "RI",
                Type = "State",
                Name = "Rhode Island",
                LocalName = "Rhode Island"
            },
            new()
            { 
                Code = "SC",
                Type = "State",
                Name = "South Carolina",
                LocalName = "South Carolina"
            },
            new()
            { 
                Code = "SD",
                Type = "State",
                Name = "South Dakota",
                LocalName = "South Dakota"
            },
            new()
            { 
                Code = "TN",
                Type = "State",
                Name = "Tennessee",
                LocalName = "Tennessee"
            },
            new()
            { 
                Code = "TX",
                Type = "State",
                Name = "Texas",
                LocalName = "Texas"
            },
            new()
            { 
                Code = "UT",
                Type = "State",
                Name = "Utah",
                LocalName = "Utah"
            },
            new()
            { 
                Code = "VT",
                Type = "State",
                Name = "Vermont",
                LocalName = "Vermont"
            },
            new()
            { 
                Code = "VA",
                Type = "State",
                Name = "Virginia",
                LocalName = "Virginia"
            },
            new()
            { 
                Code = "WA",
                Type = "State",
                Name = "Washington",
                LocalName = "Washington"
            },
            new()
            { 
                Code = "WV",
                Type = "State",
                Name = "West Virginia",
                LocalName = "West Virginia"
            },
            new()
            { 
                Code = "WI",
                Type = "State",
                Name = "Wisconsin",
                LocalName = "Wisconsin"
            },
            new()
            { 
                Code = "WY",
                Type = "State",
                Name = "Wyoming",
                LocalName = "Wyoming"
            }

        });
    }
}
