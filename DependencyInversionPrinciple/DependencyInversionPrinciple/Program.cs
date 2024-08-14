using System;
using DependencyInversionPrinciple;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            ISendEmail emailService = new EmailService();
            Notification notification = new Notification(emailService);
            notification.PromotionalNotification();
        }
    }
}