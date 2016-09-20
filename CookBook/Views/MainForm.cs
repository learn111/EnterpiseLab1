using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL.Models;
using Presentation.Views;

namespace CookBook.Views
{
    public partial class MainForm : Form, IMainView
    {
        private readonly ApplicationContext _applicationContext;

        public MainForm(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
            InitializeComponent();
        }

        public new void ShowDialog()
        {
            _applicationContext.MainForm = this;
            Application.Run(_applicationContext);
        }

        public event Action FoodstuffsClicked;
        public event Action MeasurementUnitsClicked;
        public event Action DishTypesClicked;
        public event Action DishesClicked;
        public event Action DishesConfigClicked;
        public event Action GenerateReportClicked;

        public IEnumerable<DishCookModel> Dishes
        {
            get { return (IEnumerable<DishCookModel>) bsDishes.DataSource; }
            set { bsDishes.DataSource = value.ToList(); }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void ингридиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodstuffsClicked?.Invoke();
        }

        private void единицыИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeasurementUnitsClicked?.Invoke();
        }

        private void типыБлюдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DishTypesClicked?.Invoke();
        }

        private void блюдаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DishesClicked?.Invoke();
        }

        private void настройкаБлюдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DishesConfigClicked?.Invoke();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            GenerateReportClicked?.Invoke();
        }
    }
}