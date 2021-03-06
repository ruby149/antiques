﻿using antiques.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace antiques
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int productID);
        public IEnumerable<Category>GetAllCategories();
        
        public Product AssignCategory();
        
        public void UpdateProduct(Product product);

        public void CreateProduct(Product product);

        public void EditProduct(Product product);

        public void DeleteProduct(Product Product);
       
    }

}
