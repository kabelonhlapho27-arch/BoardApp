using System.ComponentModel.DataAnnotations;
using BoardApp.Infrastructure;

namespace BoardApp.Models
{
    public class Board
    {
        //Properties
        [Key]
        [Required(ErrorMessage = "The board code is required.")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "The board code must have a length of 4.")]
        [Display(Name = "Board code")]
        public string BoardCode { get; set; }

        [Required(ErrorMessage = "The board manufacturer is required.")]
        [Display(Name = "Manufacturer")]
        public string Make { get; set; }

        [Required(ErrorMessage = "The board model is required.")]
        [Display(Name = "Model")]
        public string Model { get; set; }

        [Required(ErrorMessage = "The flash size is required.")]
        //[Range(16, 4096, ErrorMessage = "The flash size must be between 16 and 4096 inclusive.")]
        [VerifyFlashSize]
        [Display(Name = "Flash (KB)")]        
        public int? FlashKb { get; set; }

        [Required(ErrorMessage = "The price is required.")]
        [Range(1.00, 5000.00, ErrorMessage = "The price must be between R1.00 and R5000.00 inclusive.")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = false)]
        [Display(Name = "Price (R)")]
        public decimal? Price { get; set; }

        //Default Constructor
        public Board() { }
        //OverLoaded Constructor
        public Board(string boardCode,string make,string model,int flashKb,decimal price) 
        {
            BoardCode = boardCode;
            Make = make;
            Model = model;
            FlashKb = flashKb;
            Price = price;
        }
        //Overloaded ToString
        public override string ToString()
        {
            return $"{BoardCode}: {Make} {Model} with {FlashKb} KB flash at R{Price:0.00}";
        }
    }
}
