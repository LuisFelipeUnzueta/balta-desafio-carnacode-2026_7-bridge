using System;
using DesignPatternChallenge.Notifications;
using DesignPatternChallenge.Platforms;

namespace DesignPatternChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Notificações Multi-Plataforma (Bridge Pattern) ===\n");

            // Plataformas
            IPlatform web = new WebPlatform();
            IPlatform mobile = new MobilePlatform();
            IPlatform desktop = new DesktopPlatform();

            // Notificações - Text
            Console.WriteLine("--- Text Notifications ---");
            Notification textWeb = new TextNotification(web, "Novo Pedido", "Você tem um novo pedido");
            textWeb.Send();
            Console.WriteLine();

            Notification textMobile = new TextNotification(mobile, "Novo Pedido", "Você tem um novo pedido");
            textMobile.Send();
            Console.WriteLine();

            // Notificações - Image
            Console.WriteLine("--- Image Notifications ---");
            Notification imageWeb = new ImageNotification(web, "Promoção", "50% de desconto!", "promo.jpg");
            imageWeb.Send();
            Console.WriteLine();

            // Notificações - Video
            Console.WriteLine("--- Video Notifications ---");
            Notification videoMobile = new VideoNotification(mobile, "Tutorial", "Aprenda a usar o app", "tutorial.mp4");
            videoMobile.Send();
            Console.WriteLine();
            
            Notification videoDesktop = new VideoNotification(desktop, "Tutorial", "Aprenda a usar o app", "tutorial.mp4");
            videoDesktop.Send();
            Console.WriteLine();

            Console.WriteLine("=== CONCLUSÃO ===");
            Console.WriteLine("✓ Abstração (Notification) separada da Implementação (Platform)");
            Console.WriteLine("✓ Novos tipos de notificação podem ser adicionados sem mudar as plataformas");
            Console.WriteLine("✓ Novas plataformas podem ser adicionadas sem mudar os tipos de notificação");
            Console.WriteLine("✓ Explosão de classes evitada: 3 tipos + 3 plataformas = 6 classes (antes seriam 9)");
        }
    }
}
