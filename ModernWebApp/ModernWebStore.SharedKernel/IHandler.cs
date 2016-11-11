using ModernWebStore.SharedKernel.Event.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernWebStore.SharedKernel
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent 
    {
        void Handle(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
    }
}
