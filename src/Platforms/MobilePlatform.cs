using System;

namespace DesignPatternChallenge.Platforms
{
    public class MobilePlatform : IPlatform
    {
        public void RenderText(string title, string content)
        {
            Console.WriteLine($"[Mobile - Native] Push Notification:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Body: {content}");
            Console.WriteLine($"Icon: notification_icon.png");
        }

        public void RenderImage(string title, string content, string imageUrl)
        {
            Console.WriteLine($"[Mobile - Native] Rich Push Notification:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Body: {content}");
            Console.WriteLine($"Image: {imageUrl}");
            Console.WriteLine($"Style: BigPictureStyle");
        }

        public void RenderVideo(string title, string content, string videoUrl)
        {
            Console.WriteLine($"[Mobile - Native] Video Push Notification:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Body: {content}");
            Console.WriteLine($"Video: {videoUrl}");
            Console.WriteLine($"Action: Tap to play");
        }
    }
}
