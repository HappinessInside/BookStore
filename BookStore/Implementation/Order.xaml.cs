using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BookStore;
using ComboBox = System.Windows.Controls.ComboBox;
using MessageBox = System.Windows.MessageBox;
using TextBox = System.Windows.Controls.TextBox;

namespace Implementation
{

    public partial class Order : Window
    {
        public BookOrdering OrderOfCustomer;   // заказ
        private string TypeOfOrder;         //   его тип(в магазине, по телефону, по эл. почте)
        private ManagementSystemOfBookshop SystemOfBookStore;   // система контроля ассортимента книжного магазина
        private List<TextBox> authors;
        private List<TextBox> names;
        private List<ComboBox> numbersOfCopies;
        public Order(string typeOfOrder, ManagementSystemOfBookshop system)
        {
            InitializeComponent();
            TypeOfOrder = typeOfOrder;
            SystemOfBookStore = system;    // система контроля ассортимента книжного магазина берется из предыдущего окна WorkOfSystem
            authors = new List<TextBox>();
            names = new List<TextBox>();
            numbersOfCopies = new List<ComboBox>();
            authors.Add(author0);            // добавление в список всех элементов TextBox, куда будут записываться авторы выбранных пользователем книг
            authors.Add(author1);
            authors.Add(author2);
            authors.Add(author3);
            authors.Add(author4);
            names.Add(name0);            // то же с названиями книг
            names.Add(name1);
            names.Add(name2);
            names.Add(name3);
            names.Add(name4);
            numbersOfCopies.Add(numberOfCopies0);  // то же с количеством экземпляров
            numbersOfCopies.Add(numberOfCopies1);
            numbersOfCopies.Add(numberOfCopies2);
            numbersOfCopies.Add(numberOfCopies3);
            numbersOfCopies.Add(numberOfCopies4);
            foreach (Book p in system.booksInStore.Keys)
            {
                rangeOfBookstore.Text += p.DisplaySummaryInformation() + "\r\n" + "\r\n"; // добавление книг для справки, которые может заказать пользователь 
            }                                                                              // чтобы пользователь мог копировать авторов и названия оттуда


        }

        private void AddTheBook_Click(object sender, RoutedEventArgs e)  // клик по кнопке  "добавить книгу"
        {
            for (int i = 0; i < authors.Count; i++)                   // добавление полей под информацию о заказавыемой книге
                                                                      // пользователь может заказать не более 5 разных книг
            {
                if (authors[i].Visibility == Visibility.Hidden)
                {
                    authors[i].Visibility = Visibility.Visible;
                    names[i].Visibility = Visibility.Visible;
                    numbersOfCopies[i].Visibility = Visibility.Visible;
                    if (i == (authors.Count - 1))
                    {
                        addTheBookButton.Visibility = Visibility.Hidden;
                    }
                    break;
                }

            }
        }
        private void PlaceTheOrder_Click(object sender, RoutedEventArgs e)   // клик по кнопке "разместить заказ"
        {
            bool flag = true;
            char[] delimitors = new char[] { ' ' };
            if (TypeOfOrder == "OrderInStore")
            {
                OrderOfCustomer = new OrderInStore();    // создание заказа определенного типа
            }
            else if (TypeOfOrder == "OrderByPhone")
            {
                OrderOfCustomer = new OrderByPhone();
            }
            else if (TypeOfOrder == "OrderByEmail")
            {
                OrderOfCustomer = new OrderByEmail();
            }
            if (surnameOfTheCuctomer.Text != null)
            {
                OrderOfCustomer.SurnameOfTheCustomer = surnameOfTheCuctomer.Text;        // добавление введенной пользователем фамилии заказчика
            }
            else
            {
                MessageBox.Show("Enter the surname of the customer");
                flag = false;
            }
            if (phoneNumber.Text != null)
            {
                OrderOfCustomer.phoneNumber = phoneNumber.Text;         // добавление номера телефона
            }
            else
            {
                MessageBox.Show("Enter the phone number of the customer");
                flag = false;
            }
            if (emailAdress.Text != null && TypeOfOrder == "OrderByEmail")    // добавление адреса эл. почты, если заказ сделан по эл. почте
            {
                var Order = (OrderByEmail)OrderOfCustomer;
                Order.Email = emailAdress.Text;
                OrderOfCustomer = Order;
            }
            else if (TypeOfOrder == "OrderByEmail")
            {
                MessageBox.Show("Enter email  of the customer");
                flag = false;
            }

            for (int i = 0; i < authors.Count; i++)
            {
                if (authors[i].Visibility == Visibility.Visible && authors[i].Text != null && names[i].Text != null && numbersOfCopies[i].Text != null)
                {
                    Book book = null;
                    string[] initialsOfAuthor = authors[i].Text.Split(delimitors, StringSplitOptions.RemoveEmptyEntries);
                    if (initialsOfAuthor.Length > 1)
                    {
                        for (int l = 1; l < initialsOfAuthor.Length; l++)
                        { initialsOfAuthor[0] += ' ' + initialsOfAuthor[l]; }
                    }
                    string author = initialsOfAuthor[0];                          // автор, введенный в TextBox
                    foreach (Book p in SystemOfBookStore.booksInStore.Keys)
                    {
                        string[] elements = p.Author.Split(' ');

                        if (p.Author == author)                        // сопоставление этого автора с авторами имеющихся в магазине книг
                        {
                            book = p;
                            break;
                        }
                        else
                        {
                            foreach (string el in elements)
                            {
                                if (el == author)
                                {
                                    book = p;
                                    break;
                                }

                            }
                            if (book != null)
                            {
                                break;
                            }

                        }
                        if (i == (authors.Count - 1) && book == null)
                        {
                            flag = false;
                            MessageBox.Show("Books of this author are not found.");
                        }
                    }

                    string[] partsOfNameOfTheBook = names[i].Text.Split(delimitors, StringSplitOptions.RemoveEmptyEntries);
                    if (partsOfNameOfTheBook.Length > 1)
                    {
                        for (int k = 1; k < partsOfNameOfTheBook.Length; k++)
                        {
                            partsOfNameOfTheBook[0] += ' ' + partsOfNameOfTheBook[k];

                        }
                    }
                    string nameOfTheBook = partsOfNameOfTheBook[0];     // название книги из TextBox 
                    if (nameOfTheBook != "new")
                    {
                        if (book != null && book.Name != nameOfTheBook)
                        {
                            bool flag1 = false;
                            foreach (Book p in SystemOfBookStore.booksInStore.Keys)
                            {
                                if (p.Author == book.Author && p.Name == nameOfTheBook)
                                {
                                    flag1 = true;                                               // сравнение полученного названия книги с имеющимися в магазине, определение заказываемой книги
                                    book = p;
                                    break;
                                }
                            }
                            if (!flag1)
                            {
                                flag = false;
                                MessageBox.Show("Check that the book information you entered is correct!");
                                break;
                            }
                        }
                    }
                    else if (nameOfTheBook == "new" && book != null)
                    {
                        foreach (Book p in SystemOfBookStore.booksInStore.Keys)      //  определение новой книги автора
                        {
                            if (book.Author == p.Author && p.YearOfEdition > book.YearOfEdition)
                            { book = p; }
                        }
                    }

                    if (book != null)
                    {
                        if (!OrderOfCustomer.OrderedBoooks.ContainsKey(book))
                        {
                            OrderOfCustomer.OrderedBoooks.Add(book, int.Parse(numbersOfCopies[i].Text));  // добавление полученной книги в список заказываемых книг текущего заказа
                        }
                        else
                        {
                            OrderOfCustomer.OrderedBoooks[book] += int.Parse(numbersOfCopies[i].Text);     // если книга уже есть в списке, то добавление кол-ва ее экземпляров
                        }
                    }
                }
                else if (authors[i].Visibility == Visibility.Visible)
                {
                    flag = false;
                    MessageBox.Show("Check that the book information you entered is correct!");
                    break;
                }
            }

            WorkOfSystem work = this.Owner as WorkOfSystem;

            if (work != null && flag == true)
            {
                OrderOfCustomer.DayWhenOrderWasMade = int.Parse(work.currentDay.Text);    // получения дня, когда заказ был сделан

                this.Close();
                work.WindowStartupLocation = WindowStartupLocation.CenterOwner;  //  закрытие окна заказа, возвращение к окну WorkOfSystem
                work.Show();
                work.SellBooks(OrderOfCustomer);   // продажа книг в текущем заказе, если они есть в наличии 
                if (OrderOfCustomer.OrderedBoooks.Count == 0)
                {
                    work.SystemOfBookStore.outstandingOrders.Remove(OrderOfCustomer); // если все книги уже куплены заказчиком, то его заказ удаляется
                }
                else
                {
                    work.SystemOfBookStore.outstandingOrders.Add(OrderOfCustomer);           // добавление заказа в список невыполненных заказов 
                }
            }
        }

    }
}
