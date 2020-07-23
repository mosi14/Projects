using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EShop.Data.Models
{
    class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }

        public decimal OldPrice { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public int ImagesCount { get; set; }
        [Required]
        public bool Hidden { get; set; }

        public virtual ICollection<CategoryProduct> CategoryProducts { get; set; }


    }
}
