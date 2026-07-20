using System.Runtime.Serialization;

namespace AngryMonkey.Cloud.Geography;

public class Country
{
	public string Code { get; set; }
	public double? Area { get; set; }
	public int CallingCode { get; set; }
	public string Capital { get; set; }
	public string ThreeLettersCode { get; set; }
	public string Demonym { get; set; }
	public double? Latitude { get; set; }
	public string LocalName { get; set; }
	public double? Longitude { get; set; }
	public string Name { get; set; }
	public string ShortName { get; set; }
	public List<CountryCurrency> Currencies { get; set; }
	public List<CountryLanguage> Languages { get; set; }
    public List<CountryTimeZone> TimeZones { get; set; }


    internal bool CodeCheck(string code)
	{
		code = code.Trim().ToUpper();

		if (code.Equals("UK", StringComparison.OrdinalIgnoreCase))
			code = "GB";

		return Code == code || ThreeLettersCode == code;
	}

	internal bool NameCheck(string query)
	{
		if (string.IsNullOrWhiteSpace(query))
			return false;

		query = query.Trim();

		if (Name != null && Name.Equals(query, StringComparison.OrdinalIgnoreCase))
			return true;

		if (ShortName != null && ShortName.Equals(query, StringComparison.OrdinalIgnoreCase))
			return true;

		if (LocalName != null && LocalName.Equals(query, StringComparison.OrdinalIgnoreCase))
			return true;

		if (CodeCheck(query))
			return true;

		if (CountryAltNames.TryGetValue(Code, out List<string>? altNames))
			if (altNames.Any(alt => alt.Equals(query, StringComparison.OrdinalIgnoreCase)))
				return true;

		return false;
	}

	internal static readonly Dictionary<string, List<string>> CountryAltNames = new(StringComparer.OrdinalIgnoreCase)
	{
		["US"] = ["States", "America", "USA", "U.S.", "U.S.A.", "the States", "United States"],
		["GB"] = ["UK", "United Kingdom", "Britain", "Great Britain", "England", "U.K."],
		["AE"] = ["UAE", "U.A.E.", "Emirates"],
		["KR"] = ["South Korea", "Korea"],
		["KP"] = ["North Korea"],
		["RU"] = ["Russia"],
		["CN"] = ["China", "PRC", "P.R.C."],
		["TW"] = ["Taiwan"],
		["DE"] = ["Germany", "Deutschland"],
		["FR"] = ["France"],
		["JP"] = ["Japan"],
		["IN"] = ["India", "Bharat"],
		["BR"] = ["Brazil", "Brasil"],
		["MX"] = ["Mexico", "México"],
		["SA"] = ["Saudi Arabia", "KSA", "Saudi", "K.S.A."],
		["EG"] = ["Egypt", "Misr", "مصر"],
		["ZA"] = ["South Africa"],
		["NZ"] = ["New Zealand", "Aotearoa"],
		["CZ"] = ["Czech Republic", "Czechia"],
		["NL"] = ["Netherlands", "Holland"],
		["PH"] = ["Philippines", "Pilipinas"],
		["PS"] = ["Palestine", "فلسطين"],
		["VA"] = ["Vatican", "Holy See"],
		["CD"] = ["Congo", "DRC", "D.R.C.", "DR Congo"],
		["CG"] = ["Republic of the Congo", "Congo-Brazzaville"],
		["CI"] = ["Ivory Coast", "Côte d'Ivoire"],
		["LB"] = ["Lebanon", "Liban", "لبنان"],
		["SY"] = ["Syria", "سوريا"],
		["IQ"] = ["Iraq", "العراق"],
		["JO"] = ["Jordan", "الأردن"],
		["IR"] = ["Iran", "Persia", "ایران"],
		["TR"] = ["Turkey", "Türkiye", "Turkiye"],
		["AT"] = ["Austria", "Österreich"],
		["CH"] = ["Switzerland", "Schweiz", "Suisse", "Svizzera"],
		["BE"] = ["Belgium", "Belgique", "België"],
		["SE"] = ["Sweden", "Sverige"],
		["NO"] = ["Norway", "Norge"],
		["DK"] = ["Denmark", "Danmark"],
		["FI"] = ["Finland", "Suomi"],
		["PL"] = ["Poland", "Polska"],
		["UA"] = ["Ukraine", "Україна"],
		["GR"] = ["Greece", "Hellas", "Ελλάδα"],
		["PT"] = ["Portugal"],
		["ES"] = ["Spain", "España"],
		["IT"] = ["Italy", "Italia"],
		["RO"] = ["Romania", "România"],
		["HU"] = ["Hungary", "Magyarország"],
		["HR"] = ["Croatia", "Hrvatska"],
		["RS"] = ["Serbia", "Србија"],
		["BG"] = ["Bulgaria", "България"],
		["SK"] = ["Slovakia", "Slovensko"],
		["SI"] = ["Slovenia", "Slovenija"],
		["LT"] = ["Lithuania", "Lietuva"],
		["LV"] = ["Latvia", "Latvija"],
		["EE"] = ["Estonia", "Eesti"],
		["IS"] = ["Iceland", "Ísland"],
		["IE"] = ["Ireland", "Éire"],
		["CY"] = ["Cyprus", "Κύπρος"],
		["MT"] = ["Malta"],
		["LU"] = ["Luxembourg", "Luxemburg"],
		["KW"] = ["Kuwait", "الكويت"],
		["QA"] = ["Qatar", "قطر"],
		["BH"] = ["Bahrain", "البحرين"],
		["OM"] = ["Oman", "عمان"],
		["YE"] = ["Yemen", "اليمن"],
		["MA"] = ["Morocco", "Maroc", "المغرب"],
		["TN"] = ["Tunisia", "Tunisie", "تونس"],
		["DZ"] = ["Algeria", "Algérie", "الجزائر"],
		["LY"] = ["Libya", "ليبيا"],
		["SD"] = ["Sudan", "السودان"],
		["ET"] = ["Ethiopia"],
		["KE"] = ["Kenya"],
		["NG"] = ["Nigeria"],
		["GH"] = ["Ghana"],
		["TZ"] = ["Tanzania"],
		["TH"] = ["Thailand"],
		["VN"] = ["Vietnam", "Viet Nam"],
		["MY"] = ["Malaysia"],
		["SG"] = ["Singapore"],
		["ID"] = ["Indonesia"],
		["PK"] = ["Pakistan", "پاکستان"],
		["BD"] = ["Bangladesh", "বাংলাদেশ"],
		["LK"] = ["Sri Lanka"],
		["MM"] = ["Myanmar", "Burma"],
		["KH"] = ["Cambodia", "Kampuchea"],
		["LA"] = ["Laos"],
		["NP"] = ["Nepal"],
		["AF"] = ["Afghanistan"],
		["AU"] = ["Australia"],
		["CA"] = ["Canada"],
		["AR"] = ["Argentina"],
		["CL"] = ["Chile"],
		["CO"] = ["Colombia"],
		["PE"] = ["Peru", "Perú"],
		["VE"] = ["Venezuela"],
		["EC"] = ["Ecuador"],
		["UY"] = ["Uruguay"],
		["PY"] = ["Paraguay"],
		["BO"] = ["Bolivia"],
		["CU"] = ["Cuba"],
		["DO"] = ["Dominican Republic"],
		["HT"] = ["Haiti", "Haïti"],
		["JM"] = ["Jamaica"],
		["TT"] = ["Trinidad and Tobago", "Trinidad"],
		["PA"] = ["Panama", "Panamá"],
		["CR"] = ["Costa Rica"],
		["GT"] = ["Guatemala"],
		["HN"] = ["Honduras"],
		["SV"] = ["El Salvador"],
		["NI"] = ["Nicaragua"],
		["BZ"] = ["Belize"],
		["GY"] = ["Guyana"],
		["SR"] = ["Suriname"],
		["MN"] = ["Mongolia"],
		["KZ"] = ["Kazakhstan"],
		["UZ"] = ["Uzbekistan"],
		["TM"] = ["Turkmenistan"],
		["KG"] = ["Kyrgyzstan"],
		["TJ"] = ["Tajikistan"],
		["AZ"] = ["Azerbaijan"],
		["GE"] = ["Georgia", "საქართველო"],
		["AM"] = ["Armenia", "Հայաստան"],
		["IL"] = ["Israel"],
		["MK"] = ["North Macedonia", "Macedonia"],
		["ME"] = ["Montenegro", "Crna Gora"],
		["AL"] = ["Albania", "Shqipëria"],
		["BA"] = ["Bosnia", "Bosnia and Herzegovina"],
		["XK"] = ["Kosovo", "Kosova"],
		["MD"] = ["Moldova"],
		["BY"] = ["Belarus"],
	};
}
