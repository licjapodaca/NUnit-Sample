using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
	[TestFixture]
	public class HtmlFormatterxTests
	{
		// Testing methods that return strings

		[Test]
		public void FormatAsBold_SetStrongTagToContent_ReturnsTheStringInBold()
		{
			var htmlFormatter = new HtmlFormatter();

			var result = htmlFormatter.FormatAsBold("abc");

			// Assert more specific
			Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

			// Assert more general
			Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
			Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
			Assert.That(result, Does.Contain("abc").IgnoreCase);
		}
	}
}
