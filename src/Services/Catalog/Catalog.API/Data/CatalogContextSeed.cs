﻿using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                Task task = productCollection.InsertManyAsync(GetPreconfiguredProducts());


            }

            static IEnumerable<Product> GetPreconfiguredProducts()
            {
                return new List<Product>()
                {
                    new Product()
                    {
                        Id = "1",
                        Name = "Karan",
                        Summary = "Football",
                        Description = "Playing",
                        ImageFile = "yes",
                        Price = 100,
                        Category = "Sports"
                    }


                };
            }
        }
    }
}
