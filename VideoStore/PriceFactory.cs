using System;

namespace VideoStore
{
    public class PriceFactory
    {
        public static Price GetPriceByMovieType(MovieType value)
        {
            Price _price = null;

            switch (value)
            {
                case MovieType.CHILDRENS:
                    _price = new ChildrensPrice();
                    break;
                case MovieType.NEW_RELEASE:
                    _price = new NewReleasePrice();
                    break;
                case MovieType.REGULAR:
                    _price = new RegularPrice();
                    break;
                default:
                    throw new Exception("Incorrect Price Code");
            }

            return _price;
        }
    }
}