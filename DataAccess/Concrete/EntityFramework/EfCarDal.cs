using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, AutoContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (AutoContext context = new AutoContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                  CarName= c.Description,
                                  DailyPrice = c.DailyPrice,
                                  BrandName = b.BrandName,
                                  ColorName = co.ColorName
                             };
                return result.ToList();         
            }
        }
    }
}
