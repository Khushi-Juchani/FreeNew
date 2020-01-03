using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ADPRepository;
//using ADPDataAccess;
using ADPDataAccessProj;

using System.Collections.Generic;

namespace ADPPlannerTest
{
    [TestClass]
    public class ClientTests
    {
        [TestMethod]
        public void TestMethodClientGetAll()
        {
            ADP_DB_New1Entities context = new ADP_DB_New1Entities();
            ClientRepository clientRepository = new ClientRepository(context);
            var clientResult = clientRepository.GetAll();
            var resultType = typeof(List<Client>);
            Assert.AreEqual(resultType, clientResult.GetType());

        }

    }
}
