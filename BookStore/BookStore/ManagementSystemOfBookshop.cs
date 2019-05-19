using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class ManagementSystemOfBookshop : IObservable  // сам наблюдаемый объект 
    {
        private List<IObserver> publishers;       // имеет список наблюдателей (издательств)
        public Dictionary<Book, int> booksInStore;  // имеет список книг, продаваемых магазином
        public int NumberOfDays;                  // число дней работы магазина
        public int NumberOfCopiesForRequest;       // число экземпляров книги, при котором делается запрос в издательство.
        public int RetailMarginForNewBooks;        // розничная наценка на новые книги
        public int UsualRetailMargin;              // розничная наценка на остальные книги
        public List<BookOrdering> outstandingOrders; // список невыполненных заказов
        public Dictionary<Book, int> soldBooks;       //  информация о проданных книгах
        public List<RequestToPublisher> requests;    //невыполненные заявки на книги, которые необходимо закупить у издательств
        
         public ManagementSystemOfBookshop()       
         {  
            publishers = new List<IObserver>();
            booksInStore= new Dictionary<Book, int>();
            outstandingOrders= new List<BookOrdering>();
            soldBooks = new Dictionary<Book, int>();
            requests = new List<RequestToPublisher>();
           
         }
        public void AddPublisher(IObserver o)
        {
            publishers.Add(o);
            Publisher publisher = (Publisher)o;
            foreach (var p in publisher.publishedBooks)
            {
                booksInStore.Add(p, 0);        // добавление книг, продаваемых магазином от всех издательсттв, с которыми он сотрудничает
                                               //  пока что их  количество не определено (0), оно задается пользователем
                soldBooks.Add(p,0);
            }
        }

        public void RemovePublisher(IObserver o)
        {
            publishers.Remove(o);
            Publisher publisher = (Publisher)o;
            foreach (var p in publisher.publishedBooks)     // удаление книг издательства, с которым магазин прекращает сотрудничество
                                                            // не реализовано в implementation
            {
                booksInStore.Remove(p);
            }
        }

        public void NotifyPublishers(RequestToPublisher newRequest)
        {
            foreach (IObserver publisher in publishers)
            {
                newRequest=publisher.ProcessStoreRequest(newRequest);     // обработка издательствами запроса магазина: каждое издательство для каждой 
                                                                          //выпускаемой им книги устанавливает срок ее привоза в магазин
            }
            requests.Add(newRequest);         // добавление заявки в список невыполненных заявок                            
        }


      }
}
