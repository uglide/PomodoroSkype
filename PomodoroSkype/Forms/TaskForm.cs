using System;
using System.Linq;
using System.Windows.Forms;
using PomodoroSkype.ExternalComponents;

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


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbTaskLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTasks(cbTaskLists.SelectedItem.ToString());
        }
    }
}