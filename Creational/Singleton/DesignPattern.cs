using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /*
     * Senaryo: Mail sunucunuzun sadece bir tane olmasını istiyorsunuz. Bu durumda Singleton pattern kullanabilirsiniz.
     */

    //1. Adım: Singleton sınıfımızı oluşturuyoruz.

    public class MailConfigurator
    {
        private string Host { get; set; }
        private string Port { get; set; }
        private bool EnableSsl { get; set; }

        private static MailConfigurator _mailConfigurator;

        private MailConfigurator()
        {
            Host = "mail.yourmailserver.com";
            Port = "587";
            EnableSsl = true;
        }

        public static MailConfigurator GetInstance()
        {
            if (_mailConfigurator == null)
            {
                _mailConfigurator = new MailConfigurator();
            }

            return _mailConfigurator;
        }
    }
}
