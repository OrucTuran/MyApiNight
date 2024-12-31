namespace MyApiNight.WebUI.DTOs.Product
{
    public class UpdateProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public int ProductPrice { get; set; }
    }
}
