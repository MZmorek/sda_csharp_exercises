﻿using System;

namespace sda_csharp_exercises
{
    public class Order 
    {
        private OrderItem[] items;

        public Order(OrderItem[] items)
        {
            this.items = items;
        }

        public void PrintOrder()
        {
            decimal total = 0;
            foreach (var item in items)
            {
                if (item is not null)
                {
                    Console.WriteLine(item.ToString());
                    total += item.GetValue();

                }
            }
            Console.WriteLine($"Wartość zamówienia wynosi: {total}");
        }
    }
}
