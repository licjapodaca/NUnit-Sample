using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.MsTest.UnitTests
{
	[TestClass]
	public class HtmlFormatterTests
	{
		/// <summary>
		/// Testing methods that return strings
		/// </summary>
		[TestMethod]
		public void FormatAsBold_SetStrongTagToContent_ReturnsTheStringInBold()
		{
			// Arrange
			var htmlFormatter = new HtmlFormatter();

			// Act
			var result = htmlFormatter.FormatAsBold("abc");

			// Assert

			// Assert more specific
			Assert.AreEqual("<strong>abc</strong>", result);

			// Assert more general
			Assert.IsTrue(result.StartsWith("<strong>", StringComparison.InvariantCultureIgnoreCase));
			Assert.IsTrue(result.EndsWith("</strong>", StringComparison.InvariantCultureIgnoreCase));
			Assert.IsTrue(result.Contains("abc", StringComparison.InvariantCultureIgnoreCase));
		}

	}
}
