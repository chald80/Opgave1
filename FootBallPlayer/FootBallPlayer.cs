using System;

namespace Opgave1
{
    public class FootBallPlayer
    {

        private int _id;
        private string _name;
        private int _price;
        private int _shirtNumber;


        public FootBallPlayer(int id, string name, int price, int shirtNumber)
        {
            Id = id;
            Name = name;
            Price = price;
            ShirtNumber = shirtNumber;
        }

        public FootBallPlayer()
        {

        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value == null) throw new ArgumentNullException("name", "Name is null");
                if (value.Length < 4) throw new ArgumentException("Name length must be at least 4 characters");
                _name = value;
            }
        }
        public int Price
        {
            get => _price;
            set
            {
                if (value > 0) _price = value;
                else throw new ArgumentOutOfRangeException("Price", value, "Illegal");
            }
        }

        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (1 <= value && value <= 100) _shirtNumber = value;
                else throw new ArgumentOutOfRangeException("Shirtnumber", value, "du er en hat");
            }
        }

    }
}