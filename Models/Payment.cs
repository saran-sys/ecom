using System;
namespace ecommerce.Models;

public class Payment
{
    public Guid PaymentId { get; set; }
    public Guid OrderId { get; set; }
    public Order Order { get; set; }
    public DateTime PaymentDate { get; set; }
    public int AmountPaid { get; set; }
    public string PaymentMethod { get; set; }
    public string PaymentStatus { get; set; }
}

