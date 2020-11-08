using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using SportQuestTrackerAPI.Contracts;
using SportQuestTrackerAPI.Controllers;
using SportQuestTrackerAPI.Repositories;

namespace SportQuestTrackerUnitTest
{
    public class GadgetControllerTests
    {
        [SetUp]
        public void Setup()
        {
            IGadgetRepository gadgetRepository = new Mock<IGadgetRepository>().Object;
            ILoggerService ilogLoggerService = new Mock<ILoggerService>().Object;
            IMapper iMapper = new Mock<IMapper>().Object;


        }
        

    }
}
