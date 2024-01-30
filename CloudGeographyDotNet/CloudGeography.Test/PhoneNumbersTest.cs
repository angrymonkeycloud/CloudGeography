namespace CloudGeography.Test
{
	[TestClass]
	public class PhoneNumbersTest
    {
        [TestMethod]
        public void Get_PhoneNumbers()
        {
            CloudGeographyClient client = new();

            PhoneNumber usCountry = client.PhoneNumbers.Get("+16265895784");

            Assert.AreEqual("US", usCountry?.CountryCode);
            Assert.AreEqual("1", usCountry?.CountryCallingCode);
            Assert.AreEqual("6265895784", usCountry?.Number);

            PhoneNumber usCountry2 = client.PhoneNumbers.Get("+14");

            Assert.AreEqual("US", usCountry2?.CountryCode);
            Assert.AreEqual("1", usCountry2?.CountryCallingCode);
            Assert.AreEqual("4", usCountry2?.Number);

            PhoneNumber caCountry = client.PhoneNumbers.Get("+14185895784");

            Assert.AreEqual("CA", caCountry?.CountryCode);
            Assert.AreEqual("1", caCountry?.CountryCallingCode);
            Assert.AreEqual("4185895784", caCountry?.Number);

            PhoneNumber lbCountry = client.PhoneNumbers.Get("+96176333687");

            Assert.AreEqual("LB", lbCountry?.CountryCode);
            Assert.AreEqual("961", lbCountry?.CountryCallingCode);
            Assert.AreEqual("76333687", lbCountry?.Number);

            PhoneNumber lbCountry2 = client.PhoneNumbers.Get("76333687");

            Assert.IsNull(lbCountry2?.CountryCode);
            Assert.IsNull(lbCountry2?.CountryCallingCode);
            Assert.AreEqual("76333687", lbCountry2?.Number);
            Assert.AreEqual("76333687", lbCountry2?.GetFullPhoneNumber());
        }

        [TestMethod]
        public void ValidPhoneNumbers()
        {
            CloudGeographyClient client = new();

          Assert.IsTrue(client.PhoneNumbers.IsValidPhoneNumber("12345678"));
          Assert.IsTrue(client.PhoneNumbers.IsValidPhoneNumber("+12345678"));
        }

        [TestMethod]
        public void PhoneNumberShort()
        {
            CloudGeographyClient client = new();

            Assert.IsFalse(client.PhoneNumbers.IsValidPhoneNumber("1234567"));
        }

        [TestMethod]
        public void PhoneNumberLong()
        {
            CloudGeographyClient client = new();

            Assert.IsFalse(client.PhoneNumbers.IsValidPhoneNumber("123456789012345678901"));
        }

        [TestMethod]
        public void NotPhoneNumbers()
        {
            CloudGeographyClient client = new();

            Assert.IsFalse(client.PhoneNumbers.IsValidPhoneNumber("123456f78"));
            Assert.IsFalse(client.PhoneNumbers.IsValidPhoneNumber("a"));
            Assert.IsFalse(client.PhoneNumbers.IsValidPhoneNumber("+9648sd41ds4"));
            Assert.IsFalse(client.PhoneNumbers.IsValidPhoneNumber("!@#$%^*())"));
        }
    }
}