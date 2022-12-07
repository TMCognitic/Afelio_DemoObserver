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

        public void Attach(IObserver observer)
        {            
            if (_notifyHandler is null || !_notifyHandler.GetInvocationList().Contains(observer.Update))
            {
                _notifyHandler += observer.Update;
            }            
        }

        public void Detach(IObserver observer)
        {
            if (_notifyHandler is not null)
            {
                _notifyHandler -= observer.Update;
            }
        }

        protected void Notify()
        {
            Action<ISubject>? notifyHandler = _notifyHandler;
            notifyHandler?.Invoke(this);
        }
    }
}
