using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BookStore;
namespace Implementation
{
    public partial class WorkOfSystem : Window
    {
        public ManagementSystemOfBookshop SystemOfBookStore;  // система контроля ассортимента книжного магазина
        private int CurrentDayOfWork;                        //  текущий день работы
        public WorkOfSystem(ManagementSystemOfBookshop system)
        {
            InitializeComponent();
            SystemOfBookStore = system;  // система контроля ассортимента книжного магазина берется из предыдущего окна
            CurrentDayOfWork = 1;
            currentDay.Text = CurrentDayOfWork.ToString();  //  отображение текущего дня работы
            numberOfDays.Text = SystemOfBookStore.NumberOfDays.ToString(); //  отображение числа дней работы
            foreach (Book book in SystemOfBookStore.booksInStore.Keys)
            {
                if (book.YearOfEdition < 2018)
                {
                    book.Price += SystemOfBookStore.UsualRetailMargin * book.Price / 100;     // установление цены книги с наценкой
                }
                else
                {
                    book.Price += SystemOfBookStore.RetailMarginForNewBooks * book.Price / 100; //  установление цены книги с наценкой для новых книг
                }
                rangeOfBookstore.Text += book.ToString() + "number of copies: " + SystemOfBookStore.booksInStore[book] + "\r\n" + "\r\n"; // отображение информации о книгах, имеющихся в магазине
            }

        }

        private void WorkOfSystem_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Owner.Close();                  //  закрытие предыдущих окон всместе с закрытием текущего
            this.Owner.Close();

        }

        private void BackToTop_Click(object sender, RoutedEventArgs e)  //  клик по кнопке "в начало"
        {

            MainWindow mainWindow = new MainWindow();        //  открытие самого первого окна с параметрами
            mainWindow.Show();
            this.Owner.Close();
            this.Owner.Owner.Close();
        }

        private void OrderInStore_Click(object sender, RoutedEventArgs e)  //  клик по кнопке "создание заказа в магазине" 
        {

            Order order = new Order("OrderInStore", SystemOfBookStore);       // создание окна заказа
            order.Owner = this;
            order.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            order.Show();
        }

        private void OrderByPhone_Click(object sender, RoutedEventArgs e) //  клик по кнопке "создание заказа по телефону"
        {

            Order order = new Order("OrderByPhone", SystemOfBookStore);
            order.Owner = this;
            order.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            order.Show();
        }

        private void OrderByEmail_Click(object sender, RoutedEventArgs e) //  клик по кнопке "создание заказа по электронной почте"
        {

            Order order = new Order("OrderByEmail", SystemOfBookStore);
            order.Owner = this;
            order.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            order.Show();
        }

        private void viewOrders_Click(object sender, RoutedEventArgs e)   //  клик по кнопке "просмотреть невыполненные заказы"
        {

            ReviewOfTheBooks orders = new ReviewOfTheBooks(SystemOfBookStore,true);  //  открытие окна для просмотра заказов
            orders.reviewOfOrdersLabel.Visibility = Visibility.Visible;
            orders.Owner = this;
            orders.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            orders.Show();
        }
        public void SellBooks(BookOrdering order)   //  клик по кнопке "Продажа книг"
        {
            foreach (Book book in order.OrderedBoooks.Keys.ToArray())
            {
                if (SystemOfBookStore.booksInStore[book] >= order.OrderedBoooks[book])  //  если экземпляров книги в магазине больше (или равно), чем нужно заказчику
                {
                    MessageBox.Show(order.OrderedBoooks[book] + " copies of the book " + "''" + book.Name + "''" + " " + "of " + book.Author + " are sold.");  // сообщение о продаже книги
                    SystemOfBookStore.booksInStore[book] -= order.OrderedBoooks[book]; // уменьшение числа экземпляров книги в магазине на количество проданных экземпляров книги
                    if (!SystemOfBookStore.soldBooks.ContainsKey(book))
                    { SystemOfBookStore.soldBooks.Add(book, order.OrderedBoooks[book]); }      // занесение книги в список проданных книг
                    else { SystemOfBookStore.soldBooks[book] += order.OrderedBoooks[book]; }
                    order.OrderedBoooks.Remove(book);                                         // удаление книги из заказа (заказ на нее выполнен, она продана)

                }
                else if (SystemOfBookStore.booksInStore[book] < order.OrderedBoooks[book] && SystemOfBookStore.booksInStore[book] > 0) //  если экземпляров книги в магазине меньше, чем нужно заказчику
                {
                    int count = SystemOfBookStore.booksInStore[book];
                    MessageBox.Show(SystemOfBookStore.booksInStore[book] + " copies of the book " + "''" + book.Name + "''" + " " + "of " + book.Author + " are sold."); // cообщение о продаже экземпляров книги, всех, что имеются в магазине
                    SystemOfBookStore.booksInStore[book] = 0;         // число экземляров книги в магазине стало 0
                    if (!SystemOfBookStore.soldBooks.ContainsKey(book))
                    { SystemOfBookStore.soldBooks.Add(book, count); }    // занесение книги в список проданных книг
                    else { SystemOfBookStore.soldBooks[book] += count; }
                    order.OrderedBoooks[book] -= count;   // удаление числа проданных экземпляров книги 

                }


            }
            int maxNumbersOfSoldCopies = (from p in SystemOfBookStore.soldBooks select p.Value).Max(); // поиск максимального числа проданных экземпляров книги
            foreach (var book in SystemOfBookStore.booksInStore.Keys)
            {     if (SystemOfBookStore.soldBooks.ContainsKey(book))
                {
                    book.Rating =Math.Round( SystemOfBookStore.soldBooks[book] * 5.0 / maxNumbersOfSoldCopies,1); // меняем рейтинг книг после совершенной продажи в списке книг в магазине
                    foreach(Book p in SystemOfBookStore.soldBooks.Keys)
                    {
                        if(p.Name==book.Name)                            
                        {
                            p.Rating = book.Rating;          //   устанавливаем  полученный рейтинг для книги в списке проданных книг     
                            break;
                        }
                    }
                }
                 else { book.Rating = 0; }
            }
            rangeOfBookstore.Clear();
            foreach (Book book in SystemOfBookStore.booksInStore.Keys)
            { rangeOfBookstore.Text += book.ToString() + "number of copies: " + SystemOfBookStore.booksInStore[book] + "\r\n" + "\r\n"; } // отображение изменений в элементе TextBox  информации о книге(изменение кол-ва экземпляров и рейтинга после продажи)
        }

        private RequestToPublisher DetermineWhichBooksAreRequired()    // метод , определяющий, какие книги и сколько нужно закупить у издательств
        {
            RequestToPublisher newRequest = new RequestToPublisher();   // формирование новой заявки
            newRequest.DayWhenRequestWasMade = int.Parse(currentDay.Text); // определение дня отправления заявки
            foreach(Book book in SystemOfBookStore.booksInStore.Keys)
            {
                if(SystemOfBookStore.booksInStore[book]<SystemOfBookStore.NumberOfCopiesForRequest) // если число экземпляров книги меньше минимального и нужно заказать проивоз дополнительных экземпляров
                {
                    bool flag = true;
                    foreach(var request in SystemOfBookStore.requests)  
                    {  if(request.rangeOfBooks.ContainsKey(book))  // если данная книга находится в невыполненных заявках, то заявку на нее снова не делаем
                        {
                            flag = false;
                            break;                                               
                        }
                       
                    }
                    if(flag)
                    {
                        newRequest.rangeOfBooks.Add(book, new int[] { 5,100});  // иначе добавляем в заявку информацию о книге (5-число заказываемых экземпляров, 100 - первоначальная установка дня привоза книги)
                        if(SystemOfBookStore.booksInStore[book]==0)
                        {
                            foreach(var order in SystemOfBookStore.outstandingOrders)
                            {
                                if(order.DayWhenOrderWasMade==int.Parse(currentDay.Text)) // кроме того, если книга, которой недостаточно в магазине, присутствует еще  и в невыполненном заказе,
                                {
                                    if(order.OrderedBoooks.ContainsKey(book))  
                                    {
                                        newRequest.rangeOfBooks[book][0] += order.OrderedBoooks[book];  // то прибавляем нужное для привоза кол-во экземпляров
                                    }
                                }
                            }
                        }
                    }
                }
            }


            return newRequest;   //  метод возвращает заявку
        }
        private void nextDayButton_Click(object sender, RoutedEventArgs e) // клик по кнопке "следующий день работы"
        {

            if(CurrentDayOfWork<SystemOfBookStore.NumberOfDays)  // если день работы меньше числа дней работы магазина
            { 
                RequestToPublisher request = DetermineWhichBooksAreRequired(); // создание заявки
                if(request.rangeOfBooks.Count>0)  
                {
                    SystemOfBookStore.NotifyPublishers(request); // уведомление издательств о новой заявке (получается, что заявка как бы отправляется в конце дня работы магазина)
                }
               
                CurrentDayOfWork++;
                if(CurrentDayOfWork==SystemOfBookStore.NumberOfDays)  
                {
                    nextDay.Visibility = Visibility.Hidden;  // если последний день работы, то кнопка "следующий день работы" скрывается, 
                    resultOfTheWork.Visibility = Visibility.Visible; // а кнопка "результат работы" отображается
                }
                currentDay.Text = CurrentDayOfWork.ToString();
                MessageBox.Show("Next day of work of the bookstore.");
                foreach(RequestToPublisher req in SystemOfBookStore.requests.ToArray())
                {
                    foreach(var book in req.rangeOfBooks.Keys.ToArray())
                    {
                        if(req.rangeOfBooks[book][1]==CurrentDayOfWork)  // просмотр заявок, если день привоза книги в заявке совпадает с текущим днем,то
                        {
                            MessageBox.Show(req.rangeOfBooks[book][0] + " copies of the book " + "''" + book.Name + "''" + " " + "of " + book.Author + " are received."); // делается сообщение о привозе экземпляров книги
                            SystemOfBookStore.booksInStore[book] += req.rangeOfBooks[book][0]; // увеличивается число экземляров книги в магазине на число привезенных экземпляров
                            req.rangeOfBooks.Remove(book); // удаление книги из невыполненной заявки (она уже привезена)
                            if(req.rangeOfBooks.Count==0)
                            {
                                SystemOfBookStore.requests.Remove(req); // если в заявке больше нет книг, то она удаляется 
                            }

                        }
                    }
                }
                rangeOfBookstore.Clear();
                foreach (Book book in SystemOfBookStore.booksInStore.Keys)
                {
                    rangeOfBookstore.Text += book.ToString() + "number of copies: " + SystemOfBookStore.booksInStore[book] + "\r\n" + "\r\n"; // обновление информации о книгах в TextBox
                }

                foreach (var order in SystemOfBookStore.outstandingOrders.ToArray())  // просмотр невыполненных заказов сразу после привоза книг
                {
                    SellBooks(order);  // продать книги заказчику
                    if(order.OrderedBoooks.Count==0)
                    { SystemOfBookStore.outstandingOrders.Remove(order); }  // если в заказе больше нет книг, то он удаляется из списка невыполненных заказов
                }
            }
            
        }
        private void requestsButton_Click(object sender, RoutedEventArgs e)  //  клик по кнопке "просмотр невыполненных заявок"
        {
            ReviewOfTheBooks review = new ReviewOfTheBooks(SystemOfBookStore,false);  // открытие окна просмотра заявок
            review.reviewOfTheRequests.Visibility = Visibility.Visible;
            review.Owner = this;
            review.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            review.Show();
         

        }
        private void resultOfTheWork_Click(object sender,RoutedEventArgs e) //  клик по кнопке "просмотр результата работы магазина"
        {
            ResultOfTheWorkOfBookstore result = new ResultOfTheWorkOfBookstore(SystemOfBookStore);  // открытие окна результата работы магазина
            result.Owner = this;
            result.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            result.Show();

        }


    }
    }
