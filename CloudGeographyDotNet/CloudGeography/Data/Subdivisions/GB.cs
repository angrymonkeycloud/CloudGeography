using AngryMonkey.Cloud.Geography;
namespace AngryMonkey.Cloud;

public partial class CloudGeographyClient
{
    private static void FillInSubdivisionsGB()
    {
        AddSubdivisions("GB",
        [
            new()
            { 
                Code = "ABE",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Aberdeen City",
                LocalName = "Aberdeen City"
            },
            new()
            { 
                Code = "ABD",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Aberdeenshire",
                LocalName = "Aberdeenshire"
            },
            new()
            { 
                Code = "ANS",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Angus",
                LocalName = "Angus"
            },
            new()
            { 
                Code = "ANN",
                Type = SubdivisionTypes.District,
                Name = "Antrim and Newtownabbey",
                LocalName = "Antrim and Newtownabbey"
            },
            new()
            { 
                Code = "AND",
                Type = SubdivisionTypes.District,
                Name = "Ards and North Down",
                LocalName = "Ards and North Down"
            },
            new()
            { 
                Code = "AGB",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Argyll and Bute",
                LocalName = "Argyll and Bute"
            },
            new()
            { 
                Code = "ARM",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Armagh",
                LocalName = "Armagh"
            },
            new()
            { 
                Code = "ABC",
                Type = SubdivisionTypes.District,
                Name = "Armagh",
                LocalName = "Armagh"
            },
            new()
            { 
                Code = "BDG",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Barking and Dagenham",
                LocalName = "Barking and Dagenham"
            },
            new()
            { 
                Code = "BNE",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Barnet",
                LocalName = "Barnet"
            },
            new()
            { 
                Code = "BNS",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Barnsley",
                LocalName = "Barnsley"
            },
            new()
            { 
                Code = "BAS",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Bath and North East Somerset",
                LocalName = "Bath and North East Somerset"
            },
            new()
            { 
                Code = "BDF",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Bedford",
                LocalName = "Bedford"
            },
            new()
            { 
                Code = "BFS",
                Type = SubdivisionTypes.District,
                Name = "Belfast",
                LocalName = "Belfast"
            },
            new()
            { 
                Code = "BEX",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Bexley",
                LocalName = "Bexley"
            },
            new()
            { 
                Code = "BIR",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Birmingham",
                LocalName = "Birmingham"
            },
            new()
            { 
                Code = "BBD",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Blackburn with Darwen",
                LocalName = "Blackburn with Darwen"
            },
            new()
            { 
                Code = "BPL",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Blackpool",
                LocalName = "Blackpool"
            },
            new()
            { 
                Code = "BGW",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Blaenau Gwent",
                LocalName = "Blaenau Gwent"
            },
            new()
            { 
                Code = "BOL",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Bolton",
                LocalName = "Bolton"
            },
            new()
            { 
                Code = "BMH",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Bournemouth",
                LocalName = "Bournemouth"
            },
            new()
            { 
                Code = "BRC",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Bracknell Forest",
                LocalName = "Bracknell Forest"
            },
            new()
            { 
                Code = "BRD",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Bradford",
                LocalName = "Bradford"
            },
            new()
            { 
                Code = "BEN",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Brent",
                LocalName = "Brent"
            },
            new()
            { 
                Code = "BGE",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Bridgend",
                LocalName = "Bridgend"
            },
            new()
            { 
                Code = "BNH",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Brighton and Hove",
                LocalName = "Brighton and Hove"
            },
            new()
            { 
                Code = "BST",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Bristol",
                LocalName = "Bristol"
            },
            new()
            { 
                Code = "BRY",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Bromley",
                LocalName = "Bromley"
            },
            new()
            { 
                Code = "BKM",
                Type = SubdivisionTypes.County,
                Name = "Buckinghamshire",
                LocalName = "Buckinghamshire"
            },
            new()
            { 
                Code = "BUR",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Bury",
                LocalName = "Bury"
            },
            new()
            { 
                Code = "CAY",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Caerphilly",
                LocalName = "Caerphilly"
            },
            new()
            { 
                Code = "CLD",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Calderdale",
                LocalName = "Calderdale"
            },
            new()
            { 
                Code = "CAM",
                Type = SubdivisionTypes.County,
                Name = "Cambridgeshire",
                LocalName = "Cambridgeshire"
            },
            new()
            { 
                Code = "CMD",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Camden",
                LocalName = "Camden"
            },
            new()
            { 
                Code = "CRF",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Cardiff",
                LocalName = "Cardiff"
            },
            new()
            { 
                Code = "CMN",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Carmarthenshire",
                LocalName = "Carmarthenshire"
            },
            new()
            { 
                Code = "CCG",
                Type = SubdivisionTypes.District,
                Name = "Causeway Coast and Glens",
                LocalName = "Causeway Coast and Glens"
            },
            new()
            { 
                Code = "CBF",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Central Bedfordshire",
                LocalName = "Central Bedfordshire"
            },
            new()
            { 
                Code = "CGN",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Ceredigion",
                LocalName = "Ceredigion"
            },
            new()
            { 
                Code = "CHE",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Cheshire East",
                LocalName = "Cheshire East"
            },
            new()
            { 
                Code = "CHW",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Cheshire West and Chester",
                LocalName = "Cheshire West and Chester"
            },
            new()
            { 
                Code = "CLK",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Clackmannanshire",
                LocalName = "Clackmannanshire"
            },
            new()
            { 
                Code = "CWY",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Conwy",
                LocalName = "Conwy"
            },
            new()
            { 
                Code = "CON",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Cornwall",
                LocalName = "Cornwall"
            },
            new()
            { 
                Code = "COV",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Coventry",
                LocalName = "Coventry"
            },
            new()
            { 
                Code = "CRY",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Croydon",
                LocalName = "Croydon"
            },
            new()
            { 
                Code = "CMA",
                Type = SubdivisionTypes.County,
                Name = "Cumbria",
                LocalName = "Cumbria"
            },
            new()
            { 
                Code = "DAL",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Darlington",
                LocalName = "Darlington"
            },
            new()
            { 
                Code = "DEN",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Denbighshire",
                LocalName = "Denbighshire"
            },
            new()
            { 
                Code = "DER",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Derby",
                LocalName = "Derby"
            },
            new()
            { 
                Code = "DBY",
                Type = SubdivisionTypes.County,
                Name = "Derbyshire",
                LocalName = "Derbyshire"
            },
            new()
            { 
                Code = "DRS",
                Type = SubdivisionTypes.District,
                Name = "Derry and Strabane",
                LocalName = "Derry and Strabane"
            },
            new()
            { 
                Code = "DEV",
                Type = SubdivisionTypes.County,
                Name = "Devon",
                LocalName = "Devon"
            },
            new()
            { 
                Code = "DNC",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Doncaster",
                LocalName = "Doncaster"
            },
            new()
            { 
                Code = "DOR",
                Type = SubdivisionTypes.County,
                Name = "Dorset",
                LocalName = "Dorset"
            },
            new()
            { 
                Code = "DUD",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Dudley",
                LocalName = "Dudley"
            },
            new()
            { 
                Code = "DGY",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Dumfries and Galloway",
                LocalName = "Dumfries and Galloway"
            },
            new()
            { 
                Code = "DND",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Dundee City",
                LocalName = "Dundee City"
            },
            new()
            { 
                Code = "DUR",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Durham",
                LocalName = "Durham"
            },
            new()
            { 
                Code = "EAL",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Ealing",
                LocalName = "Ealing"
            },
            new()
            { 
                Code = "EAY",
                Type = SubdivisionTypes.CouncilArea,
                Name = "East Ayrshire",
                LocalName = "East Ayrshire"
            },
            new()
            { 
                Code = "EDU",
                Type = SubdivisionTypes.CouncilArea,
                Name = "East Dunbartonshire",
                LocalName = "East Dunbartonshire"
            },
            new()
            { 
                Code = "ELN",
                Type = SubdivisionTypes.CouncilArea,
                Name = "East Lothian",
                LocalName = "East Lothian"
            },
            new()
            { 
                Code = "ERW",
                Type = SubdivisionTypes.CouncilArea,
                Name = "East Renfrewshire",
                LocalName = "East Renfrewshire"
            },
            new()
            { 
                Code = "ERY",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "East Riding of Yorkshire",
                LocalName = "East Riding of Yorkshire"
            },
            new()
            { 
                Code = "ESX",
                Type = SubdivisionTypes.County,
                Name = "East Sussex",
                LocalName = "East Sussex"
            },
            new()
            { 
                Code = "EDH",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Edinburgh",
                LocalName = "Edinburgh"
            },
            new()
            { 
                Code = "ELS",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Eilean Siar",
                LocalName = "Eilean Siar"
            },
            new()
            { 
                Code = "ENF",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Enfield",
                LocalName = "Enfield"
            },
            new()
            { 
                Code = "ESS",
                Type = SubdivisionTypes.County,
                Name = "Essex",
                LocalName = "Essex"
            },
            new()
            { 
                Code = "FAL",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Falkirk",
                LocalName = "Falkirk"
            },
            new()
            { 
                Code = "FMO",
                Type = SubdivisionTypes.District,
                Name = "Fermanagh and Omagh",
                LocalName = "Fermanagh and Omagh"
            },
            new()
            { 
                Code = "FIF",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Fife",
                LocalName = "Fife"
            },
            new()
            { 
                Code = "FLN",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Flintshire",
                LocalName = "Flintshire"
            },
            new()
            { 
                Code = "GAT",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Gateshead",
                LocalName = "Gateshead"
            },
            new()
            { 
                Code = "GLG",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Glasgow City",
                LocalName = "Glasgow City"
            },
            new()
            { 
                Code = "GLS",
                Type = SubdivisionTypes.County,
                Name = "Gloucestershire",
                LocalName = "Gloucestershire"
            },
            new()
            { 
                Code = "GRE",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Greenwich",
                LocalName = "Greenwich"
            },
            new()
            { 
                Code = "GWN",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Gwynedd",
                LocalName = "Gwynedd"
            },
            new()
            { 
                Code = "HCK",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Hackney",
                LocalName = "Hackney"
            },
            new()
            { 
                Code = "HAL",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Halton",
                LocalName = "Halton"
            },
            new()
            { 
                Code = "HMF",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Hammersmith and Fulham",
                LocalName = "Hammersmith and Fulham"
            },
            new()
            { 
                Code = "HAM",
                Type = SubdivisionTypes.County,
                Name = "Hampshire",
                LocalName = "Hampshire"
            },
            new()
            { 
                Code = "HRY",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Haringey",
                LocalName = "Haringey"
            },
            new()
            { 
                Code = "HRW",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Harrow",
                LocalName = "Harrow"
            },
            new()
            { 
                Code = "HPL",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Hartlepool",
                LocalName = "Hartlepool"
            },
            new()
            { 
                Code = "HAV",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Havering",
                LocalName = "Havering"
            },
            new()
            { 
                Code = "HEF",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Herefordshire",
                LocalName = "Herefordshire"
            },
            new()
            { 
                Code = "HRT",
                Type = SubdivisionTypes.County,
                Name = "Hertfordshire",
                LocalName = "Hertfordshire"
            },
            new()
            { 
                Code = "HLD",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Highland",
                LocalName = "Highland"
            },
            new()
            { 
                Code = "HIL",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Hillingdon",
                LocalName = "Hillingdon"
            },
            new()
            { 
                Code = "HNS",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Hounslow",
                LocalName = "Hounslow"
            },
            new()
            { 
                Code = "IVC",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Inverclyde",
                LocalName = "Inverclyde"
            },
            new()
            { 
                Code = "AGY",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Isle of Anglesey",
                LocalName = "Isle of Anglesey"
            },
            new()
            { 
                Code = "IOW",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Isle of Wight",
                LocalName = "Isle of Wight"
            },
            new()
            { 
                Code = "IOS",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Isles of Scilly",
                LocalName = "Isles of Scilly"
            },
            new()
            { 
                Code = "ISL",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Islington",
                LocalName = "Islington"
            },
            new()
            { 
                Code = "KEC",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Kensington and Chelsea",
                LocalName = "Kensington and Chelsea"
            },
            new()
            { 
                Code = "KEN",
                Type = SubdivisionTypes.County,
                Name = "Kent",
                LocalName = "Kent"
            },
            new()
            { 
                Code = "KHL",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Kingston upon Hull",
                LocalName = "Kingston upon Hull"
            },
            new()
            { 
                Code = "KTT",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Kingston upon Thames",
                LocalName = "Kingston upon Thames"
            },
            new()
            { 
                Code = "KIR",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Kirklees",
                LocalName = "Kirklees"
            },
            new()
            { 
                Code = "KWL",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Knowsley",
                LocalName = "Knowsley"
            },
            new()
            { 
                Code = "LBH",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Lambeth",
                LocalName = "Lambeth"
            },
            new()
            { 
                Code = "LAN",
                Type = SubdivisionTypes.County,
                Name = "Lancashire",
                LocalName = "Lancashire"
            },
            new()
            { 
                Code = "LDS",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Leeds",
                LocalName = "Leeds"
            },
            new()
            { 
                Code = "LCE",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Leicester",
                LocalName = "Leicester"
            },
            new()
            { 
                Code = "LEC",
                Type = SubdivisionTypes.County,
                Name = "Leicestershire",
                LocalName = "Leicestershire"
            },
            new()
            { 
                Code = "LEW",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Lewisham",
                LocalName = "Lewisham"
            },
            new()
            { 
                Code = "LIN",
                Type = SubdivisionTypes.County,
                Name = "Lincolnshire",
                LocalName = "Lincolnshire"
            },
            new()
            { 
                Code = "LBC",
                Type = SubdivisionTypes.District,
                Name = "Lisburn and Castlereagh",
                LocalName = "Lisburn and Castlereagh"
            },
            new()
            { 
                Code = "LIV",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Liverpool",
                LocalName = "Liverpool"
            },
            new()
            { 
                Code = "LND",
                Type = SubdivisionTypes.City,
                Name = "London",
                LocalName = "London"
            },
            new()
            { 
                Code = "LUT",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Luton",
                LocalName = "Luton"
            },
            new()
            { 
                Code = "MAN",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Manchester",
                LocalName = "Manchester"
            },
            new()
            { 
                Code = "MDW",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Medway",
                LocalName = "Medway"
            },
            new()
            { 
                Code = "MTY",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Merthyr Tydfil",
                LocalName = "Merthyr Tydfil"
            },
            new()
            { 
                Code = "MRT",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Merton",
                LocalName = "Merton"
            },
            new()
            { 
                Code = "MEA",
                Type = SubdivisionTypes.District,
                Name = "Mid and East Antrim",
                LocalName = "Mid and East Antrim"
            },
            new()
            { 
                Code = "MUL",
                Type = SubdivisionTypes.District,
                Name = "Mid Ulster",
                LocalName = "Mid Ulster"
            },
            new()
            { 
                Code = "MDB",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Middlesbrough",
                LocalName = "Middlesbrough"
            },
            new()
            { 
                Code = "MLN",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Midlothian",
                LocalName = "Midlothian"
            },
            new()
            { 
                Code = "MIK",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Milton Keynes",
                LocalName = "Milton Keynes"
            },
            new()
            { 
                Code = "MON",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Monmouthshire",
                LocalName = "Monmouthshire"
            },
            new()
            { 
                Code = "MRY",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Moray",
                LocalName = "Moray"
            },
            new()
            { 
                Code = "NTL",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Neath Port Talbot",
                LocalName = "Neath Port Talbot"
            },
            new()
            { 
                Code = "NET",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Newcastle upon Tyne",
                LocalName = "Newcastle upon Tyne"
            },
            new()
            { 
                Code = "NWM",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Newham",
                LocalName = "Newham"
            },
            new()
            { 
                Code = "NWP",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Newport",
                LocalName = "Newport"
            },
            new()
            { 
                Code = "NMD",
                Type = SubdivisionTypes.District,
                Name = "Newry",
                LocalName = "Newry"
            },
            new()
            { 
                Code = "NFK",
                Type = SubdivisionTypes.County,
                Name = "Norfolk",
                LocalName = "Norfolk"
            },
            new()
            { 
                Code = "NAY",
                Type = SubdivisionTypes.CouncilArea,
                Name = "North Ayrshire",
                LocalName = "North Ayrshire"
            },
            new()
            { 
                Code = "NEL",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "North East Lincolnshire",
                LocalName = "North East Lincolnshire"
            },
            new()
            { 
                Code = "NLK",
                Type = SubdivisionTypes.CouncilArea,
                Name = "North Lanarkshire",
                LocalName = "North Lanarkshire"
            },
            new()
            { 
                Code = "NLN",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "North Lincolnshire",
                LocalName = "North Lincolnshire"
            },
            new()
            { 
                Code = "NSM",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "North Somerset",
                LocalName = "North Somerset"
            },
            new()
            { 
                Code = "NTY",
                Type = SubdivisionTypes.CouncilArea,
                Name = "North Tyneside",
                LocalName = "North Tyneside"
            },
            new()
            { 
                Code = "NYK",
                Type = SubdivisionTypes.County,
                Name = "North Yorkshire",
                LocalName = "North Yorkshire"
            },
            new()
            { 
                Code = "NTH",
                Type = SubdivisionTypes.County,
                Name = "Northamptonshire",
                LocalName = "Northamptonshire"
            },
            new()
            { 
                Code = "NBL",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Northumberland",
                LocalName = "Northumberland"
            },
            new()
            { 
                Code = "NGM",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Nottingham",
                LocalName = "Nottingham"
            },
            new()
            { 
                Code = "NTT",
                Type = SubdivisionTypes.County,
                Name = "Nottinghamshire",
                LocalName = "Nottinghamshire"
            },
            new()
            { 
                Code = "OLD",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Oldham",
                LocalName = "Oldham"
            },
            new()
            { 
                Code = "ORK",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Orkney Islands",
                LocalName = "Orkney Islands"
            },
            new()
            { 
                Code = "OXF",
                Type = SubdivisionTypes.County,
                Name = "Oxfordshire",
                LocalName = "Oxfordshire"
            },
            new()
            { 
                Code = "PEM",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Pembrokeshire",
                LocalName = "Pembrokeshire"
            },
            new()
            { 
                Code = "PKN",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Perth and Kinross",
                LocalName = "Perth and Kinross"
            },
            new()
            { 
                Code = "PTE",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Peterborough",
                LocalName = "Peterborough"
            },
            new()
            { 
                Code = "PLY",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Plymouth",
                LocalName = "Plymouth"
            },
            new()
            { 
                Code = "POL",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Poole",
                LocalName = "Poole"
            },
            new()
            { 
                Code = "POR",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Portsmouth",
                LocalName = "Portsmouth"
            },
            new()
            { 
                Code = "POW",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Powys",
                LocalName = "Powys"
            },
            new()
            { 
                Code = "RDG",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Reading",
                LocalName = "Reading"
            },
            new()
            { 
                Code = "RDB",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Redbridge",
                LocalName = "Redbridge"
            },
            new()
            { 
                Code = "RCC",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Redcar and Cleveland",
                LocalName = "Redcar and Cleveland"
            },
            new()
            { 
                Code = "RFW",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Renfrewshire",
                LocalName = "Renfrewshire"
            },
            new()
            { 
                Code = "RCT",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Rhondda",
                LocalName = "Rhondda"
            },
            new()
            { 
                Code = "RIC",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Richmond upon Thames",
                LocalName = "Richmond upon Thames"
            },
            new()
            { 
                Code = "RCH",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Rochdale",
                LocalName = "Rochdale"
            },
            new()
            { 
                Code = "ROT",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Rotherham",
                LocalName = "Rotherham"
            },
            new()
            { 
                Code = "RUT",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Rutland",
                LocalName = "Rutland"
            },
            new()
            { 
                Code = "SLF",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Salford",
                LocalName = "Salford"
            },
            new()
            { 
                Code = "SAW",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Sandwell",
                LocalName = "Sandwell"
            },
            new()
            { 
                Code = "SCB",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Scottish Borders",
                LocalName = "Scottish Borders"
            },
            new()
            { 
                Code = "SFT",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Sefton",
                LocalName = "Sefton"
            },
            new()
            { 
                Code = "SHF",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Sheffield",
                LocalName = "Sheffield"
            },
            new()
            { 
                Code = "ZET",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Shetland Islands",
                LocalName = "Shetland Islands"
            },
            new()
            { 
                Code = "SHR",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Shropshire",
                LocalName = "Shropshire"
            },
            new()
            { 
                Code = "SLG",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Slough",
                LocalName = "Slough"
            },
            new()
            { 
                Code = "SOL",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Solihull",
                LocalName = "Solihull"
            },
            new()
            { 
                Code = "SOM",
                Type = SubdivisionTypes.County,
                Name = "Somerset",
                LocalName = "Somerset"
            },
            new()
            { 
                Code = "SAY",
                Type = SubdivisionTypes.CouncilArea,
                Name = "South Ayrshire",
                LocalName = "South Ayrshire"
            },
            new()
            { 
                Code = "SGC",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "South Gloucestershire",
                LocalName = "South Gloucestershire"
            },
            new()
            { 
                Code = "SLK",
                Type = SubdivisionTypes.CouncilArea,
                Name = "South Lanarkshire",
                LocalName = "South Lanarkshire"
            },
            new()
            { 
                Code = "STY",
                Type = SubdivisionTypes.CouncilArea,
                Name = "South Tyneside",
                LocalName = "South Tyneside"
            },
            new()
            { 
                Code = "STH",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Southampton",
                LocalName = "Southampton"
            },
            new()
            { 
                Code = "SOS",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Southend-on-Sea",
                LocalName = "Southend-on-Sea"
            },
            new()
            { 
                Code = "SWK",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Southwark",
                LocalName = "Southwark"
            },
            new()
            { 
                Code = "SHN",
                Type = SubdivisionTypes.CouncilArea,
                Name = "St. Helens",
                LocalName = "St. Helens"
            },
            new()
            { 
                Code = "STS",
                Type = SubdivisionTypes.County,
                Name = "Staffordshire",
                LocalName = "Staffordshire"
            },
            new()
            { 
                Code = "STG",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Stirling",
                LocalName = "Stirling"
            },
            new()
            { 
                Code = "SKP",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Stockport",
                LocalName = "Stockport"
            },
            new()
            { 
                Code = "STT",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Stockton-on-Tees",
                LocalName = "Stockton-on-Tees"
            },
            new()
            { 
                Code = "STE",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Stoke-on-Trent",
                LocalName = "Stoke-on-Trent"
            },
            new()
            { 
                Code = "SFK",
                Type = SubdivisionTypes.County,
                Name = "Suffolk",
                LocalName = "Suffolk"
            },
            new()
            { 
                Code = "SND",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Sunderland",
                LocalName = "Sunderland"
            },
            new()
            { 
                Code = "SRY",
                Type = SubdivisionTypes.County,
                Name = "Surrey",
                LocalName = "Surrey"
            },
            new()
            { 
                Code = "STN",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Sutton",
                LocalName = "Sutton"
            },
            new()
            { 
                Code = "SWA",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Swansea",
                LocalName = "Swansea"
            },
            new()
            { 
                Code = "SWD",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Swindon",
                LocalName = "Swindon"
            },
            new()
            { 
                Code = "TAM",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Tameside",
                LocalName = "Tameside"
            },
            new()
            { 
                Code = "TFW",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Telford and Wrekin",
                LocalName = "Telford and Wrekin"
            },
            new()
            { 
                Code = "THR",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Thurrock",
                LocalName = "Thurrock"
            },
            new()
            { 
                Code = "TOB",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Torbay",
                LocalName = "Torbay"
            },
            new()
            { 
                Code = "TOF",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Torfaen",
                LocalName = "Torfaen"
            },
            new()
            { 
                Code = "TWH",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Tower Hamlets",
                LocalName = "Tower Hamlets"
            },
            new()
            { 
                Code = "TRF",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Trafford",
                LocalName = "Trafford"
            },
            new()
            { 
                Code = "VGL",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Vale of Glamorgan",
                LocalName = "Vale of Glamorgan"
            },
            new()
            { 
                Code = "WKF",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Wakefield",
                LocalName = "Wakefield"
            },
            new()
            { 
                Code = "WLL",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Walsall",
                LocalName = "Walsall"
            },
            new()
            { 
                Code = "WFT",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Waltham Forest",
                LocalName = "Waltham Forest"
            },
            new()
            { 
                Code = "WND",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Wandsworth",
                LocalName = "Wandsworth"
            },
            new()
            { 
                Code = "WRT",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Warrington",
                LocalName = "Warrington"
            },
            new()
            { 
                Code = "WAR",
                Type = SubdivisionTypes.County,
                Name = "Warwickshire",
                LocalName = "Warwickshire"
            },
            new()
            { 
                Code = "WBK",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "West Berkshire",
                LocalName = "West Berkshire"
            },
            new()
            { 
                Code = "WDU",
                Type = SubdivisionTypes.CouncilArea,
                Name = "West Dunbartonshire",
                LocalName = "West Dunbartonshire"
            },
            new()
            { 
                Code = "WLN",
                Type = SubdivisionTypes.CouncilArea,
                Name = "West Lothian",
                LocalName = "West Lothian"
            },
            new()
            { 
                Code = "WSX",
                Type = SubdivisionTypes.County,
                Name = "West Sussex",
                LocalName = "West Sussex"
            },
            new()
            { 
                Code = "WSM",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Westminster",
                LocalName = "Westminster"
            },
            new()
            { 
                Code = "WGN",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Wigan",
                LocalName = "Wigan"
            },
            new()
            { 
                Code = "WIL",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Wiltshire",
                LocalName = "Wiltshire"
            },
            new()
            { 
                Code = "WNM",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Windsor and Maidenhead",
                LocalName = "Windsor and Maidenhead"
            },
            new()
            { 
                Code = "WRL",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Wirral",
                LocalName = "Wirral"
            },
            new()
            { 
                Code = "WOK",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Wokingham",
                LocalName = "Wokingham"
            },
            new()
            { 
                Code = "WLV",
                Type = SubdivisionTypes.CouncilArea,
                Name = "Wolverhampton",
                LocalName = "Wolverhampton"
            },
            new()
            { 
                Code = "WOR",
                Type = SubdivisionTypes.County,
                Name = "Worcestershire",
                LocalName = "Worcestershire"
            },
            new()
            { 
                Code = "WRX",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "Wrexham",
                LocalName = "Wrexham"
            },
            new()
            { 
                Code = "YOR",
                Type = SubdivisionTypes.UnitaryAuthority,
                Name = "York",
                LocalName = "York"
            }

        ]);
    }
}
