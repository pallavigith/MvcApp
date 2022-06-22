using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApp.Models
{
    public class Book
    {
        [Key]
        [ScaffoldColumn(false)]

        public int Id { get; set; }
        [Display(Name="Book Name")]
        [Required(ErrorMessage ="Book Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "AuthorName is required")]
        [MaxLength(20)]

        public string AuthorName { get; set; }
        [Required(ErrorMessage = "PublisherName is required")]
        [MaxLength(40)]
        public String PublisherName{ get; set; }
        [Required(ErrorMessage = "PublishDate is required")]
        [DataType(DataType.Date)]
            
        public DateTime PublishDate { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Range(minimum:100,maximum:1000,ErrorMessage ="Price should between 100-1000")]

        public int Price { get; set; }
    }
}