using System.ComponentModel.DataAnnotations;

namespace Ecommerce_app.Models
{
    public class product
    {
        [Key]
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string product_price { get; set; }
        public string product_description { get; set; }
        public string product_image { get; set; }
        public int cat_id { get; set; }

        
    }
}
