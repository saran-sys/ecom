using System;
namespace ecommerce.Models;
using System.ComponentModel.DataAnnotations;

public class OrderDetails
{
    [Key]
    public Guid OrderDetailId { get; set; }

    public Guid OrderId { get; set; }
    public Order Order { get; set; }
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
    public int SubTotal { get; set; }
};


