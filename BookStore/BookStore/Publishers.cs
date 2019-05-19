using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
   public interface IObserver  // интерфейс наблюдатель
    {
        RequestToPublisher ProcessStoreRequest(RequestToPublisher newRequest); // метод обработки издательствами заявки, принимает и возвращает заявку

    }

    public class Publisher : IObserver       // базовый класс издательство, наследник наблюдателя
    {
        public List<Book> publishedBooks = new List<Book>();   // список книг, выпускаемых издательством
        public IObservable BookStore; // книжный магазин, с которым сотрудничают издательства
        public string name { get; set; }  // название издательства
    
        public  RequestToPublisher ProcessStoreRequest(RequestToPublisher newRequest)  // метод обработки издательствами заявки магазина
        {
            foreach(Book book in newRequest.rangeOfBooks.Keys)                       
            {
                if(book.Publisher==name)                 // для каждой книги, выпускаемой издательством, устанавливается срок привоза книги в магазин
                {   Random rnd = new Random();
                    newRequest.rangeOfBooks[book][1] = rnd.Next(1, 3)+newRequest.DayWhenRequestWasMade;   // срок привоза книги в магазин устанавливается рандомно
                                                                                                          // rangeOfBooks - словарь, где ключ - это книга, а значение - массив из двух элементов:
                                                                                                           // 1) количество экземпляров книги 2) срок проивоза ее в магазин
                }
            
            }
            return newRequest;  // возвращает заявку с установленным сроком привоза для книг данного издательства
        }

        public void StopCooperation()      // прекращение сотрудничества с магазином (не реализовано в Implementation)
        {
            BookStore.RemovePublisher(this);
            BookStore = null;
        }
    }

    public class SciencePublisher : Publisher   // выпускает научную литературу
    {
        public SciencePublisher(IObservable bookStore) // конструктор, задается название, список выпускаемых книг
        {
            name = "Science";
            publishedBooks.Add(new Book("Scientific literature", "Tvorogov O.","Древняя Русь.События и люди", "Science", 2018,238,540,0));  // рейтинг у всех книг изначально будет 0
            publishedBooks.Add(new Book("Scientific literature", "Falileev A.", "Древневаллийский язык", "Science", 2002, 96, 250, 0));
            publishedBooks.Add(new Book("Novel", "Solzhenitsyn A.", "В круге первом", "Science", 2006, 200, 657, 0));
            BookStore = bookStore;
            BookStore.AddPublisher(this); 
        }
    }

    public class PublishingHouseDrofa : Publisher   //  выпускает учебную литературу
    {
        public PublishingHouseDrofa(IObservable bookStore) 
        {
            name = "Drofa";
            publishedBooks.Add(new Book("Educational literature", "Кurchina S.", "Контурные карты. 6 класс. География", "Drofa", 2019, 24, 75, 0));  // рейтинг у всех книг изначально будет 0
            publishedBooks.Add(new Book("Educational literature", "Eremin V.", "Химия. 9 класс. Учебник", "Drofa", 2018, 256, 143, 0));
            publishedBooks.Add(new Book("Educational literature", "Katz E.", "Литературное чтение. 4 класс. Тетрадь проектов", "Drofa", 2010, 56, 83, 0));
            BookStore = bookStore;
            BookStore.AddPublisher(this);
        }
    }

    public class LabirintPressPublisher : Publisher   // выпускает детскую литературу
    {
        public LabirintPressPublisher(IObservable bookStore)
        {
            name = "Labirint";
            publishedBooks.Add(new Book("Roman", "Victor Hugo", "Отверженные", "Labirint", 2013, 1248, 451, 0));
            publishedBooks.Add(new Book("Children's literature", "Victor Hugo", "Повести и рассказы о детях", "Labirint", 2019, 64, 230, 0));  // рейтинг у всех книг изначально будет 0
            publishedBooks.Add(new Book("Flora and fauna", "Rovira Pere", "Животные нашей  планеты", "Labirint", 2011, 174, 210, 0));
            publishedBooks.Add(new Book("Foreign adventure literature", "Robert Stevenson", "Остров сокровищ", "Labirint", 2018, 188, 2560, 0));
            BookStore = bookStore;
            BookStore.AddPublisher(this);
        }
    }
}
