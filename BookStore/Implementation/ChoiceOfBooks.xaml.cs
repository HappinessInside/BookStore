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
using BookStore;  // ссылка на проект-библиотеку BookStore

namespace Implementation
{

    public partial class ChoiceOfBooks : Window
    {
        private ManagementSystemOfBookshop SystemOfBookStore;  // система контроля ассортимента книжного магазина
        private List<TextBox> Books= new List<TextBox>(); //  список элементов TextBox, в которые выводятся данные о книге
        private List<ComboBox> NumbersOfBooks= new List<ComboBox>();   // список элементов ComboBox, в которых выбирается первоначальный ассортимент
        public ChoiceOfBooks(ManagementSystemOfBookshop system)
        {
            InitializeComponent();
            SystemOfBookStore = system; // система контроля ассортимента книжного магазина передается от предыдущего окна MainWindow 
            List<TextBox> allBooks = new List<TextBox>();        
            List<ComboBox> numbersForAllBooks= new List<ComboBox>();
            allBooks.Add(textBox0);                                  // добавление всех элементов TextBox в список  
            allBooks.Add(textBox1);
            allBooks.Add(textBox2);
            allBooks.Add(textBox3);
            allBooks.Add(textBox4);
            allBooks.Add(textBox5);
            allBooks.Add(textBox6);
            allBooks.Add(textBox7);
            allBooks.Add(textBox8);
            allBooks.Add(textBox9);
            numbersForAllBooks.Add(comboBox0);                  //  добавление всех элементов ComboBox в список
            numbersForAllBooks.Add(comboBox1);
            numbersForAllBooks.Add(comboBox2);
            numbersForAllBooks.Add(comboBox3);
            numbersForAllBooks.Add(comboBox4);
            numbersForAllBooks.Add(comboBox5);
            numbersForAllBooks.Add(comboBox6);
            numbersForAllBooks.Add(comboBox7);
            numbersForAllBooks.Add(comboBox8);
            numbersForAllBooks.Add(comboBox9);
            for (int i = 0; i < system.booksInStore.Count; i++)     // число элементов в bookInStore зависит от того, сколько издательст выберет пользователь
            {
                Book book = system.booksInStore.ElementAt(i).Key;  
                Books.Add(allBooks[i]);  // добавление элементов TextBox в Books, то есть добавление полей под книги, выпускаемые выбранными пользователем издательствами
                Books[i].Text = book.Author + ", " + book.Name + ", " + book.Publisher;  //вывод информации о книгах в  system.booksInStore
                Books[i].Visibility =Visibility.Visible;     // делаем поле TextBox видимым для пользователя
                NumbersOfBooks.Add(numbersForAllBooks[i]);     // добавление элементов ComboBox, в которых будет выбираться количество экземпляров
                NumbersOfBooks[i].Visibility = Visibility.Visible;   // делаем элементы ComboBox видимыми

            }

        }

        private void StartButton_Click(object sender, RoutedEventArgs e)     // клик по кнопке начать работу системы
        {
            bool flag = true;
            for (int i = 0; i < SystemOfBookStore.booksInStore.Count; i++)
            {
                Book book = SystemOfBookStore.booksInStore.ElementAt(i).Key;
                try
                {
                    SystemOfBookStore.booksInStore[book] = int.Parse(NumbersOfBooks[i].Text);   // внесение значений, выбранных пользователем для первоначального количества экземпляров каждой книги

                }
                catch (Exception exception)        // произойдет исключение, если пользователь не выбрал никакое значение ComboBox
                {
                    flag = false;
                    
                }

            }
            if(flag)
            {
                WorkOfSystem workOfSystem = new WorkOfSystem(SystemOfBookStore);  // создаем экземляр окна WorkOfSystem
                workOfSystem.Owner = this;  
                this.Hide();
                workOfSystem.WindowStartupLocation = WindowStartupLocation.CenterOwner;    // первоначальное расположение окна
                workOfSystem.Show();   //показать окно
            }
            else { MessageBox.Show("Check if all values are entered."); }
        }

        private void ChoiceofBooks_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Close();          // при закрытии этого окна закрывать также предшествующее ему окно MainWindow, которое спрятано
            
        }

       

    }
}
