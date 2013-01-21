using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PomodoroSkype.Models;

namespace PomodoroSkype.Tests
{
    using NUnit.Framework;
    using Moq;

    [TestFixture]
    class TaskManagerTest
    {
        [Test]
        public static void AddTest()
        {
            //given
            var taskFixture = new Task { Name = "test" };            

            //when
            int result = TaskManager.Instance.Add(taskFixture);

            //then
            Assert.AreEqual(1, result, "This method must add one row to db");
        }

    }
}
