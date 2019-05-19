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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BookStore;

namespace Implementation
{
 
    public partial class MainWindow : Window
    {
        private ManagementSystemOfBookshop system; // система контроля ассортимента книжного магазина

        public MainWindow()
        {
            InitializeComponent();
            system= new ManagementSystemOfBookshop();
        }

        private void FutherButton_Click(object sender, RoutedEventArgs e)
        {
            bool flag = true;
            try
            {
                system.NumberOfDays = int.Parse(numberOfDays.Text);      // получение введенных пользователем кол-ва дней работы 

                system.NumberOfCopiesForRequest = int.Parse(numberOfBooks.Text); // получение минимального кол-ва экземпляров книги. Если кол-во экземляров меньше этого числа, делается заявка в издательство
            }
            catch (Exception exception)   // произойдет, если пользователь ввел не все данные
            {
                flag = false;
                MessageBox.Show("Check if you entered the number of days and the number of copies of books.");
            }

            try
            {
                system.RetailMarginForNewBooks = int.Parse(retailMarginForNewBooks.Text);// получение  розничной наценки на новые книги
                system.UsualRetailMargin = int.Parse(usualRetailMargin.Text);  // получение обычной розничной наценки
            }
            catch (Exception exception)
            {
                flag = false;
                MessageBox.Show("Check if you entered retail margin.");
            }
            if (sciencePublisher.IsChecked == true)                         // добавление издательств, выбранных пользователем
            {   SciencePublisher spr = new SciencePublisher(system);
            }
            if (publishingHouseDrofa.IsChecked == true)
            {
                PublishingHouseDrofa phd = new PublishingHouseDrofa(system);
            }
            if (labirintPressPublisher.IsChecked == true)
            {
                LabirintPressPublisher lpp = new LabirintPressPublisher(system);
            }
            if (sciencePublisher.IsChecked == false && publishingHouseDrofa.IsChecked == false && 
                labirintPressPublisher.IsChecked == false)                    // произойдет, если не выбрано ни одно издательство
            {
                flag = false;
                MessageBox.Show("Select at least one publisher.");
            }
            if (flag)
            {                
                ChoiceOfBooks choiceOfBooks = new ChoiceOfBooks(system);           // открытие окна для выбора начального ассортимента книг
                choiceOfBooks.Owner = this;
                this.Hide();
                choiceOfBooks.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                choiceOfBooks.Show();
            }
        }
     
    }
}
