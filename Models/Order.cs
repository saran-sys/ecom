using System;
namespace ecommerce.Models;

public class Order
{
    public Guid OrderId { get; set; }
    public Guid UserId { get; set; }
    public Users Users { get; set; }
    public DateTime Order_Date { get; set; }
    public int TotalAmount { get; set; }
    public string Status { get; set; }
    public string Delivery_Address { get; set; }
};


