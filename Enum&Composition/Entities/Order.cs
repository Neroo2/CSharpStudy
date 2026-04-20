using System;
using Enum_Composition.Entities.Enums;
using Microsoft.VisualBasic;


namespace Enum_Composition.Entities;

public class Order
{
    DateTime Moment;
    OrderStatus Status;
    List<OrderItem> Items = new();
    Client Client;


    public Order(DateTime moment, OrderStatus status, Client client)
    {
        Moment = moment;
        Status = status;
        Client = client;    
    }

    public void addItem(OrderItem i)
    {
        Items.Add(i);
    }

    public void removeItem(OrderItem i)
    {
        Items.Remove(i);
    }


    public double Total()
    {
        double sumTotal = 0;

        foreach(OrderItem item in Items)
        {
            sumTotal += item.SubTotal();
        }

        return sumTotal;
    }


}
