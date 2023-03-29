using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;
using Tema1.Entities;

namespace Tema1
{
    public static class DbContext
    {
        public static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Antinevralgic",
                Price = 10,
                Stock = 5
            },

            new Product
            {
                Id = 2,
                Name = "Paracetamol",
                Price = 11,
                Stock = 20
            },
        }.ToList();
    }
}