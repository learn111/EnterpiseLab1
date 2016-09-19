using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Contracts;
using CommonContracts;
using DalContracts.MeasurementUnits;
using DAL;

namespace BLL.Services
{
    public class MeasurementUnitsService : ServiceBase, IMeasurementUnitsService
    {
        public MeasurementUnitsService(IDalService dalService) : base(dalService)
        {
        }

        public IEnumerable<MeasurementUnit> GetAll()
            => DalService.FormatOp(MeasurementUnitsProcedures.Get, new MeasurementUnit());

        public void Update(MeasurementUnit measurementUnit)
        {
            var result = DalService.FormatOp(MeasurementUnitsProcedures.Update, measurementUnit).Single();
            if(!string.IsNullOrEmpty(result.ErrorMessage))
                throw new Exception(result.ErrorMessage);
        }

        public void Delete(MeasurementUnit measurementUnit)
        {
            var result = DalService.FormatOp(MeasurementUnitsProcedures.Delete, measurementUnit).SingleOrDefault();
            if (!string.IsNullOrEmpty(result?.ErrorMessage))
                throw new Exception(result.ErrorMessage);
        }

        public void Add(MeasurementUnit measurementUnit)
        {
            var result = DalService.FormatOp(MeasurementUnitsProcedures.Add, measurementUnit).Single();
            if (!string.IsNullOrEmpty(result.ErrorMessage))
                throw new Exception(result.ErrorMessage);
        }
    }
}