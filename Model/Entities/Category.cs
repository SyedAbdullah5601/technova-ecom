using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;
using Model.Entities;

namespace technova_ecom.Model.Entities
{
    [Table("categories")]   
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("categoryId")]
        public int categoryId { get; set; }
        [Column("categoryName")]
        public string categoryName { get; set; }
        [Column("displayorder")]

        public string displayorder { get; set; }

        //navigation property - one category has many products 

        public ICollection<Product>? Products { get; set; }
    }
}
