using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    //High-level module
    public class Notification
    {
        private readonly ISendEmail _emailService;

        public Notification(ISendEmail emailService)
        {
            _emailService = emailService;
        }

        public void PromotionalNotification()
        {
            var content = "You have won a gift!";
            _emailService.SendEmail(content);
        }
    }
}
