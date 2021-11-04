﻿using Sparcpoint.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sparcpoint.DataLayer.Repository
{
    public interface IProductRepository
    {
        Task<List<Products>> GetProducts();
        Task<Products> AddProduct(Products product);
        Task<List<Products>> SearchProduct(FilterModel filterModel);
    }
}
