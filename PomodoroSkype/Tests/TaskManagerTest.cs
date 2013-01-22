using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public static void AddTestValid()
        {
            //given
            var taskFixture = new Task { Name = "test" };            

            //when
            int result = TaskManager.Instance.Add(taskFixture);

            //then
            Assert.AreEqual(1, result, "This method must add one row to db");
        }

        [Test]
        public static void GetAllTasksValid()
        {
            //given
            //task manager

            //when 
            var result = TaskManager.GetAllTasks();

            //then
            Assert.IsNotEmpty(result, "Result must contain one task");
            Assert.IsInstanceOf<Task>(result.First());
        }

    }
}
