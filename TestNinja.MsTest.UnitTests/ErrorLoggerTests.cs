using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.MsTest.UnitTests
{
	[TestClass]
	public class ErrorLoggerTests
	{
		/// <summary>
		/// Testing void methods
		/// </summary>
		[TestMethod]
		public void Log_WhenCalled_SetTheLastErrorProperty()
		{
			// Arrange
			var logger = new ErrorLogger();

			// Act
			logger.Log("a");

			// Assert
			Assert.AreEqual("a", logger.LastError);
		}

		/// <summary>
		/// Testing methods that throws an exception
		/// </summary>
		/// <param name="error"></param>
		[TestMethod]
		[DataRow(null), DataRow(""), DataRow(" ")]
		public void Log_InvalidError_ThrowArgumentNullException(string error)
		{
			// Arrange
			var logger = new ErrorLogger();

			// Act & Assert
			Assert.ThrowsException<ArgumentNullException>(() => logger.Log(error));
		}

		// <summary>
		/// Testing methods that raise an event
		/// ----> Testing private methods (Don't do it)
		/// </summary>
		[TestMethod]
		public void Log_ValidError_RaiseErrorLoggedEvent()
		{
			// Arrange
			var logger = new ErrorLogger();

			// Act
			var id = Guid.Empty;
			logger.ErrorLogged += (sender, args) => { id = args; };
			logger.Log("a");

			// Assert
			Assert.AreNotEqual(Guid.Empty, id);
		}
	}
}
