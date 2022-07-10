using System.ComponentModel.DataAnnotations;

namespace aspnetcoreapp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } =string.Empty;


        [DataType(DataType.Date)]
        public DateTime RealeseDate { get; set; }
        public string GenRe { get; set; } = string.Empty;

        public decimal Price { get; set; }  


    }
}
