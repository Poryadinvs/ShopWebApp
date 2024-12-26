namespace ShopWebApp.Data.Identity
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Products", Schema = "data")]

    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
