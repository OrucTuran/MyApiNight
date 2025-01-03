﻿using MyApiNight.DataAccessLayer.Abstract;
using MyApiNight.DataAccessLayer.Context;
using MyApiNight.DataAccessLayer.Repositories;
using MyApiNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal //product a ozel bir metot tanimlanacaksa buradan (IProductDal) miras alsin diye
    {
        ApiContext context= new ApiContext();
        public EfProductDal(ApiContext context) : base(context)
        {
        }

        public int GetProductCount()
        {
            var value = context.Products.Count();
            return value;
        }
    }
}
