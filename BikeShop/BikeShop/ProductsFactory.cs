﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BikeShop
{
    public class ProductsFactory
    {
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IEnumerable<Product> FindProducts(string searchString)
        {
            return products.Where(p => p.Title.Contains(searchString));
        }

        #region In-memory data
        // This code builds an in-memory product collection
        // but we could as well fectch it from a database
        // or web service and it would yield the same result.
        static IList<Product> products;
        static ProductsFactory()
        {
            products = new List<Product>();
            for (int i = 0; i < 100; i++)
            {
                products.Add(generateRandomProduct());
            }
        }

        static Random r = new Random(DateTime.Now.Millisecond);
        static Product generateRandomProduct()
        {
            var titles = new[] { "Classic city bike", "Vintage city bike", "Basic mountain bike", "Easy mountain bike", "Devil mountain bike" };
            var colors = new[] { "Red", "Blue", "Green", "Brown", "Gray", "Black" };

            return new Product()
            {
                Title = pickRandom(titles),
                Color = pickRandom(colors),
                Price = Math.Round(300M + (decimal)r.NextDouble() * 1700M, 2),
                Reference = "BK" + r.Next(100000).ToString("d8")
            };
        }
        static T pickRandom<T>(T[] array)
        {
            return array[r.Next(array.Length)];
        }
        #endregion
    }

    public class Product : Notifier
    {
        private string _title;
        private decimal _price;
        private string _color;
        private string _reference;

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged("Price");
            }
        }

        public string Color
        {
            get => _color;
            set
            {
                _color = value;
                OnPropertyChanged("Color");
            }
        }

        public string Reference
        {
            get => _reference;
            set
            {
                _reference = value;
                OnPropertyChanged("Reference");
            }
        }

    }
}
