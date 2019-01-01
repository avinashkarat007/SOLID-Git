using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Refactored
{
    public class Notification
    {
        private IMessage _message;

        public Notification(IMessage message)
        {
            this._message = message;
        }

        public void Send()
        {
            _message.SendMessage();
        }
    }
}
