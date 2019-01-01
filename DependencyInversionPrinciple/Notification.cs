using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class Notification
    {
        private Email _email;

        public Notification()
        {
            _email = new Email();     
        }

        public void Send()
        {
            _email.SendEmail();
        }
    }
}
