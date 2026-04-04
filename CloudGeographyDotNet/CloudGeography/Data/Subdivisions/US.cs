using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsUS()
    {
        AddSubdivisions("US",
        [
            new()
            { 
                Code = "AL",
                Type = SubdivisionTypes.State,
                Name = "Alabama",
                LocalName = "Alabama"
            },
            new()
            { 
                Code = "AK",
                Type = SubdivisionTypes.State,
                Name = "Alaska",
                LocalName = "Alaska"
            },
            new()
            { 
                Code = "AZ",
                Type = SubdivisionTypes.State,
                Name = "Arizona",
                LocalName = "Arizona"
            },
            new()
            { 
                Code = "AR",
                Type = SubdivisionTypes.State,
                Name = "Arkansas",
                LocalName = "Arkansas"
            },
            new()
            { 
                Code = "CA",
                Type = SubdivisionTypes.State,
                Name = "California",
                LocalName = "California"
            },
            new()
            { 
                Code = "CO",
                Type = SubdivisionTypes.State,
                Name = "Colorado",
                LocalName = "Colorado"
            },
            new()
            { 
                Code = "CT",
                Type = SubdivisionTypes.State,
                Name = "Connecticut",
                LocalName = "Connecticut"
            },
            new()
            { 
                Code = "DE",
                Type = SubdivisionTypes.State,
                Name = "Delaware",
                LocalName = "Delaware"
            },
            new()
            { 
                Code = "DC",
                Type = SubdivisionTypes.District,
                Name = "District of Columbia",
                LocalName = "District of Columbia"
            },
            new()
            { 
                Code = "FL",
                Type = SubdivisionTypes.State,
                Name = "Florida",
                LocalName = "Florida"
            },
            new()
            { 
                Code = "GA",
                Type = SubdivisionTypes.State,
                Name = "Georgia",
                LocalName = "Georgia"
            },
            new()
            { 
                Code = "HI",
                Type = SubdivisionTypes.State,
                Name = "Hawaii",
                LocalName = "Hawaii"
            },
            new()
            { 
                Code = "ID",
                Type = SubdivisionTypes.State,
                Name = "Idaho",
                LocalName = "Idaho"
            },
            new()
            { 
                Code = "IL",
                Type = SubdivisionTypes.State,
                Name = "Illinois",
                LocalName = "Illinois"
            },
            new()
            { 
                Code = "IN",
                Type = SubdivisionTypes.State,
                Name = "Indiana",
                LocalName = "Indiana"
            },
            new()
            { 
                Code = "IA",
                Type = SubdivisionTypes.State,
                Name = "Iowa",
                LocalName = "Iowa"
            },
            new()
            { 
                Code = "KS",
                Type = SubdivisionTypes.State,
                Name = "Kansas",
                LocalName = "Kansas"
            },
            new()
            { 
                Code = "KY",
                Type = SubdivisionTypes.State,
                Name = "Kentucky",
                LocalName = "Kentucky"
            },
            new()
            { 
                Code = "LA",
                Type = SubdivisionTypes.State,
                Name = "Louisiana",
                LocalName = "Louisiana"
            },
            new()
            { 
                Code = "ME",
                Type = SubdivisionTypes.State,
                Name = "Maine",
                LocalName = "Maine"
            },
            new()
            { 
                Code = "MD",
                Type = SubdivisionTypes.State,
                Name = "Maryland",
                LocalName = "Maryland"
            },
            new()
            { 
                Code = "MA",
                Type = SubdivisionTypes.State,
                Name = "Massachusetts",
                LocalName = "Massachusetts"
            },
            new()
            { 
                Code = "MI",
                Type = SubdivisionTypes.State,
                Name = "Michigan",
                LocalName = "Michigan"
            },
            new()
            { 
                Code = "MN",
                Type = SubdivisionTypes.State,
                Name = "Minnesota",
                LocalName = "Minnesota"
            },
            new()
            { 
                Code = "MS",
                Type = SubdivisionTypes.State,
                Name = "Mississippi",
                LocalName = "Mississippi"
            },
            new()
            { 
                Code = "MO",
                Type = SubdivisionTypes.State,
                Name = "Missouri",
                LocalName = "Missouri"
            },
            new()
            { 
                Code = "MT",
                Type = SubdivisionTypes.State,
                Name = "Montana",
                LocalName = "Montana"
            },
            new()
            { 
                Code = "NE",
                Type = SubdivisionTypes.State,
                Name = "Nebraska",
                LocalName = "Nebraska"
            },
            new()
            { 
                Code = "NV",
                Type = SubdivisionTypes.State,
                Name = "Nevada",
                LocalName = "Nevada"
            },
            new()
            { 
                Code = "NH",
                Type = SubdivisionTypes.State,
                Name = "New Hampshire",
                LocalName = "New Hampshire"
            },
            new()
            { 
                Code = "NJ",
                Type = SubdivisionTypes.State,
                Name = "New Jersey",
                LocalName = "New Jersey"
            },
            new()
            { 
                Code = "NM",
                Type = SubdivisionTypes.State,
                Name = "New Mexico",
                LocalName = "New Mexico"
            },
            new()
            { 
                Code = "NY",
                Type = SubdivisionTypes.State,
                Name = "New York",
                LocalName = "New York"
            },
            new()
            { 
                Code = "NC",
                Type = SubdivisionTypes.State,
                Name = "North Carolina",
                LocalName = "North Carolina"
            },
            new()
            { 
                Code = "ND",
                Type = SubdivisionTypes.State,
                Name = "North Dakota",
                LocalName = "North Dakota"
            },
            new()
            { 
                Code = "OH",
                Type = SubdivisionTypes.State,
                Name = "Ohio",
                LocalName = "Ohio"
            },
            new()
            { 
                Code = "OK",
                Type = SubdivisionTypes.State,
                Name = "Oklahoma",
                LocalName = "Oklahoma"
            },
            new()
            { 
                Code = "OR",
                Type = SubdivisionTypes.State,
                Name = "Oregon",
                LocalName = "Oregon"
            },
            new()
            { 
                Code = "PA",
                Type = SubdivisionTypes.State,
                Name = "Pennsylvania",
                LocalName = "Pennsylvania"
            },
            new()
            { 
                Code = "RI",
                Type = SubdivisionTypes.State,
                Name = "Rhode Island",
                LocalName = "Rhode Island"
            },
            new()
            { 
                Code = "SC",
                Type = SubdivisionTypes.State,
                Name = "South Carolina",
                LocalName = "South Carolina"
            },
            new()
            { 
                Code = "SD",
                Type = SubdivisionTypes.State,
                Name = "South Dakota",
                LocalName = "South Dakota"
            },
            new()
            { 
                Code = "TN",
                Type = SubdivisionTypes.State,
                Name = "Tennessee",
                LocalName = "Tennessee"
            },
            new()
            { 
                Code = "TX",
                Type = SubdivisionTypes.State,
                Name = "Texas",
                LocalName = "Texas"
            },
            new()
            { 
                Code = "UT",
                Type = SubdivisionTypes.State,
                Name = "Utah",
                LocalName = "Utah"
            },
            new()
            { 
                Code = "VT",
                Type = SubdivisionTypes.State,
                Name = "Vermont",
                LocalName = "Vermont"
            },
            new()
            { 
                Code = "VA",
                Type = SubdivisionTypes.State,
                Name = "Virginia",
                LocalName = "Virginia"
            },
            new()
            { 
                Code = "WA",
                Type = SubdivisionTypes.State,
                Name = "Washington",
                LocalName = "Washington"
            },
            new()
            { 
                Code = "WV",
                Type = SubdivisionTypes.State,
                Name = "West Virginia",
                LocalName = "West Virginia"
            },
            new()
            { 
                Code = "WI",
                Type = SubdivisionTypes.State,
                Name = "Wisconsin",
                LocalName = "Wisconsin"
            },
            new()
            { 
                Code = "WY",
                Type = SubdivisionTypes.State,
                Name = "Wyoming",
                LocalName = "Wyoming"
            }

        ]);
    }
}
