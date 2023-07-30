using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Book
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int QtyOnHand { get; set; }

        public Book(string name, string description, string author, decimal price, int qtyOnHand)
        {
            Name = name;
            Description = description;
            Author = author;
            Price = price;
            QtyOnHand = qtyOnHand;
        }

        public override string ToString()
        {
            return
                $"Name: {Name}\n" +
                $"Description: {Description}\n" +
                $"Author: {Author}\n" +
                $"Price: {Price}\n" +
                $"Quantity On Hand: {QtyOnHand}";
        }
    }
}
