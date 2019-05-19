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
    /// <summary>
    /// Логика взаимодействия для ReviewOfTheBooks.xaml
    /// </summary>
    public partial class ReviewOfTheBooks : Window
    {  
        public ReviewOfTheBooks(ManagementSystemOfBookshop system, bool iforder)
        {
            InitializeComponent();  
            reviewOfOrders.Clear(); // очисить поле отображения информации
            int number = 0;  // номер заказа или заявки
            if (iforder) // если отображается заказ 
            {
                foreach (var p in system.outstandingOrders)
                {
                    number++;
                    reviewOfOrders.Text += "Order number" + number.ToString() + "   " + "surname of the customer: " + p.SurnameOfTheCustomer + "   " + "phone number: " +  // отображение  параметров всех невыполненных заказов
                                           p.phoneNumber + "\r\n" + "ordered books:" + "\r\n";
                    foreach (Book book in p.OrderedBoooks.Keys)
                    {
                        reviewOfOrders.Text += book.DisplaySummaryInformation() + "   " + "number of copies: " + p.OrderedBoooks[book] + "\r\n";

                    }

                    reviewOfOrders.Text += "\r\n";



                }
                if (system.outstandingOrders.Count == 0)   // если невыполненных заказов нет
                {
                    reviewOfOrders.Text = "Currently, there are no outstanding orders.";
                }
            }
            else  // если заявка
            {
                foreach (RequestToPublisher request in system.requests)
                {
                    number++;
                    reviewOfOrders.Text += "Request number " + number.ToString() + "   " + "Day when it was made: " + request.DayWhenRequestWasMade + "\r\n" + "required books:" + "\r\n";  //отображение параметров всех невыполненных заявок
                    foreach (Book book in request.rangeOfBooks.Keys)
                    {
                        reviewOfOrders.Text += "author: " + book.Author + "   " + "name: " + book.Name+"   " + "number of copies: " + request.rangeOfBooks[book][0] + "   " + "day when copies will receive: " +request.rangeOfBooks[book][1] +"\r\n";

                    }

                    reviewOfOrders.Text += "\r\n";
                }
                if (system.requests.Count == 0)  // если невыполненных заявок нет
                {
                    reviewOfOrders.Text = "Currently, there are no outstanding requests.";
                }


            }






        }
    }
}
