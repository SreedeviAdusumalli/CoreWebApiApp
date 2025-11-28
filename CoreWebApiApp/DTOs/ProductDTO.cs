namespace CoreWebApiApp.DTOs
{
    public class ProductDTO   //DTO used for the API response
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        //only the category name is exposed so that unnecessary information is not provided to the client
        public string CategoryName { get; set; } = null!;


    }
}
