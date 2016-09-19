using System.Collections.Generic;
using CommonContracts;

namespace BLL.Contracts
{
    public interface IMeasurementUnitsService
    {
        IEnumerable<MeasurementUnit> GetAll();
        void Update(MeasurementUnit measurementUnit);
        void Delete(MeasurementUnit measurementUnit);
        void Add(MeasurementUnit measurementUnit);
    }
}