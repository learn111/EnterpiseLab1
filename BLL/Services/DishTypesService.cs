using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Contracts;
using CommonContracts;
using DalContracts.DishType;
using DAL;

namespace BLL.Services
{
    public class DishTypesService : ServiceBase, IDishTypesService
    {
        public DishTypesService(IDalService dalService) : base(dalService)
        {
        }

        public IEnumerable<DishType> GetAll()
            => DalService.FormatOp(DishTypeProcedures.Get, new DishType());


        public void Update(DishType item)
        {
            var result = DalService.FormatOp(DishTypeProcedures.Update, item).Single();
            if (!string.IsNullOrEmpty(result.ErrorMessage))
                throw new Exception(result.ErrorMessage);
        }

        public void Delete(DishType item)
        {
            var result = DalService.FormatOp(DishTypeProcedures.Delete, item).SingleOrDefault();
            if (!string.IsNullOrEmpty(result?.ErrorMessage))
                throw new Exception(result.ErrorMessage);
        }

        public void Add(DishType item)
        {
            var result = DalService.FormatOp(DishTypeProcedures.Add, item).Single();
            if (!string.IsNullOrEmpty(result.ErrorMessage))
                throw new Exception(result.ErrorMessage);
        }
    }
}