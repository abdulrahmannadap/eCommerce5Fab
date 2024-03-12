using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary1eCommerce5Fab.Models
{
    public class Product : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Category Category { get; set; }
        [ForeignKey("Category")]
        public string CategoryId { get; set; }

    }
}
