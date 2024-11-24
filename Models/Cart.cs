using System;
namespace ecommerce.Models;

public class Cart
{
    public Guid CartId { get; set; }
    public Guid UserId { get; set; }
    public Users Users { get; set; }
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
    public int  Quanity { get; set; }
    public DateTime DateAdded { get; set; }
};


