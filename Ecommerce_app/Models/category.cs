using System.ComponentModel.DataAnnotations;

namespace Ecommerce_app.Models
{
    public class category
    {
        [Key]
        public int category_id { get; set; }
        public string category_name { get; set; }
    }
}
