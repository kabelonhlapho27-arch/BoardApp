using System.Globalization;

namespace BoardApp.Models
{
    public class Board
    {
        //Board class properties
        public string BoardCode { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int FlashKb { get; set; }
        public decimal Price { get; set; }

        //Empty default constructor for the Board class
        public Board() { }

        //Constructor for the Board class with parameters

        public Board(string boardCode,string make, string model,int flashkb,decimal price)
        {
            BoardCode = boardCode;
            Make = make;
            Model = model;
            FlashKb = flashkb;
            Price = price;
        }

        //Override the ToString() method to return a string representation of the Board object
        public override string ToString()
        {
            return $"Board Code: {BoardCode}, Make: {Make}, Model: {Model}, Flash Size: {FlashKb}KB, Price: {Price.ToString("C", CultureInfo.CurrentCulture)}";
        }
    }
}
