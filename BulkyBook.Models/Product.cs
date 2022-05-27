using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string ISBN { get; set; }
        
        [Required]
        [DisplayName("List Price")]
        [Range(1, 10000)]
        public double ListPrice { get; set; }
        [Required]
        [DisplayName("Price 1-50")]
        [Range(1, 10000)]
        public double Price { get; set; }
        [Required]
        [DisplayName("Price 51-100")]
        [Range(1, 10000)]
        public double Price50 { get; set; }
        [Required]
        [DisplayName("Price 100+")]
        [Range(1, 10000)]
        public double Price100 { get; set; }
        
        [ValidateNever]
        public string ImageUrl { get; set; }

        [Required]
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }

        [Required]
        [DisplayName("Cover Type")]
        public int CoverTypeId { get; set; }
        [ForeignKey("CoverTypeId")]
        [ValidateNever]
        public CoverType CoverType { get; set; }
    }
}
