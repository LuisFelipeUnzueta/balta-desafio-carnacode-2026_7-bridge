using DesignPatternChallenge.Platforms;

namespace DesignPatternChallenge.Notifications
{
    public abstract class Notification
    {
        protected IPlatform _platform;
        protected string _title;
        protected string _content;

        protected Notification(IPlatform platform, string title, string content)
        {
            _platform = platform;
            _title = title;
            _content = content;
        }

        public abstract void Send();
    }
}
