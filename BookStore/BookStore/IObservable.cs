using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public interface IObservable
     {
         void AddPublisher(IObserver o); // добавляет наблюдателя
         void RemovePublisher(IObserver o); // удаляет наблюдателя
         void NotifyPublishers(RequestToPublisher newRequest); //  уведомляет наблюдателя(издательство) о необходимости привоза книг
     }
}
