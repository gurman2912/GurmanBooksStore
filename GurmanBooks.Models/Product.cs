using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GurmanBooks.Models
{
   public class Product
    {
        [Key]
        public int Id { get; set;}
        public string Title { get; set;}
        public string Description { get; set;}
        public string ISBN { get; set;}
        public string Author { get; set;}
        [Required]
        [Range(1,10000)]
        public double ListPrice { get; set;}
        public string ImageUrl { get; set;}

        [Required]
        public int CategoryId { get; set; }//Foreign Key reference
        [ForeignKey("CategoryId")]
        public Category Category { get; set;}

        [Required]
        public int CoverId { get; set; }  //Foreign Key reference
        [ForeignKey("CoverId")]
        public CoverType CoverType { get; set;}


    }
}
