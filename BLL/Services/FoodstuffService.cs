using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Contracts;
using CommonContracts;
using DalContracts.DishType;
using DalContracts.Foodstuff;
using DAL;

namespace BLL.Services
{
    public class FoodstuffService : ServiceBase, IFoodstuffService
    {
        public FoodstuffService(IDalService dalService) : base(dalService)
        {
        }

        public IEnumerable<Foodstuff> GetAll() => DalService.FormatOp(FoodstuffProcedures.Get, new Foodstuff());


        public void Update(Foodstuff item)
        {
            var result = DalService.FormatOp(FoodstuffProcedures.Update, item).Single();
            if (!string.IsNullOrEmpty(result.ErrorMessage))
                throw new Exception(result.ErrorMessage);
        }

        public void Delete(Foodstuff item)
        {
            var result = DalService.FormatOp(FoodstuffProcedures.Delete, item).SingleOrDefault();
            if (!string.IsNullOrEmpty(result?.ErrorMessage))
                throw new Exception(result.ErrorMessage);
        }

        public void Add(Foodstuff item)
        {
            var result = DalService.FormatOp(FoodstuffProcedures.Add, item).Single();
            if (!string.IsNullOrEmpty(result.ErrorMessage))
                throw new Exception(result.ErrorMessage);
        }
    }
}