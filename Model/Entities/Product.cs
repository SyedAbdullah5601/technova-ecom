using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using technova_ecom.Model.Entities;

namespace Model.Entities
{
    [Table("Product")]
    public class Product
    {
        [Column("product_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productId { get; set; }

        [Column("product_name")]
        [Display(Name = "Name")]
        public string? productName { get; set; }

        

        [Column("price")]
        [Display(Name = "price")]
        //[validation (regex= " ")]
        public string? price { get; set; }

        [Column("description")]
        [Display(Name = "description")]
        public string? description { get; set; }

        [Column("quantity")]
        [Display(Name = "quantity")]
        public string? quantity { get; set; }

        [Column("rating")]
        [Display(Name = "rating")]
        public string? rating { get; set; }

        // foregin key 
        [Column ("category_id")]
        public int categoryId { get; set; }

        //navigation key
        [ForeignKey("categoryId")]

        public Category category { get; set; }
    }
}
