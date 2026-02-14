namespace DesignPatternChallenge.Platforms
{
    public interface IPlatform
    {
        void RenderText(string title, string content);
        void RenderImage(string title, string content, string imageUrl);
        void RenderVideo(string title, string content, string videoUrl);
    }
}
