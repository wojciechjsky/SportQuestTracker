using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SportQuestTrackerAPI.Controllers;

namespace SportQuestTrackerUnitTest
{
    public class GadgetControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        //public async Task<IActionResult> GetGadget(int id)
        [Test]
        public void GetGadget_WhenGadgetNotExist_ReturnsNotFound()
        {
            var GadgetController = new GadgetController();
        }


    }
}
