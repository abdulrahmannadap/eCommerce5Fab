using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1eCommerce5Fab.Models
{
    public class Category : BaseModel
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
