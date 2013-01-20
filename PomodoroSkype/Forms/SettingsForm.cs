using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PomodoroSkype.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.settings' table. You can move, or remove it, as needed.
            this.settingsTableAdapter.Fill(this.dataDataSet.settings);

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            settingsTableAdapter.Update(dataDataSet);
            Close();
        }

    }
}
