using DesignPatternChallenge.Platforms;

namespace DesignPatternChallenge.Notifications
{
    public class TextNotification : Notification
    {
        public TextNotification(IPlatform platform, string title, string content) 
            : base(platform, title, content)
        {
        }

        public override void Send()
        {
            _platform.RenderText(_title, _content);
        }
    }
}
