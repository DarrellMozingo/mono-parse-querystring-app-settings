using System.Configuration;
using System.Web;
using NUnit.Framework;

namespace tests
{
    public class Tests
    {
		[Test]
		public void Access_app_setting_fails_after_calling_parse_query_string()
		{
			Assert.That(ConfigurationManager.AppSettings["SomeKey"], Is.Not.Null, "Null on first try");
			Assert.That(HttpUtility.ParseQueryString("example.com?query=value"), Is.Not.Null);
			Assert.That(ConfigurationManager.AppSettings["SomeKey"], Is.Not.Null, "Null on second try");
		}
    }
}