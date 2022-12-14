using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver.PatternObserver
{
    public abstract class Subject : ISubject
    {
        public event Action<ISubject>? NotifyHandler;

        protected void Notify()
        {
            Action<ISubject>? notifyHandler = NotifyHandler;
            notifyHandler?.Invoke(this);
        }
    }
}
