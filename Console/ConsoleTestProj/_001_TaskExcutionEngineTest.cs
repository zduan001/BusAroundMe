using Console2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConsoleTestProj
{
    
    
    /// <summary>
    ///This is a test class for _001_TaskExcutionEngineTest and is intended
    ///to contain all _001_TaskExcutionEngineTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _001_TaskExcutionEngineTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for ExcuteTask
        ///</summary>
        [TestMethod()]
        public void ExcuteTaskTest()
        {
            _001_TaskExcutionEngine target = new _001_TaskExcutionEngine(); // TODO: Initialize to an appropriate value
            Task t1 = new Task("t1");
            Task t2 = new Task("t2");
            Task t3 = new Task("t3");
            Task t4 = new Task("t4");
            Task t5 = new Task("t5");
            Task t6 = new Task("t6");
            Task t7 = new Task("t7");
            Task t8 = new Task("t8");
            Task t9 = new Task("t9");
            Task t10 = new Task("t10");

            t1.DepencyTasks.Add(t2);
            t1.DepencyTasks.Add(t3);
            t1.DepencyTasks.Add(t4);
            t3.DepencyTasks.Add(t5);
            t3.DepencyTasks.Add(t6);
            t4.DepencyTasks.Add(t7);
            t4.DepencyTasks.Add(t8);
            t4.DepencyTasks.Add(t9);
            t4.DepencyTasks.Add(t10);

            //t1.DepencyTasks.Add(t2);
            //t1.DepencyTasks.Add(t3);
            //t1.DepencyTasks.Add(t4);
            //t2.DepencyTasks.Add(t3);
            //t3.DepencyTasks.Add(t4);
            //t3.DepencyTasks.Add(t5);
            //t5.DepencyTasks.Add(t6);
            //t5.DepencyTasks.Add(t7);
            //t5.DepencyTasks.Add(t8);
            //t5.DepencyTasks.Add(t9);
            //t5.DepencyTasks.Add(t10);
            //t9.DepencyTasks.Add(t8);
            //t9.DepencyTasks.Add(t7);

            List<Task> availableTasks = new List<Task> { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10 };
            Task input = t1;
            target.ExcuteTask(availableTasks, input);
            
        }
    }
}
