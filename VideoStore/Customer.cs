using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class Customer
    {
        private string _name; //姓名
        private List<Rental> _rentals = new List<Rental>(); //租借記錄

        public Customer(string name)
        {
            _name = name;
        }

        public void AddRental(Rental arg)
        {
            _rentals.Add(arg);
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string statement()
        {
            List<Rental> rentals = _rentals;
            string result = "Rental Record for " + Name + "\n";

            foreach (var each in rentals)// 取得租借記錄
            {
                //顯示此筆租借記錄
                result += "\t" + each.Movie.Title + "\t" +
                    each.getCharge() + "\n";
            }

            //footer 列印
            result += "Amount owed is " + getTotalCharge() + "\n";
            result += "You earned " + getTotalfrequentRenterPoints() + " frequent renter points ";
            return result;
        }

        public string Htmlstatement()
        {
            List<Rental> rentals = _rentals;
            string result = "<h1>Rental Record for <em>" + Name + "</em><h1>\n";

            foreach (var each in rentals)// 取得租借記錄
            {
                //顯示此筆租借記錄
                result +=  each.Movie.Title + " : " +
                    each.getCharge() + "<br/>\n";
            }

            //footer 列印
            result += "<p>Amount owed is <em>" + getTotalCharge() + "</em></p>\n";
            result += "<p>You earned <em>" + getTotalfrequentRenterPoints() + "</em> frequent renter points </p>";
            return result;
        }

        //總消費金額
        public double getTotalCharge()
        {
            return _rentals.Sum(x => x.getCharge());
        }
        //常客績點
        public double getTotalfrequentRenterPoints()
        {
            return _rentals.Sum(x => x.getFrequentRenterPoints());
        }

    }
}
