using System;
using DesignPatternChallenge.Notifications;
using DesignPatternChallenge.Platforms;

namespace DesignPatternChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Multi-Platform Notification System (Bridge Pattern) ===\n");

            // Platforms
            IPlatform web = new WebPlatform();
            IPlatform mobile = new MobilePlatform();
            IPlatform desktop = new DesktopPlatform();

            // Notifications - Text
            Console.WriteLine("--- Text Notifications ---");
            Notification textWeb = new TextNotification(web, "New Order", "You have a new order");
            textWeb.Send();
            Console.WriteLine();

            Notification textMobile = new TextNotification(mobile, "New Order", "You have a new order");
            textMobile.Send();
            Console.WriteLine();

            // Notifications - Image
            Console.WriteLine("--- Image Notifications ---");
            Notification imageWeb = new ImageNotification(web, "Promotion", "50% off!", "promo.jpg");
            imageWeb.Send();
            Console.WriteLine();

            // Notifications - Video
            Console.WriteLine("--- Video Notifications ---");
            Notification videoMobile = new VideoNotification(mobile, "Tutorial", "Learn how to use the app", "tutorial.mp4");
            videoMobile.Send();
            Console.WriteLine();

            Notification videoDesktop = new VideoNotification(desktop, "Tutorial", "Learn how to use the app", "tutorial.mp4");
            videoDesktop.Send();
            Console.WriteLine();

            Console.WriteLine("=== CONCLUSION ===");
            Console.WriteLine("✓ Abstraction (Notification) separated from Implementation (Platform)");
            Console.WriteLine("✓ New notification types can be added without changing platforms");
            Console.WriteLine("✓ New platforms can be added without changing notification types");
            Console.WriteLine("✓ Class explosion avoided: 3 types + 3 platforms = 6 classes (previously it would be 9)");
        }
    }
}
