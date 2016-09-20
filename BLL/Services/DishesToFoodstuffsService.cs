using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Contracts;
using CommonContracts;
using DalContracts.DishesToFoodstuffs;
using DAL;

namespace BLL.Services
{
    public class DishesToFoodstuffsService : ServiceBase, IDishesToFoodstuffsService
    {
        public DishesToFoodstuffsService(IDalService dalService) : base(dalService)
        {
        }

        public IEnumerable<DishesToFoodstuffs> GetAll()
            => DalService.FormatOp(DishesToFoodstuffsProcedures.Get, new DishesToFoodstuffs());

        public void Update(DishesToFoodstuffs item)
        {
            var result = DalService.FormatOp(DishesToFoodstuffsProcedures.Update, item).Single();
            if (!string.IsNullOrEmpty(result.ErrorMessage))
                throw new Exception(result.ErrorMessage);
        }


        public void Delete(DishesToFoodstuffs item)
        {
            var result = DalService.FormatOp(DishesToFoodstuffsProcedures.Delete, item).SingleOrDefault();
            if (!string.IsNullOrEmpty(result?.ErrorMessage))
                throw new Exception(result.ErrorMessage);
        }

        public void Add(DishesToFoodstuffs item)
        {
            var result = DalService.FormatOp(DishesToFoodstuffsProcedures.Add, item).Single();
            if (!string.IsNullOrEmpty(result?.ErrorMessage))
                throw new Exception(result.ErrorMessage);
        }
    }
}