using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    public enum MovieType
    { 
        CHILDRENS = 2,
        REGULAR = 0,
        NEW_RELEASE =1
    }

    /// <summary>
    /// 純 Moive 資料型類別
    /// </summary>
    public class Movie
    {
        private string _title; //名稱
        private Price _price; //價格(代號)

        public string Title
        {
            get
            {
                return _title;
            }
        }

        public MovieType PriceCode
        {
            get {
                return _price.getPriceCode();
            }
            set
            {
                _price = PriceFactory.GetPriceByMovieType(value);
            }
        }

        public Movie(string title, MovieType priceCode)
        {
            _title = title;
            PriceCode = priceCode;
        }

        public double getCharge(int daysRented)
        {
            return _price.getCharge(daysRented);
        }

        public int getFrequentRenterPoints(int daysRented)
        {
            return _price.getFrequentRenterPoints(daysRented);
        }
    }
}
