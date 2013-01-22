using System;
using System.Linq;
using System.Windows.Forms;
using PomodoroSkype.ExternalComponents;
using PomodoroSkype.Models;

namespace PomodoroSkype.Forms
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();

            LoadTaskLists();
        }

        private void LoadTaskLists()
        {
            var list = WlDataReader.GetLists();

            var taskLists =
                from tl in list
                 where !tl.IsDeleted
                 select tl.Title;

            cbTaskLists.Items.AddRange(taskLists.ToArray());            
        }

        private void LoadTasks(string taskListName)
        {
            var list = WlDataReader.GetLists();

            var taskList =
                (from tl in list
                 where (tl.Title == taskListName) && !tl.IsDeleted
                select tl.Tasks).FirstOrDefault();
                

            var tasks =
                from t in taskList
                where !t.Done
                select t.Title;                

            cbTasks.Items.Clear();
            cbTasks.Items.AddRange(tasks.ToArray());            
        }


        private void CloseFormBtnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void cbTaskLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTasks(cbTaskLists.SelectedItem.ToString());
        }

        private void AddTaskBtnClick(object sender, EventArgs e)
        {

            string taskName = cbTasks.SelectedItem.ToString();
            int estimation = Convert.ToInt32(nudEstimation.Value);            

            var newTask = new Task
                              {
                                  Name = taskName,
                                  EstimatedPomodorosCount = estimation
                              };

            if (newTask.IsValid())
            {
                TaskManager.Instance.Add(newTask);
                Close();
            }
        }
    }
}
