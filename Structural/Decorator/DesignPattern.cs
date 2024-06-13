using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /*
     * 
     */

    public interface IMail
    {
        void Send();
    }

    public class Mail : IMail
    {
        public void Send()
        {
            Console.WriteLine("Mail sent.");
        }
    }

    public abstract class MailDecorator : IMail
    {
        protected IMail mail;

        public MailDecorator(IMail mail)
        {
            this.mail = mail;
        }

        public virtual void Send()
        {
            mail.Send();
        }
    }

    public class MailWithAttachment : MailDecorator
    {
        public MailWithAttachment(IMail mail) : base(mail)
        {
        }

        public override void Send()
        {
            Console.WriteLine("Attachment added.");
            base.Send();
        }
    }

    public class MailWithSignature : MailDecorator
    {
        public MailWithSignature(IMail mail) : base(mail)
        {
        }

        public override void Send()
        {
            Console.WriteLine("Signature added.");
            base.Send();
        }
    }

    public class MailWithEncrypted : MailDecorator
    {
        public MailWithEncrypted(IMail mail) : base(mail)
        {
        }

        public override void Send()
        {
            Console.WriteLine("Encrypted.");
            base.Send();
        }
    }

   
}
