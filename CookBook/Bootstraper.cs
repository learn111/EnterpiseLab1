﻿using System.Windows.Forms;
using BLL.Contracts;
using BLL.Services;
using CookBook.Views;
using DAL;
using Presentation.Common;
using Presentation.Views;

namespace CookBook
{
    internal static class Bootstraper
    {
        private static IApplicationController _applicationController;

        public static IApplicationController ApplicationController =>
            _applicationController ?? (_applicationController = GetAppController());

        private static IApplicationController GetAppController()
        {
            return new ApplicationController(new UnityAdapter())
                .RegisterInstance(new ApplicationContext())
                .RegisterView<IMainView, MainForm>()
                .RegisterView<IMeasurementUnitsView, MeasurementUnitsForm>()
                .RegisterView<IDishTypesView, DishTypesForm>()
                .RegisterView<IFoodstuffView, FoodstuffsForm>()
                .RegisterView<IDishesView, DishesForm>()
                .RegisterView<IDishesToFoodstuffsView, DishesToFoodstuffsForm>()
                .RegisterService<IDalService, DalService>()
                .RegisterService<IMeasurementUnitsService, MeasurementUnitsService>()
                .RegisterService<IFoodstuffService, FoodstuffService>()
                .RegisterService<IDishTypesService, DishTypesService>()
                .RegisterService<IDishesService, DishesService>()
                .RegisterService<IDishesToFoodstuffsService, DishesToFoodstuffsService>()
                .RegisterService<IReportGenerationService, ReportGenerationService>();
        }
    }
}