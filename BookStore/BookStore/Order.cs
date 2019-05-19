using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public abstract class BookOrdering
    {                                                         
        public string SurnameOfTheCustomer { get; set; }
        public string phoneNumber { get; set; }      
        public Dictionary<Book, int> OrderedBoooks;  // список заказываемых книг
        public int DayWhenOrderWasMade;            // день, когда заказ был сделан
    }

    public class OrderInStore : BookOrdering  // заказ, сделанный в магазине, наследник BookOrdering
    {
        public OrderInStore()
        {
            OrderedBoooks = new Dictionary<Book, int>();

        }
    }

    public class OrderByPhone : BookOrdering  // заказ, сделанный по телефону, наследник BookOrdering
    {
        public OrderByPhone()
        {
            OrderedBoooks = new Dictionary<Book, int>();

        }
    }

    public class OrderByEmail : BookOrdering  // заказ, сделанный по электронной почте , наследник BookOrdering
    {
        public string Email;
        public OrderByEmail()
        {
            OrderedBoooks = new Dictionary<Book, int>();

        }
    }

}
