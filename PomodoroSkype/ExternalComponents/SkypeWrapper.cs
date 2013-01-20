using System;
using SKYPE4COMLib;

namespace PomodoroSkype.ExternalComponents
{
    internal class SkypeWrapper
    {
        private static readonly SkypeWrapper TheInstance = new SkypeWrapper();
        private readonly Skype _skype;

        private SkypeWrapper()
        {
            _skype = new Skype();
            _skype.MessageStatus += FireNewMessageEvent;
            _skype.Attach(7, false);
        }

        public static SkypeWrapper Instance
        {
            get { return TheInstance; }
        }

        public bool Running
        {
            get { return _skype.Client.IsRunning; }
        }

        private void FireNewMessageEvent(ChatMessage pmessage, TChatMessageStatus status)
        {
            if (status != TChatMessageStatus.cmsReceived) return; //fire only on messages from other users

            if (pmessage.Chat.Members.Count > 2) return; //ignore not private chats

            if (!pmessage.Sender.IsAuthorized) return; //ignore not authorized users

            OnNewMessage(this, new NewMessageArgs {Message = pmessage, Status = status, Time = DateTime.Now});
        }

        public void SendMessage(string chatName, string message)
        {
            _skype.Chat[chatName].SendMessage(message);
        }

        public void Start()
        {
            if (!_skype.Client.IsRunning)
            {
                _skype.Client.Start(true, true);
            }
        }

        public void Shutdown()
        {
            if (_skype.Client.IsRunning)
            {
                _skype.Client.Shutdown();
            }
        }

        public void ChangeStatus(TUserStatus status)
        {
            _skype.CurrentUserStatus = status;
        }

        public event EventHandler<NewMessageArgs> OnNewMessage;
    }

    public class NewMessageArgs : EventArgs
    {
        public ChatMessage Message { get; set; }
        public TChatMessageStatus Status { get; set; }
        public DateTime Time { get; set; }
    }
}