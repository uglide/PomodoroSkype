using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using PomodoroSkype.ExternalComponents;
using PomodoroSkype.Models;
using PomodoroSkype.Properties;
using SKYPE4COMLib;
using TheCodeKing.ActiveButtons.Controls;
using Timer = PomodoroSkype.Models.Timer;

namespace PomodoroSkype.Forms
{
    public partial class MainForm : Form
    {
        /**
         * SettingsForm loaded from db
         */
        private SettingsManager settings;

        /**
         * Pomodoro Timer Model
         */
        private Timer _taskTimer;

        /*
         * File where stored message template for Skype auto responds  
         * TODO: remove this
         */
        private const string PomadoroTemplateFileName = "pomodoroSkype.ini";

        /*
         * Message template for Skype auto responds   
         */
        private string _messageTemplate;

        /*
         * Task selected for pomodoro
         */
        private Task _currentTask;        

        public MainForm()
        {
            InitializeComponent();
        }

        ~MainForm()
        {
            DbHelper.CloseConnection();
        }

        #region InitApplication

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                InitSettingsManager();
                CreateTopButtons();
                InitTimer(); // Init after settings manager  
                ReloadTasksList();
                InitWlIntegration();

                InitSkypeAutoRespond();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (null != _taskTimer)
                {
                    _taskTimer.Stop();
                }

                Close();
            }
        }

        private void InitSettingsManager()
        {
            settings = new SettingsManager();            
        }

        private void InitWlIntegration()
        {
            /*
             * Try find Wunderlist db
             */
            if (!WlDataReader.IsWunderListInstalled())
            {
               MessageBox.Show(
                   Properties.Resources.MainForm_Wunderlist_Not_Installed
               );
                Close();                
            }

            //load data to reader
            WlDataReader.LoadData();

            //get user name and add to form title
            Text += " - " + WlDataReader.GetUserName();
        }

        private void InitSkypeAutoRespond()
        {
            SkypeWrapper.Instance.Start();
            SkypeWrapper.Instance.OnNewMessage += OnNewMessage;

            // load template from file
            _messageTemplate = File.ReadAllText(PomadoroTemplateFileName);
        }

        private void InitTimer()
        {
            _taskTimer = new Timer(settings.Options["POMODORO_DURATION_IN_SEC"].GetInt());
            _taskTimer.OnTick += DisplayTimeEvent;
            _taskTimer.TimeElapsed += StopTimer;

            DisplayTimeEvent(null, null);
        }

        #endregion

        #region TopButtons

        private void CreateTopButtons()
        {
            IActiveMenu menu = ActiveMenu.GetInstance(this);

            ActiveButton linkButton = new ActiveButton() { Text = "?" };
            linkButton.Click += openRepoLinkClick;
            menu.Items.Add(linkButton); 

            ActiveButton button = new ActiveButton() { Image = Resources.pin };
            button.Click += setOnTopClick;
            menu.Items.Add(button);
            
        }

        private void setOnTopClick(object sender, EventArgs e)
        {            
            TopMost = !TopMost;
        }

        private void openRepoLinkClick(object sender, EventArgs e)
        {
            Process.Start("https://github.com/uglide/PomodoroSkype");
        }

        #endregion

        #region Timer Handlers

        private void StartTimer(object sender, EventArgs e)
        {
            if (_taskTimer.IsRunning())
            {
                _taskTimer.Stop();
            }
            else
            {
                _taskTimer.Start(settings.Options["POMODORO_DURATION_IN_SEC"].GetInt());

                SkypeWrapper.Instance.ChangeStatus(TUserStatus.cusDoNotDisturb);

                btnRun.Text = Resources.MainForm_StartTimer_Stop;
            }
        }

        private void StopTimer(object sender, ElapsedEventArgs args)
        {
            SkypeWrapper.Instance.ChangeStatus(TUserStatus.cusOnline);
            btnRun.Text = Resources.MainForm_StartTimer_Run;
        }

        private void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {            
            SetTimerText(_taskTimer.GetTime());
        }

        private void SetTimerText(string text)
        {
            if (lbTimer.InvokeRequired)
            {
                SetTextCallback d = SetTimerText;

                try
                {
                    Invoke(d, new object[] {text});
                }
                catch
                {
                    //ignore exceptions
                }
            }
            else
            {
                lbTimer.Text = text;
            }
        }

        #endregion

        #region Message Handlers

        private void OnNewMessage(object sender, NewMessageArgs args)
        {
            //no actions if timer not running
            if (!_taskTimer.IsRunning()) return; 

            SkypeWrapper.Instance.SendMessage(
                args.Message.ChatName, 
                GetBusyMessage(args.Message.Sender)
            );
        }

        private string GetBusyMessage(User sender)
        {
            return _messageTemplate
                .Replace("%TIME%", _taskTimer.GetTime())
                .Replace("%SENDER_NAME%", sender.FullName);
        }

        private delegate void SetTextCallback(string text);

        #endregion


        private void ReloadTasksList()
        {             
            olvTasks.SetObjects(TaskManager.GetAllTasks());        
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            TaskForm tf = new TaskForm();
            DialogResult dialogResult = tf.ShowDialog();
            ReloadTasksList();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            SettingsForm tf = new SettingsForm();           
            DialogResult dialogResult = tf.ShowDialog();
            settings.Reload();            
        }

        private void olvTasks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (null != olvTasks.SelectedObject)
            {
                Task selectedObject = (Task)olvTasks.SelectedObject;
                SetCurrentTask(ref selectedObject);
            }
        }

        private void SetCurrentTask(ref Task t)
        {
            _currentTask = t;
            lbCurrentTask.Text = _currentTask.Name;
        }

        private void olvTasks_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {            
            var updatedTask = (Task) e.RowObject;
            updatedTask.EstimatedPomodorosCount = Convert.ToInt32(e.NewValue);            

            if (!updatedTask.IsValid()) return;

            int update = TaskManager.Instance.Update(updatedTask);
        }
    }
}