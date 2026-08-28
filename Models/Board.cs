using System.ComponentModel.DataAnnotations;
using System.Globalization;
using BoardApp.Infrastructure;

namespace BoardApp.Models
{
    public class Board
    {
        //Board class properties
        [Required(ErrorMessage ="The board code is required")]
        [StringLength(4,MinimumLength =4,ErrorMessage ="The board code must be 4 characters")]
        [Display(Name ="Board Code")]
        public string BoardCode { get; set; }
        [Key]

        [Required(ErrorMessage ="The board manufacturer is required")]
        [Display(Name ="Manufacturer")]
        public string Make { get; set; }

        [Required(ErrorMessage ="The board model is required")]
        [Display(Name ="Model")]
        public string Model { get; set; }

        [Required(ErrorMessage ="The flash size is required")]
        //[Range(16, 4096, ErrorMessage = "The flash size must be between 16 and 4096 inclusive")]
        [Display(Name ="Flash (KB)")]
        [VerifyFlashSize]
        public int ? FlashKb { get; set; }

        [Required(ErrorMessage ="The price is required")]
        [Range(1.00,5000.00,ErrorMessage ="The price must be between R1.00 and R5000.00 inclusive")]
        [Display(Name ="Price (R) ")]
        [DisplayFormat(DataFormatString ="{0:N2}",ApplyFormatInEditMode =false)]
        public decimal ? Price { get; set; }

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
            return $"Board Code: {BoardCode}, Make: {Make}, Model: {Model}, Flash Size: {FlashKb}KB, Price: R{Price:0.00}";
        }
    }
}
