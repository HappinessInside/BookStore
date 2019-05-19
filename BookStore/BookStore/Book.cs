using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Book
    {
        public string ThemesAndGenre { get; set; }       // свойства книги, определение их допустимых значений

        public string Author { get; set; }

        public string Name { get; set; }

        public string Publisher { get; set; }

        private int _yearOfEdition;

        public int YearOfEdition
        {
            get { return _yearOfEdition; }
            set
            {
                if (value >= 2000 && value <= 2019)
                {
                    _yearOfEdition = value;
                }
                else throw new ArgumentOutOfRangeException("Books with edition of this year have not been released yet or no longer in sale.");
            }

        }

        private int _numberOfPages;
        public int NumberOfPages
        {
            get { return _numberOfPages; }
            set
            {
                if (value > 0)
                {
                    _numberOfPages = value;
                }
                else throw new ArgumentOutOfRangeException("Number of pages in the book must be more than 0 pages!");
            }
        }

        private int _price;
        public int Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else throw new ArgumentOutOfRangeException("Price of the book must be more than 0 rubles!");
            }
        }
        private double _rating;
        public double Rating
        {
            get { return _rating; }
            set
            {
                if (value >= 0)
                {
                    _rating = value;
                }
                else throw new ArgumentOutOfRangeException("This rating can not be negative!");
            }
        }

        public Book(string themes, string author, string name ,string publisher, int year, int nmbPages, int price, double rating)
        {
            ThemesAndGenre = themes;
            Author=author;
            Name = name;
            Publisher = publisher;
            YearOfEdition = year;
            NumberOfPages = nmbPages;
            Price = price;
            Rating = rating;
        }

        public override string ToString()   // переопределение метода ToString()
        {
            string result = "author: " + Author + "   " + "name: " + Name + "\r\n" + "themes: " + ThemesAndGenre + "   " +
                            "publisher: " + Publisher + "\r\n" + "year: " + YearOfEdition + "   " + "number of pages: " +
                            NumberOfPages + "   " + "price: " + Price + "\r\n" + "rating " + Rating + "   ";
            return result;
        }

        public string DisplaySummaryInformation()
        {
            string result = "author: " + Author + "   " + "name: " + Name + "\r\n" + "themes: " + ThemesAndGenre + "   " +
                            "year: " + YearOfEdition + "   "  + "price: " + Price;
            return result;
        }
    }
}

