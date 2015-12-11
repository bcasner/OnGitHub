using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApiServer.Controllers;
using System.Collections.Generic;
using ApiServer.Models;

namespace ApiServer.Tests
{
	[TestClass]
	public class TrailsControllerTest
	{
		[TestMethod]
		public void TrailsControllerTest_GetNotNull()
		{
			// Arrange
			TrailsController controller = new TrailsController();

			// Act
			IEnumerable<Trail> trails = controller.Get();

			// Assert
			Assert.IsNotNull(trails);
		}

		[TestMethod]
		public void TrailsControllerTest_GetVerifyCount()
		{
			// Arrange
			TrailsController controller = new TrailsController();

			// Act
			IEnumerable<Trail> result = controller.Get();
			List<Trail> trails = (List<Trail>)result;

			// Assert
			Assert.IsTrue(trails.Count == 3);
		}
	}
}
