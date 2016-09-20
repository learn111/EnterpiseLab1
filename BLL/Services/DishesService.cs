using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Contracts;
using CommonContracts;
using DalContracts.Dish;
using DAL;

namespace BLL.Services
{
    public class DishesService : ServiceBase, IDishesService
    {
        public DishesService(IDalService dalService) : base(dalService)
        {
        }

        public IEnumerable<Dish> GetAll()
            => DalService.FormatOp(DishProcedures.Get, new Dish());

        public void Update(Dish item)
        {
            var result = DalService.FormatOp(DishProcedures.Update, item).Single();
            if (!string.IsNullOrEmpty(result.ErrorMessage))
                throw new Exception(result.ErrorMessage);
        }

        public void Delete(Dish item)
        {
            var result = DalService.FormatOp(DishProcedures.Delete, item).SingleOrDefault();
            if (!string.IsNullOrEmpty(result?.ErrorMessage))
                throw new Exception(result.ErrorMessage);
        }

        public void Add(Dish item)
        {
            var result = DalService.FormatOp(DishProcedures.Add, item).Single();
            if (!string.IsNullOrEmpty(result.ErrorMessage))
                throw new Exception(result.ErrorMessage);
        }
    }
}