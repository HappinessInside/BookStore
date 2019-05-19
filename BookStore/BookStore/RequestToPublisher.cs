using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
 public class RequestToPublisher
    {
        public Dictionary<Book, int []> rangeOfBooks;   // словарь : ключ - книга, значение - массив, первый элемент в нем будет количество экземпляров книги, второй - срок прибытия экземпляров из издательства
        public int DayWhenRequestWasMade;   // день, когда заявка была отправлена
        public RequestToPublisher()
        {
            rangeOfBooks = new Dictionary<Book, int[]>();
        }
    }
}
