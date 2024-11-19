﻿using System.Collections.Generic;
using System.Linq;

public class CartItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
}

public class Cart
{
    public List<CartItem> Items { get; set; } = new List<CartItem>();

    public decimal TotalPrice => Items.Sum(item => item.Product.Price * item.Quantity);
}