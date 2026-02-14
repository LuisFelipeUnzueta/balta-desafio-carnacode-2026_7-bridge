using DesignPatternChallenge.Platforms;

namespace DesignPatternChallenge.Notifications
{
    public class ImageNotification : Notification
    {
        private string _imageUrl;

        public ImageNotification(IPlatform platform, string title, string content, string imageUrl) 
            : base(platform, title, content)
        {
            _imageUrl = imageUrl;
        }

        public override void Send()
        {
            _platform.RenderImage(_title, _content, _imageUrl);
        }
    }
}
