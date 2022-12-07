using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver.PatternObserver
{
    public abstract class Subject : ISubject
    {
        private Action<ISubject>? _notifyHandler;

        public void Attach(Action<ISubject> action)
        {
            if (_notifyHandler is null || !_notifyHandler.GetInvocationList().Contains(action))
            {
                _notifyHandler += action;
            }
        }

        public void Detach(Action<ISubject> action)
        {
            if (_notifyHandler is not null)
            {
                _notifyHandler -= action;
            }
        }

        protected void Notify()
        {
            Action<ISubject>? notifyHandler = _notifyHandler;
            notifyHandler?.Invoke(this);
        }
    }
}
