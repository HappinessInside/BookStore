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
    
    public partial class ResultOfTheWorkOfBookstore : Window
    {
        public ResultOfTheWorkOfBookstore(ManagementSystemOfBookshop system)
        {
            InitializeComponent();
            numberOfDays.Text = system.NumberOfDays.ToString();   //  отображение числа дней работы магазина
            var books = system.soldBooks.OrderByDescending(s => s.Key.Rating);   // сортировка проданных книг по рейтингу
            foreach(var book in books)
            {
                resultTextBox.Text += book.Key.ToString() + "number of sold copies: " + book.Value + "\r\n" + "\r\n";    // отображение информации о проданных книгах
            }
            if(system.soldBooks.Count==0)
            {
                resultTextBox.Text = "During the period of the store not a single book was sold.";
            }
        }
        private void backToTopButton_Click(object sender, RoutedEventArgs e)  // клик по кнопке "В НАЧАЛО"
        {
            MainWindow mainWindow = new MainWindow();     //  создание самого первого окна с выбором параметров работы
            mainWindow.Show();
            this.Owner.Close();
            this.Owner.Owner.Close();
        }
        private void ResultOfWork_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Owner.Owner.Close();                    //  при закрытии окна закрывать все предыдущие спрятанные окна
            this.Owner.Owner.Close();
            this.Owner.Close();

        }


    }
}
