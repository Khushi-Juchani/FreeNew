using System;
using ADPDataAccessProj;
using ADPRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ADPPlannerTest
{
    [TestClass]
    public class EventTest
    {
        ADP_DB_New1Entities context = new ADP_DB_New1Entities();
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestMethod1()
        {
                EventRepository eventRepository = new EventRepository();
                eventRepository.Delete(-1);

        }
        [TestMethod]
        public void TestMethod2()
        {
            EventRepository eventRepository = new EventRepository();
            var current_event = eventRepository.GetByName("1");
            var cur_type = current_event.GetType();
            Assert.AreEqual(typeof(Event), cur_type.BaseType);

        }
        [TestMethod]
        public void TestMethod3()
        {
            EventRepository eventRepository = new EventRepository();
            var current_event = eventRepository.GetByName("10");
            Assert.AreEqual(null, current_event);
        }
    }
}
