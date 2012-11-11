using System;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using PomadoroSkype.Properties;
using SKYPE4COMLib;
using Timer = System.Timers.Timer;

namespace PomadoroSkype
{
    public partial class MainForm : Form
    {
        private const int PomadoroDurationInSec = 1500;
        private const string PomadoroTemplateFileName = "pomadoroSkype.ini";

        private bool _isPomadoroInProgress;
        private string _messageTemplate;
        private int _pomadoroTime;
        private Timer _taskTimer;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            SkypeWrapper.Instance.Start();
            SkypeWrapper.Instance.OnNewMessage += OnNewMessage;

            _messageTemplate = File.ReadAllText(PomadoroTemplateFileName);

            _taskTimer = new Timer {Interval = 1000};
            _taskTimer.Elapsed += DisplayTimeEvent;
        }

        private void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
            _pomadoroTime -= 1;
            SetTimerText(SecToFormattedTime(_pomadoroTime));
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

        private string SecToFormattedTime(int sec)
        {
            int min = sec/60;
            return String.Format("{0,2:D2}", min) + ":" + String.Format("{0,2:D2}", (sec - min*60));
        }

        private void OnNewMessage(object sender, NewMessageArgs args)
        {
            if (!_isPomadoroInProgress) return; //no actions if timer not running

            SkypeWrapper.Instance.SendMessage(
                args.Message.ChatName, GetBusyMessage(args.Message.Sender)
                );
        }

        private string GetBusyMessage(User sender)
        {
            return _messageTemplate.Replace("%TIME%", SecToFormattedTime(_pomadoroTime))
                .Replace("%SENDER_NAME%", sender.FullName);
        }

        private void StartTimer(object sender, EventArgs e)
        {
            if (_isPomadoroInProgress)
            {
                _isPomadoroInProgress = false;
                _taskTimer.Stop();

                SkypeWrapper.Instance.ChangeStatus(TUserStatus.cusOnline);

                btnRun.Text = Resources.MainForm_StartTimer_Run;
            }
            else
            {
                _isPomadoroInProgress = true;
                _taskTimer.Start();
                _pomadoroTime = PomadoroDurationInSec;

                SkypeWrapper.Instance.ChangeStatus(TUserStatus.cusDoNotDisturb);

                btnRun.Text = Resources.MainForm_StartTimer_Stop;
            }
        }

        #region Nested type: SetTextCallback

        private delegate void SetTextCallback(string text);

        #endregion
    }
}