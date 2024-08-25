using System.ComponentModel.DataAnnotations;

namespace BethanysPieShopAdmin.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public ICollection<OrderDetail>? OrderDetails { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string AddressLine1 { get; set; } = string.Empty;

        public string? AddressLine2 { get; set; }

        [Required(ErrorMessage = "Please enter your zip code")]
        public string ZipCode { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string? State { get; set; }

        public DateTime OrderPlaced { get; set; }

        public decimal OrderTotal { get; set; }

    }
}
