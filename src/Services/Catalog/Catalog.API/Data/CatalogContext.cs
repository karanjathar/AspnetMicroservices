using Catalog.API.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        //public CatalogContext(ICatalogDatabaseSettings settings)
        //{
        //    var client = new MongoClient(settings.ConnectionString);
        //    var database = client.GetDatabase(settings.DatabaseName);
        //    Products = database.GetCollection<Product>(settings.CollectionName);
        //    CatalogContextSeed.SeedData(Products);
        //}


        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            Products = database.GetCollection<Product>(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            CatalogContextSeed.SeedData(Products);
        }
        public IMongoCollection<Product> Products { get; }
    }
}
