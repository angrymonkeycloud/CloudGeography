using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGB()
    {
        AddSubdivisions("GB", new List<Subdivision>()
        {
            new()
            { 
                Code = "ABE",
                Type = "CouncilArea",
                Name = "Aberdeen City",
                LocalName = "Aberdeen City"
            },
            new()
            { 
                Code = "ABD",
                Type = "CouncilArea",
                Name = "Aberdeenshire",
                LocalName = "Aberdeenshire"
            },
            new()
            { 
                Code = "ANS",
                Type = "CouncilArea",
                Name = "Angus",
                LocalName = "Angus"
            },
            new()
            { 
                Code = "ANN",
                Type = "District",
                Name = "Antrim and Newtownabbey",
                LocalName = "Antrim and Newtownabbey"
            },
            new()
            { 
                Code = "AND",
                Type = "District",
                Name = "Ards and North Down",
                LocalName = "Ards and North Down"
            },
            new()
            { 
                Code = "AGB",
                Type = "CouncilArea",
                Name = "Argyll and Bute",
                LocalName = "Argyll and Bute"
            },
            new()
            { 
                Code = "ARM",
                Type = "CouncilArea",
                Name = "Armagh",
                LocalName = "Armagh"
            },
            new()
            { 
                Code = "ABC",
                Type = "District",
                Name = "Armagh",
                LocalName = "Armagh"
            },
            new()
            { 
                Code = "BDG",
                Type = "CouncilArea",
                Name = "Barking and Dagenham",
                LocalName = "Barking and Dagenham"
            },
            new()
            { 
                Code = "BNE",
                Type = "CouncilArea",
                Name = "Barnet",
                LocalName = "Barnet"
            },
            new()
            { 
                Code = "BNS",
                Type = "CouncilArea",
                Name = "Barnsley",
                LocalName = "Barnsley"
            },
            new()
            { 
                Code = "BAS",
                Type = "UnitaryAuthority",
                Name = "Bath and North East Somerset",
                LocalName = "Bath and North East Somerset"
            },
            new()
            { 
                Code = "BDF",
                Type = "CouncilArea",
                Name = "Bedford",
                LocalName = "Bedford"
            },
            new()
            { 
                Code = "BFS",
                Type = "District",
                Name = "Belfast",
                LocalName = "Belfast"
            },
            new()
            { 
                Code = "BEX",
                Type = "CouncilArea",
                Name = "Bexley",
                LocalName = "Bexley"
            },
            new()
            { 
                Code = "BIR",
                Type = "CouncilArea",
                Name = "Birmingham",
                LocalName = "Birmingham"
            },
            new()
            { 
                Code = "BBD",
                Type = "UnitaryAuthority",
                Name = "Blackburn with Darwen",
                LocalName = "Blackburn with Darwen"
            },
            new()
            { 
                Code = "BPL",
                Type = "UnitaryAuthority",
                Name = "Blackpool",
                LocalName = "Blackpool"
            },
            new()
            { 
                Code = "BGW",
                Type = "UnitaryAuthority",
                Name = "Blaenau Gwent",
                LocalName = "Blaenau Gwent"
            },
            new()
            { 
                Code = "BOL",
                Type = "CouncilArea",
                Name = "Bolton",
                LocalName = "Bolton"
            },
            new()
            { 
                Code = "BMH",
                Type = "UnitaryAuthority",
                Name = "Bournemouth",
                LocalName = "Bournemouth"
            },
            new()
            { 
                Code = "BRC",
                Type = "UnitaryAuthority",
                Name = "Bracknell Forest",
                LocalName = "Bracknell Forest"
            },
            new()
            { 
                Code = "BRD",
                Type = "CouncilArea",
                Name = "Bradford",
                LocalName = "Bradford"
            },
            new()
            { 
                Code = "BEN",
                Type = "CouncilArea",
                Name = "Brent",
                LocalName = "Brent"
            },
            new()
            { 
                Code = "BGE",
                Type = "UnitaryAuthority",
                Name = "Bridgend",
                LocalName = "Bridgend"
            },
            new()
            { 
                Code = "BNH",
                Type = "UnitaryAuthority",
                Name = "Brighton and Hove",
                LocalName = "Brighton and Hove"
            },
            new()
            { 
                Code = "BST",
                Type = "UnitaryAuthority",
                Name = "Bristol",
                LocalName = "Bristol"
            },
            new()
            { 
                Code = "BRY",
                Type = "CouncilArea",
                Name = "Bromley",
                LocalName = "Bromley"
            },
            new()
            { 
                Code = "BKM",
                Type = "County",
                Name = "Buckinghamshire",
                LocalName = "Buckinghamshire"
            },
            new()
            { 
                Code = "BUR",
                Type = "CouncilArea",
                Name = "Bury",
                LocalName = "Bury"
            },
            new()
            { 
                Code = "CAY",
                Type = "UnitaryAuthority",
                Name = "Caerphilly",
                LocalName = "Caerphilly"
            },
            new()
            { 
                Code = "CLD",
                Type = "CouncilArea",
                Name = "Calderdale",
                LocalName = "Calderdale"
            },
            new()
            { 
                Code = "CAM",
                Type = "County",
                Name = "Cambridgeshire",
                LocalName = "Cambridgeshire"
            },
            new()
            { 
                Code = "CMD",
                Type = "CouncilArea",
                Name = "Camden",
                LocalName = "Camden"
            },
            new()
            { 
                Code = "CRF",
                Type = "UnitaryAuthority",
                Name = "Cardiff",
                LocalName = "Cardiff"
            },
            new()
            { 
                Code = "CMN",
                Type = "UnitaryAuthority",
                Name = "Carmarthenshire",
                LocalName = "Carmarthenshire"
            },
            new()
            { 
                Code = "CCG",
                Type = "District",
                Name = "Causeway Coast and Glens",
                LocalName = "Causeway Coast and Glens"
            },
            new()
            { 
                Code = "CBF",
                Type = "UnitaryAuthority",
                Name = "Central Bedfordshire",
                LocalName = "Central Bedfordshire"
            },
            new()
            { 
                Code = "CGN",
                Type = "UnitaryAuthority",
                Name = "Ceredigion",
                LocalName = "Ceredigion"
            },
            new()
            { 
                Code = "CHE",
                Type = "UnitaryAuthority",
                Name = "Cheshire East",
                LocalName = "Cheshire East"
            },
            new()
            { 
                Code = "CHW",
                Type = "UnitaryAuthority",
                Name = "Cheshire West and Chester",
                LocalName = "Cheshire West and Chester"
            },
            new()
            { 
                Code = "CLK",
                Type = "CouncilArea",
                Name = "Clackmannanshire",
                LocalName = "Clackmannanshire"
            },
            new()
            { 
                Code = "CWY",
                Type = "UnitaryAuthority",
                Name = "Conwy",
                LocalName = "Conwy"
            },
            new()
            { 
                Code = "CON",
                Type = "UnitaryAuthority",
                Name = "Cornwall",
                LocalName = "Cornwall"
            },
            new()
            { 
                Code = "COV",
                Type = "CouncilArea",
                Name = "Coventry",
                LocalName = "Coventry"
            },
            new()
            { 
                Code = "CRY",
                Type = "CouncilArea",
                Name = "Croydon",
                LocalName = "Croydon"
            },
            new()
            { 
                Code = "CMA",
                Type = "County",
                Name = "Cumbria",
                LocalName = "Cumbria"
            },
            new()
            { 
                Code = "DAL",
                Type = "UnitaryAuthority",
                Name = "Darlington",
                LocalName = "Darlington"
            },
            new()
            { 
                Code = "DEN",
                Type = "UnitaryAuthority",
                Name = "Denbighshire",
                LocalName = "Denbighshire"
            },
            new()
            { 
                Code = "DER",
                Type = "UnitaryAuthority",
                Name = "Derby",
                LocalName = "Derby"
            },
            new()
            { 
                Code = "DBY",
                Type = "County",
                Name = "Derbyshire",
                LocalName = "Derbyshire"
            },
            new()
            { 
                Code = "DRS",
                Type = "District",
                Name = "Derry and Strabane",
                LocalName = "Derry and Strabane"
            },
            new()
            { 
                Code = "DEV",
                Type = "County",
                Name = "Devon",
                LocalName = "Devon"
            },
            new()
            { 
                Code = "DNC",
                Type = "CouncilArea",
                Name = "Doncaster",
                LocalName = "Doncaster"
            },
            new()
            { 
                Code = "DOR",
                Type = "County",
                Name = "Dorset",
                LocalName = "Dorset"
            },
            new()
            { 
                Code = "DUD",
                Type = "CouncilArea",
                Name = "Dudley",
                LocalName = "Dudley"
            },
            new()
            { 
                Code = "DGY",
                Type = "CouncilArea",
                Name = "Dumfries and Galloway",
                LocalName = "Dumfries and Galloway"
            },
            new()
            { 
                Code = "DND",
                Type = "CouncilArea",
                Name = "Dundee City",
                LocalName = "Dundee City"
            },
            new()
            { 
                Code = "DUR",
                Type = "UnitaryAuthority",
                Name = "Durham",
                LocalName = "Durham"
            },
            new()
            { 
                Code = "EAL",
                Type = "CouncilArea",
                Name = "Ealing",
                LocalName = "Ealing"
            },
            new()
            { 
                Code = "EAY",
                Type = "CouncilArea",
                Name = "East Ayrshire",
                LocalName = "East Ayrshire"
            },
            new()
            { 
                Code = "EDU",
                Type = "CouncilArea",
                Name = "East Dunbartonshire",
                LocalName = "East Dunbartonshire"
            },
            new()
            { 
                Code = "ELN",
                Type = "CouncilArea",
                Name = "East Lothian",
                LocalName = "East Lothian"
            },
            new()
            { 
                Code = "ERW",
                Type = "CouncilArea",
                Name = "East Renfrewshire",
                LocalName = "East Renfrewshire"
            },
            new()
            { 
                Code = "ERY",
                Type = "UnitaryAuthority",
                Name = "East Riding of Yorkshire",
                LocalName = "East Riding of Yorkshire"
            },
            new()
            { 
                Code = "ESX",
                Type = "County",
                Name = "East Sussex",
                LocalName = "East Sussex"
            },
            new()
            { 
                Code = "EDH",
                Type = "CouncilArea",
                Name = "Edinburgh",
                LocalName = "Edinburgh"
            },
            new()
            { 
                Code = "ELS",
                Type = "CouncilArea",
                Name = "Eilean Siar",
                LocalName = "Eilean Siar"
            },
            new()
            { 
                Code = "ENF",
                Type = "CouncilArea",
                Name = "Enfield",
                LocalName = "Enfield"
            },
            new()
            { 
                Code = "ESS",
                Type = "County",
                Name = "Essex",
                LocalName = "Essex"
            },
            new()
            { 
                Code = "FAL",
                Type = "CouncilArea",
                Name = "Falkirk",
                LocalName = "Falkirk"
            },
            new()
            { 
                Code = "FMO",
                Type = "District",
                Name = "Fermanagh and Omagh",
                LocalName = "Fermanagh and Omagh"
            },
            new()
            { 
                Code = "FIF",
                Type = "CouncilArea",
                Name = "Fife",
                LocalName = "Fife"
            },
            new()
            { 
                Code = "FLN",
                Type = "UnitaryAuthority",
                Name = "Flintshire",
                LocalName = "Flintshire"
            },
            new()
            { 
                Code = "GAT",
                Type = "CouncilArea",
                Name = "Gateshead",
                LocalName = "Gateshead"
            },
            new()
            { 
                Code = "GLG",
                Type = "CouncilArea",
                Name = "Glasgow City",
                LocalName = "Glasgow City"
            },
            new()
            { 
                Code = "GLS",
                Type = "County",
                Name = "Gloucestershire",
                LocalName = "Gloucestershire"
            },
            new()
            { 
                Code = "GRE",
                Type = "CouncilArea",
                Name = "Greenwich",
                LocalName = "Greenwich"
            },
            new()
            { 
                Code = "GWN",
                Type = "UnitaryAuthority",
                Name = "Gwynedd",
                LocalName = "Gwynedd"
            },
            new()
            { 
                Code = "HCK",
                Type = "CouncilArea",
                Name = "Hackney",
                LocalName = "Hackney"
            },
            new()
            { 
                Code = "HAL",
                Type = "UnitaryAuthority",
                Name = "Halton",
                LocalName = "Halton"
            },
            new()
            { 
                Code = "HMF",
                Type = "CouncilArea",
                Name = "Hammersmith and Fulham",
                LocalName = "Hammersmith and Fulham"
            },
            new()
            { 
                Code = "HAM",
                Type = "County",
                Name = "Hampshire",
                LocalName = "Hampshire"
            },
            new()
            { 
                Code = "HRY",
                Type = "CouncilArea",
                Name = "Haringey",
                LocalName = "Haringey"
            },
            new()
            { 
                Code = "HRW",
                Type = "CouncilArea",
                Name = "Harrow",
                LocalName = "Harrow"
            },
            new()
            { 
                Code = "HPL",
                Type = "UnitaryAuthority",
                Name = "Hartlepool",
                LocalName = "Hartlepool"
            },
            new()
            { 
                Code = "HAV",
                Type = "CouncilArea",
                Name = "Havering",
                LocalName = "Havering"
            },
            new()
            { 
                Code = "HEF",
                Type = "UnitaryAuthority",
                Name = "Herefordshire",
                LocalName = "Herefordshire"
            },
            new()
            { 
                Code = "HRT",
                Type = "County",
                Name = "Hertfordshire",
                LocalName = "Hertfordshire"
            },
            new()
            { 
                Code = "HLD",
                Type = "CouncilArea",
                Name = "Highland",
                LocalName = "Highland"
            },
            new()
            { 
                Code = "HIL",
                Type = "CouncilArea",
                Name = "Hillingdon",
                LocalName = "Hillingdon"
            },
            new()
            { 
                Code = "HNS",
                Type = "CouncilArea",
                Name = "Hounslow",
                LocalName = "Hounslow"
            },
            new()
            { 
                Code = "IVC",
                Type = "CouncilArea",
                Name = "Inverclyde",
                LocalName = "Inverclyde"
            },
            new()
            { 
                Code = "AGY",
                Type = "UnitaryAuthority",
                Name = "Isle of Anglesey",
                LocalName = "Isle of Anglesey"
            },
            new()
            { 
                Code = "IOW",
                Type = "UnitaryAuthority",
                Name = "Isle of Wight",
                LocalName = "Isle of Wight"
            },
            new()
            { 
                Code = "IOS",
                Type = "UnitaryAuthority",
                Name = "Isles of Scilly",
                LocalName = "Isles of Scilly"
            },
            new()
            { 
                Code = "ISL",
                Type = "CouncilArea",
                Name = "Islington",
                LocalName = "Islington"
            },
            new()
            { 
                Code = "KEC",
                Type = "CouncilArea",
                Name = "Kensington and Chelsea",
                LocalName = "Kensington and Chelsea"
            },
            new()
            { 
                Code = "KEN",
                Type = "County",
                Name = "Kent",
                LocalName = "Kent"
            },
            new()
            { 
                Code = "KHL",
                Type = "UnitaryAuthority",
                Name = "Kingston upon Hull",
                LocalName = "Kingston upon Hull"
            },
            new()
            { 
                Code = "KTT",
                Type = "CouncilArea",
                Name = "Kingston upon Thames",
                LocalName = "Kingston upon Thames"
            },
            new()
            { 
                Code = "KIR",
                Type = "CouncilArea",
                Name = "Kirklees",
                LocalName = "Kirklees"
            },
            new()
            { 
                Code = "KWL",
                Type = "CouncilArea",
                Name = "Knowsley",
                LocalName = "Knowsley"
            },
            new()
            { 
                Code = "LBH",
                Type = "CouncilArea",
                Name = "Lambeth",
                LocalName = "Lambeth"
            },
            new()
            { 
                Code = "LAN",
                Type = "County",
                Name = "Lancashire",
                LocalName = "Lancashire"
            },
            new()
            { 
                Code = "LDS",
                Type = "CouncilArea",
                Name = "Leeds",
                LocalName = "Leeds"
            },
            new()
            { 
                Code = "LCE",
                Type = "UnitaryAuthority",
                Name = "Leicester",
                LocalName = "Leicester"
            },
            new()
            { 
                Code = "LEC",
                Type = "County",
                Name = "Leicestershire",
                LocalName = "Leicestershire"
            },
            new()
            { 
                Code = "LEW",
                Type = "CouncilArea",
                Name = "Lewisham",
                LocalName = "Lewisham"
            },
            new()
            { 
                Code = "LIN",
                Type = "County",
                Name = "Lincolnshire",
                LocalName = "Lincolnshire"
            },
            new()
            { 
                Code = "LBC",
                Type = "District",
                Name = "Lisburn and Castlereagh",
                LocalName = "Lisburn and Castlereagh"
            },
            new()
            { 
                Code = "LIV",
                Type = "CouncilArea",
                Name = "Liverpool",
                LocalName = "Liverpool"
            },
            new()
            { 
                Code = "LND",
                Type = "City",
                Name = "London",
                LocalName = "London"
            },
            new()
            { 
                Code = "LUT",
                Type = "UnitaryAuthority",
                Name = "Luton",
                LocalName = "Luton"
            },
            new()
            { 
                Code = "MAN",
                Type = "CouncilArea",
                Name = "Manchester",
                LocalName = "Manchester"
            },
            new()
            { 
                Code = "MDW",
                Type = "UnitaryAuthority",
                Name = "Medway",
                LocalName = "Medway"
            },
            new()
            { 
                Code = "MTY",
                Type = "UnitaryAuthority",
                Name = "Merthyr Tydfil",
                LocalName = "Merthyr Tydfil"
            },
            new()
            { 
                Code = "MRT",
                Type = "CouncilArea",
                Name = "Merton",
                LocalName = "Merton"
            },
            new()
            { 
                Code = "MEA",
                Type = "District",
                Name = "Mid and East Antrim",
                LocalName = "Mid and East Antrim"
            },
            new()
            { 
                Code = "MUL",
                Type = "District",
                Name = "Mid Ulster",
                LocalName = "Mid Ulster"
            },
            new()
            { 
                Code = "MDB",
                Type = "UnitaryAuthority",
                Name = "Middlesbrough",
                LocalName = "Middlesbrough"
            },
            new()
            { 
                Code = "MLN",
                Type = "CouncilArea",
                Name = "Midlothian",
                LocalName = "Midlothian"
            },
            new()
            { 
                Code = "MIK",
                Type = "UnitaryAuthority",
                Name = "Milton Keynes",
                LocalName = "Milton Keynes"
            },
            new()
            { 
                Code = "MON",
                Type = "UnitaryAuthority",
                Name = "Monmouthshire",
                LocalName = "Monmouthshire"
            },
            new()
            { 
                Code = "MRY",
                Type = "CouncilArea",
                Name = "Moray",
                LocalName = "Moray"
            },
            new()
            { 
                Code = "NTL",
                Type = "UnitaryAuthority",
                Name = "Neath Port Talbot",
                LocalName = "Neath Port Talbot"
            },
            new()
            { 
                Code = "NET",
                Type = "CouncilArea",
                Name = "Newcastle upon Tyne",
                LocalName = "Newcastle upon Tyne"
            },
            new()
            { 
                Code = "NWM",
                Type = "CouncilArea",
                Name = "Newham",
                LocalName = "Newham"
            },
            new()
            { 
                Code = "NWP",
                Type = "UnitaryAuthority",
                Name = "Newport",
                LocalName = "Newport"
            },
            new()
            { 
                Code = "NMD",
                Type = "District",
                Name = "Newry",
                LocalName = "Newry"
            },
            new()
            { 
                Code = "NFK",
                Type = "County",
                Name = "Norfolk",
                LocalName = "Norfolk"
            },
            new()
            { 
                Code = "NAY",
                Type = "CouncilArea",
                Name = "North Ayrshire",
                LocalName = "North Ayrshire"
            },
            new()
            { 
                Code = "NEL",
                Type = "UnitaryAuthority",
                Name = "North East Lincolnshire",
                LocalName = "North East Lincolnshire"
            },
            new()
            { 
                Code = "NLK",
                Type = "CouncilArea",
                Name = "North Lanarkshire",
                LocalName = "North Lanarkshire"
            },
            new()
            { 
                Code = "NLN",
                Type = "UnitaryAuthority",
                Name = "North Lincolnshire",
                LocalName = "North Lincolnshire"
            },
            new()
            { 
                Code = "NSM",
                Type = "UnitaryAuthority",
                Name = "North Somerset",
                LocalName = "North Somerset"
            },
            new()
            { 
                Code = "NTY",
                Type = "CouncilArea",
                Name = "North Tyneside",
                LocalName = "North Tyneside"
            },
            new()
            { 
                Code = "NYK",
                Type = "County",
                Name = "North Yorkshire",
                LocalName = "North Yorkshire"
            },
            new()
            { 
                Code = "NTH",
                Type = "County",
                Name = "Northamptonshire",
                LocalName = "Northamptonshire"
            },
            new()
            { 
                Code = "NBL",
                Type = "UnitaryAuthority",
                Name = "Northumberland",
                LocalName = "Northumberland"
            },
            new()
            { 
                Code = "NGM",
                Type = "UnitaryAuthority",
                Name = "Nottingham",
                LocalName = "Nottingham"
            },
            new()
            { 
                Code = "NTT",
                Type = "County",
                Name = "Nottinghamshire",
                LocalName = "Nottinghamshire"
            },
            new()
            { 
                Code = "OLD",
                Type = "CouncilArea",
                Name = "Oldham",
                LocalName = "Oldham"
            },
            new()
            { 
                Code = "ORK",
                Type = "CouncilArea",
                Name = "Orkney Islands",
                LocalName = "Orkney Islands"
            },
            new()
            { 
                Code = "OXF",
                Type = "County",
                Name = "Oxfordshire",
                LocalName = "Oxfordshire"
            },
            new()
            { 
                Code = "PEM",
                Type = "UnitaryAuthority",
                Name = "Pembrokeshire",
                LocalName = "Pembrokeshire"
            },
            new()
            { 
                Code = "PKN",
                Type = "CouncilArea",
                Name = "Perth and Kinross",
                LocalName = "Perth and Kinross"
            },
            new()
            { 
                Code = "PTE",
                Type = "UnitaryAuthority",
                Name = "Peterborough",
                LocalName = "Peterborough"
            },
            new()
            { 
                Code = "PLY",
                Type = "UnitaryAuthority",
                Name = "Plymouth",
                LocalName = "Plymouth"
            },
            new()
            { 
                Code = "POL",
                Type = "UnitaryAuthority",
                Name = "Poole",
                LocalName = "Poole"
            },
            new()
            { 
                Code = "POR",
                Type = "UnitaryAuthority",
                Name = "Portsmouth",
                LocalName = "Portsmouth"
            },
            new()
            { 
                Code = "POW",
                Type = "UnitaryAuthority",
                Name = "Powys",
                LocalName = "Powys"
            },
            new()
            { 
                Code = "RDG",
                Type = "UnitaryAuthority",
                Name = "Reading",
                LocalName = "Reading"
            },
            new()
            { 
                Code = "RDB",
                Type = "CouncilArea",
                Name = "Redbridge",
                LocalName = "Redbridge"
            },
            new()
            { 
                Code = "RCC",
                Type = "UnitaryAuthority",
                Name = "Redcar and Cleveland",
                LocalName = "Redcar and Cleveland"
            },
            new()
            { 
                Code = "RFW",
                Type = "CouncilArea",
                Name = "Renfrewshire",
                LocalName = "Renfrewshire"
            },
            new()
            { 
                Code = "RCT",
                Type = "UnitaryAuthority",
                Name = "Rhondda",
                LocalName = "Rhondda"
            },
            new()
            { 
                Code = "RIC",
                Type = "CouncilArea",
                Name = "Richmond upon Thames",
                LocalName = "Richmond upon Thames"
            },
            new()
            { 
                Code = "RCH",
                Type = "CouncilArea",
                Name = "Rochdale",
                LocalName = "Rochdale"
            },
            new()
            { 
                Code = "ROT",
                Type = "CouncilArea",
                Name = "Rotherham",
                LocalName = "Rotherham"
            },
            new()
            { 
                Code = "RUT",
                Type = "UnitaryAuthority",
                Name = "Rutland",
                LocalName = "Rutland"
            },
            new()
            { 
                Code = "SLF",
                Type = "CouncilArea",
                Name = "Salford",
                LocalName = "Salford"
            },
            new()
            { 
                Code = "SAW",
                Type = "CouncilArea",
                Name = "Sandwell",
                LocalName = "Sandwell"
            },
            new()
            { 
                Code = "SCB",
                Type = "CouncilArea",
                Name = "Scottish Borders",
                LocalName = "Scottish Borders"
            },
            new()
            { 
                Code = "SFT",
                Type = "CouncilArea",
                Name = "Sefton",
                LocalName = "Sefton"
            },
            new()
            { 
                Code = "SHF",
                Type = "CouncilArea",
                Name = "Sheffield",
                LocalName = "Sheffield"
            },
            new()
            { 
                Code = "ZET",
                Type = "CouncilArea",
                Name = "Shetland Islands",
                LocalName = "Shetland Islands"
            },
            new()
            { 
                Code = "SHR",
                Type = "UnitaryAuthority",
                Name = "Shropshire",
                LocalName = "Shropshire"
            },
            new()
            { 
                Code = "SLG",
                Type = "UnitaryAuthority",
                Name = "Slough",
                LocalName = "Slough"
            },
            new()
            { 
                Code = "SOL",
                Type = "CouncilArea",
                Name = "Solihull",
                LocalName = "Solihull"
            },
            new()
            { 
                Code = "SOM",
                Type = "County",
                Name = "Somerset",
                LocalName = "Somerset"
            },
            new()
            { 
                Code = "SAY",
                Type = "CouncilArea",
                Name = "South Ayrshire",
                LocalName = "South Ayrshire"
            },
            new()
            { 
                Code = "SGC",
                Type = "UnitaryAuthority",
                Name = "South Gloucestershire",
                LocalName = "South Gloucestershire"
            },
            new()
            { 
                Code = "SLK",
                Type = "CouncilArea",
                Name = "South Lanarkshire",
                LocalName = "South Lanarkshire"
            },
            new()
            { 
                Code = "STY",
                Type = "CouncilArea",
                Name = "South Tyneside",
                LocalName = "South Tyneside"
            },
            new()
            { 
                Code = "STH",
                Type = "UnitaryAuthority",
                Name = "Southampton",
                LocalName = "Southampton"
            },
            new()
            { 
                Code = "SOS",
                Type = "UnitaryAuthority",
                Name = "Southend-on-Sea",
                LocalName = "Southend-on-Sea"
            },
            new()
            { 
                Code = "SWK",
                Type = "CouncilArea",
                Name = "Southwark",
                LocalName = "Southwark"
            },
            new()
            { 
                Code = "SHN",
                Type = "CouncilArea",
                Name = "St. Helens",
                LocalName = "St. Helens"
            },
            new()
            { 
                Code = "STS",
                Type = "County",
                Name = "Staffordshire",
                LocalName = "Staffordshire"
            },
            new()
            { 
                Code = "STG",
                Type = "CouncilArea",
                Name = "Stirling",
                LocalName = "Stirling"
            },
            new()
            { 
                Code = "SKP",
                Type = "CouncilArea",
                Name = "Stockport",
                LocalName = "Stockport"
            },
            new()
            { 
                Code = "STT",
                Type = "UnitaryAuthority",
                Name = "Stockton-on-Tees",
                LocalName = "Stockton-on-Tees"
            },
            new()
            { 
                Code = "STE",
                Type = "UnitaryAuthority",
                Name = "Stoke-on-Trent",
                LocalName = "Stoke-on-Trent"
            },
            new()
            { 
                Code = "SFK",
                Type = "County",
                Name = "Suffolk",
                LocalName = "Suffolk"
            },
            new()
            { 
                Code = "SND",
                Type = "CouncilArea",
                Name = "Sunderland",
                LocalName = "Sunderland"
            },
            new()
            { 
                Code = "SRY",
                Type = "County",
                Name = "Surrey",
                LocalName = "Surrey"
            },
            new()
            { 
                Code = "STN",
                Type = "CouncilArea",
                Name = "Sutton",
                LocalName = "Sutton"
            },
            new()
            { 
                Code = "SWA",
                Type = "UnitaryAuthority",
                Name = "Swansea",
                LocalName = "Swansea"
            },
            new()
            { 
                Code = "SWD",
                Type = "UnitaryAuthority",
                Name = "Swindon",
                LocalName = "Swindon"
            },
            new()
            { 
                Code = "TAM",
                Type = "CouncilArea",
                Name = "Tameside",
                LocalName = "Tameside"
            },
            new()
            { 
                Code = "TFW",
                Type = "UnitaryAuthority",
                Name = "Telford and Wrekin",
                LocalName = "Telford and Wrekin"
            },
            new()
            { 
                Code = "THR",
                Type = "UnitaryAuthority",
                Name = "Thurrock",
                LocalName = "Thurrock"
            },
            new()
            { 
                Code = "TOB",
                Type = "UnitaryAuthority",
                Name = "Torbay",
                LocalName = "Torbay"
            },
            new()
            { 
                Code = "TOF",
                Type = "UnitaryAuthority",
                Name = "Torfaen",
                LocalName = "Torfaen"
            },
            new()
            { 
                Code = "TWH",
                Type = "CouncilArea",
                Name = "Tower Hamlets",
                LocalName = "Tower Hamlets"
            },
            new()
            { 
                Code = "TRF",
                Type = "CouncilArea",
                Name = "Trafford",
                LocalName = "Trafford"
            },
            new()
            { 
                Code = "VGL",
                Type = "UnitaryAuthority",
                Name = "Vale of Glamorgan",
                LocalName = "Vale of Glamorgan"
            },
            new()
            { 
                Code = "WKF",
                Type = "CouncilArea",
                Name = "Wakefield",
                LocalName = "Wakefield"
            },
            new()
            { 
                Code = "WLL",
                Type = "CouncilArea",
                Name = "Walsall",
                LocalName = "Walsall"
            },
            new()
            { 
                Code = "WFT",
                Type = "CouncilArea",
                Name = "Waltham Forest",
                LocalName = "Waltham Forest"
            },
            new()
            { 
                Code = "WND",
                Type = "CouncilArea",
                Name = "Wandsworth",
                LocalName = "Wandsworth"
            },
            new()
            { 
                Code = "WRT",
                Type = "UnitaryAuthority",
                Name = "Warrington",
                LocalName = "Warrington"
            },
            new()
            { 
                Code = "WAR",
                Type = "County",
                Name = "Warwickshire",
                LocalName = "Warwickshire"
            },
            new()
            { 
                Code = "WBK",
                Type = "UnitaryAuthority",
                Name = "West Berkshire",
                LocalName = "West Berkshire"
            },
            new()
            { 
                Code = "WDU",
                Type = "CouncilArea",
                Name = "West Dunbartonshire",
                LocalName = "West Dunbartonshire"
            },
            new()
            { 
                Code = "WLN",
                Type = "CouncilArea",
                Name = "West Lothian",
                LocalName = "West Lothian"
            },
            new()
            { 
                Code = "WSX",
                Type = "County",
                Name = "West Sussex",
                LocalName = "West Sussex"
            },
            new()
            { 
                Code = "WSM",
                Type = "CouncilArea",
                Name = "Westminster",
                LocalName = "Westminster"
            },
            new()
            { 
                Code = "WGN",
                Type = "CouncilArea",
                Name = "Wigan",
                LocalName = "Wigan"
            },
            new()
            { 
                Code = "WIL",
                Type = "UnitaryAuthority",
                Name = "Wiltshire",
                LocalName = "Wiltshire"
            },
            new()
            { 
                Code = "WNM",
                Type = "UnitaryAuthority",
                Name = "Windsor and Maidenhead",
                LocalName = "Windsor and Maidenhead"
            },
            new()
            { 
                Code = "WRL",
                Type = "CouncilArea",
                Name = "Wirral",
                LocalName = "Wirral"
            },
            new()
            { 
                Code = "WOK",
                Type = "UnitaryAuthority",
                Name = "Wokingham",
                LocalName = "Wokingham"
            },
            new()
            { 
                Code = "WLV",
                Type = "CouncilArea",
                Name = "Wolverhampton",
                LocalName = "Wolverhampton"
            },
            new()
            { 
                Code = "WOR",
                Type = "County",
                Name = "Worcestershire",
                LocalName = "Worcestershire"
            },
            new()
            { 
                Code = "WRX",
                Type = "UnitaryAuthority",
                Name = "Wrexham",
                LocalName = "Wrexham"
            },
            new()
            { 
                Code = "YOR",
                Type = "UnitaryAuthority",
                Name = "York",
                LocalName = "York"
            }

        });
    }
}
