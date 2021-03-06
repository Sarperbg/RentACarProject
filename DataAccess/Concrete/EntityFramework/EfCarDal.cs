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
	public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
	{
		public List<CarDetailDto> GetCarDetails()
		{
			using (RentACarContext context = new RentACarContext())
			{
				var result = from car in context.Cars
							 join brand in context.Brands
							 on car.BrandId equals brand.BrandId
							 join color in context.Colors
							 on car.ColorId equals color.ColorId
							 select new CarDetailDto
							 {
								 CarId = car.Id,
								 BrandId = car.BrandId,
								 ColorId = car.ColorId,
								 BrandName = brand.BrandName,
								 Description = car.Description,
								 ColorName = color.ColorName,
								 ModelYear = car.ModelYear,
								 DailyPrice = car.DailyPrice,

							 };

				return result.ToList();
			}
		}






	}
}
