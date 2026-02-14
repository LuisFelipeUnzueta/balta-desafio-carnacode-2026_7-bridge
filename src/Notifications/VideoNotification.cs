using DesignPatternChallenge.Platforms;

namespace DesignPatternChallenge.Notifications
{
    public class VideoNotification : Notification
    {
        private string _videoUrl;

        public VideoNotification(IPlatform platform, string title, string content, string videoUrl) 
            : base(platform, title, content)
        {
            _videoUrl = videoUrl;
        }

        public override void Send()
        {
            _platform.RenderVideo(_title, _content, _videoUrl);
        }
    }
}
