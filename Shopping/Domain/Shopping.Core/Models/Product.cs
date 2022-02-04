namespace Shopping.Core.Models
{
    public class Product : Item
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsAviable { get; set; }
        public decimal  Price { get; set; }


    }
}
